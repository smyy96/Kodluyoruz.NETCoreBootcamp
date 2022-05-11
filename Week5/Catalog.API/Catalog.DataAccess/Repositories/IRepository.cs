using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DataAccess.Repositories
{
    public interface IRepository<T> where T:IEntity,new() //Dogrudan veri ile calısmak, depodan verileri cekecek. T category ve product olacak
    {
        Task<IList<T>> GetAll();
        Task<T> GetId(int id);
    }
}
