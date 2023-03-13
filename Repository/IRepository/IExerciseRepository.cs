using MeFitAPI.Models.Domain;
using System.Linq.Expressions;

namespace MeFitAPI.Repository.IRepository
{
    public interface IExerciseRepository : IRepository<Exercise>
    {
        Task<Exercise> UpdateAsync(Exercise entity);
    }
}
