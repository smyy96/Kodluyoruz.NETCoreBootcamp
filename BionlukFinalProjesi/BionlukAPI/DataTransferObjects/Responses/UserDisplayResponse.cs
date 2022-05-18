using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.DataTransferObjects.Responses
{
    public class UserDisplayResponse // ihtiyac duydugum veeriler
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Title { get; set; }
        public String About { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
    }
}
