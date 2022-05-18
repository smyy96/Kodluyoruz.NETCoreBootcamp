using Bionluk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.DataAccess
{
    public interface IRepository<T> where T : IEntity, new()
    {
        Task<IList<T>> GetAll();
        Task<T> GetById(int id);
        Task AddUser(T entity);
        Task UpdateUser(T entity);
        Task DeleteUser(int entity);
        Task<bool> IsExists(int id);
    }
}
