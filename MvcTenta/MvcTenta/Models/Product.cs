using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace MvcTenta.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required, MaxLength(30), Display(Name = "Produkt Namn")]
        public string Name { get; set; }
        [Required, MinLength(5),MaxLength(80), Display(Name = "Beskrivning")]
        public string ProductText { get; set; }

        [Required, ProductNumber, MaxLength(15), Display(Name = "Produkt Nummer")]
        public string ProductNumber { get; set; }
        [Required, DataType(DataType.Currency), Range(0,100000), Display(Name = "Pris")]
        public decimal Price { get; set; }
        [Required, Range(0,10000), Display(Name = "I Lager")]
        public int ProductInStock { get; set; }
        public Store Store { get; set; }
        public int StoreId { get; set; }
    }
}