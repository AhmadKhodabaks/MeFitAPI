using MeFitAPI.Models.Domain;
using System.Linq.Expressions;

namespace MeFitAPI.Repository.IRepository
{
    public interface IProfileRepository : IRepository<Profile>
    {
        Task<Profile> UpdateAsync(Profile entity);
    }
}
