using Bionluk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.DataAccess
{
    public interface IUserRepository:IRepository<User>
    {
       Task<IEnumerable<User>> GetUsersByName(string name);
    }
}
