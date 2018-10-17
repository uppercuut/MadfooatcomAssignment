using UserSubManagementSystem.BackEnd.Core.Domain;
using UserSubManagementSystem.BackEnd.Core.Repositories;

namespace UserSubManagementSystem.BackEnd.Persistence.Repositories
{
    public class UserRepository : Repository<User> , IUserRepository
    {
        public UserRepository(UserMSDBContext context)
           : base(context)
        { }
        public UserMSDBContext UserMSDBContext
        {
            get { return Context as UserMSDBContext; }
        }


    }
}