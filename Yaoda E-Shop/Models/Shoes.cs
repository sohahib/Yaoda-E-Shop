using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yaoda_E_Shop.Models
{
    public class Shoes
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Preview")]
        public string ProductImageUrl { get; set; }
        [Display(Name="Product Name")]
        public string ProductName { get; set; }
        [Display (Name ="Description")]
        public string ProductDescription { get; set; }
        [Display (Name ="Price")]                   
        public double ProductPrice { get; set; }
        [Display(Name ="Quantity left")]
        public int ProductQuantity { get; set; }
    }
}
