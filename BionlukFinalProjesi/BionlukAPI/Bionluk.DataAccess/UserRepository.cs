using Bionluk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.DataAccess
{
    public class UserRepository : IUserRepository
    {
        //private readonly IUserRepository _userRepository;
        private List<User> users;

        public UserRepository()
        {
            users = new List<User>
            {
                new User {Id=1, Name = "Sümeyye",Surname="Coşkun",Email="sumeyyecoskun.sc@gmail.com",PhoneNum="555454545",Price=100 ,About="C# ile otomasyon ödevlerinizi yapabilirim.", Title="Bilgisayar Mühendisi",CategoryId=1},

                new User {Id=2, Name = "Bulut",Surname="Işık",Email="",PhoneNum="",Price=10000 ,About="Beni kollarınızın arasına alıp severseniz gırlama sesim ile psikolojinizi düzeltebilirim. (Sarılmayı fazla abartmayın tırnaklarım.)", Title="Ben bir kediyim.",CategoryId=2},

                new User {Id=3, Name = "Selim",Surname="Aklı",Email="selim@gmail.com",PhoneNum="000011111",Price=350 ,About="Ben, bitcoin ödeme ağ geçitli network marketing yazılımı yaparım", Title="Web Yazılım",CategoryId=3}
            };
        }

        public async Task<IList<User>> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        Task<User> IRepository<User>.GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
