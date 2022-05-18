using Bionluk.DataAccess.Data;
using Bionluk.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.DataAccess.Migrations
{
    public class EFUserRepository : IUserRepository
    {
        private BionlukDbContext context;
        public EFUserRepository(BionlukDbContext context)
        {
            this.context = context;
        }
        
        public async Task<IList<User>> GetAll()
        {
            var users = await context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetById(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsersByCategory(string profession)
        {
            return await context.Users.Where(u => u.Title.Contains(profession)).ToListAsync();
        }
    }
}
