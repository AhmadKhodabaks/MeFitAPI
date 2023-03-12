using MeFitAPI.Models.Domain;
using System.Linq.Expressions;

namespace MeFitAPI.Repository.IRepository
{
    public interface IGoalRepository : IRepository<Goal>
    {
        Task<Goal> UpdateAsync(Goal entity);
    }
}
