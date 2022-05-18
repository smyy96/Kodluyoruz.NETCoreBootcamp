using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.DataTransferObjects.Request
{
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public String Surname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNum { get; set; }
        public String Title { get; set; }
        public string? About { get; set; }
        public int Price { get; set; }

        public int CategoryId { get; set; }
    }
}
