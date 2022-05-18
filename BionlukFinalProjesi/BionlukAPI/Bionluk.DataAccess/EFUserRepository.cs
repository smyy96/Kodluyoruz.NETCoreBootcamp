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

        public async Task AddUser(User entity)
        {
            await this.context.AddAsync(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteUser(int entity)
        {
            var user=await context.Users.FirstOrDefaultAsync(x => x.Id == entity);
            context.Users.Remove(user);
            await context.SaveChangesAsync();
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

        //public async Task<IEnumerable<User>> GetUsersByCategory(string profession)
        //{
        //    return await context.Users.Where(u => u.Title.Contains(profession)).ToListAsync();
        //}

        public async Task<IEnumerable<User>> GetUsersByName(string name)
        {
            return await context.Users.Where(u => u.Name.Contains(name)).ToListAsync();
        }

        public async Task<bool> IsExists(int id)
        {
            return await context.Users.AnyAsync(p=>p.Id == id);
        }

        public async Task UpdateUser(User entity)
        {
            context.Users.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
