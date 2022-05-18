using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.Entities
{
    public class User : IEntity
    {
      
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNum { get; set; }
        public String Title { get; set; }
        public string? About { get; set; }
        public int Price { get; set; }

        public int CategoryId { get; set; }
        public Category  Category { get; set; }

    }
}
