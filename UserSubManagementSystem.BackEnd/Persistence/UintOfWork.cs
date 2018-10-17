using UserSubManagementSystem.BackEnd.Core;
using UserSubManagementSystem.BackEnd.Core.Repositories;
using UserSubManagementSystem.BackEnd.Persistence.Repositories;

namespace UserSubManagementSystem.BackEnd.Persistence
{
    public class UintOfWork : IUnitOfWork
    {
        private readonly UserMSDBContext _context;

        public UintOfWork(UserMSDBContext context)
        {
            _context = context;
        }

        public IUserRepository Users =>new UserRepository(_context);

        public int Complete()
        {
            return _context.SaveChanges();
        }

 
    }
}