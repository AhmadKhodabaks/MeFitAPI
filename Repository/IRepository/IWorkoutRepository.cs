using MeFitAPI.Models.Domain;
using System.Linq.Expressions;

namespace MeFitAPI.Repository.IRepository
{
    public interface IWorkoutRepository : IRepository<Workout>
    {
        Task<Workout> UpdateAsync(Workout entity);
    }
}
