using MeFitAPI.DataAccess;
using MeFitAPI.Models.Domain;
using MeFitAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MeFitAPI.Repository
{
    public class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        private readonly MeFitDbContext _context;

        public ProfileRepository(MeFitDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Profile> UpdateAsync(Profile entity)
        {
            _context.Profiles.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
