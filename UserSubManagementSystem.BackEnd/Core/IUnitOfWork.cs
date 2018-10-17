using UserSubManagementSystem.BackEnd.Core.Repositories;

namespace UserSubManagementSystem.BackEnd.Core
{
    public interface IUnitOfWork 
    {
        int Complete();
        IUserRepository Users { get; }
    }
}
