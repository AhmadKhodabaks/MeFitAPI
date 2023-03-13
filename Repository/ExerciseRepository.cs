using MeFitAPI.DataAccess;
using MeFitAPI.Models.Domain;
using MeFitAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MeFitAPI.Repository
{
    public class ExerciseRepository : Repository<Exercise>, IExerciseRepository
    {
        private readonly MeFitDbContext _context;

        public ExerciseRepository(MeFitDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Exercise> UpdateAsync(Exercise entity)
        {
            _context.Exercises.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
