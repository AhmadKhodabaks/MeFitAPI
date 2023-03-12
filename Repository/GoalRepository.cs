using MeFitAPI.DataAccess;
using MeFitAPI.Models.Domain;
using MeFitAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MeFitAPI.Repository
{
    public class GoalRepository : Repository<Goal>, IGoalRepository
    {
        private readonly MeFitDbContext _context;

        public GoalRepository(MeFitDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Goal> UpdateAsync(Goal entity)
        {
            _context.Goals.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
