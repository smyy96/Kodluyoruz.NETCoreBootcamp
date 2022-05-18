using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.DataTransferObjects.Request
{
    public class AddUserRequest
    {
        [Required(ErrorMessage ="Kullanıcı adı zorunludur.")]
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Title { get; set; }
        public String About { get; set; }
        public string? PhoneNum { get; set; }

        [Required(ErrorMessage = "Ücret zorunludur.")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        public int CategoryId { get; set; }
    }
}
