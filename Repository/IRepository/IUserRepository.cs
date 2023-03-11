using MeFitAPI.Models.Domain;
using System.Linq.Expressions;

namespace MeFitAPI.Repository.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> UpdateAsync(User entity);
    }
}
