using MeFitAPI.DataAccess;
using MeFitAPI.Models.Domain;
using MeFitAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MeFitAPI.Repository
{
    public class WorkoutRepository : Repository<Workout>, IWorkoutRepository
    {
        private readonly MeFitDbContext _context;

        public WorkoutRepository(MeFitDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Workout> UpdateAsync(Workout entity)
        {
            _context.Workouts.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
