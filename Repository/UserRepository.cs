using MeFitAPI.DataAccess;
using MeFitAPI.Models.Domain;
using MeFitAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MeFitAPI.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly MeFitDbContext _context;

        public UserRepository(MeFitDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
