using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DataTransferObjects.Requests
{
    public class AddProductRequest
    {
        [Required(ErrorMessage ="ürün adı gereklidir.")]
        [StringLength(50, ErrorMessage ="50 karakterden uzun olamaz")]
        [MinLength(3, ErrorMessage ="3 karakterden az olamaz")]
        public string Name { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public double? Price { get; set; }
        public int? CategoryId { get; set; }
        public string ImageUrl { get; set; }
        public int? Stock { get; set; }
    }
}
