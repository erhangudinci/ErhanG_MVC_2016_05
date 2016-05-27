using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace MvcTenta.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        [Required, MaxLength(30), Display(Name = "Namn")]
        public string Name { get; set; }
        [Required, MaxLength(40), Display(Name = "Adress")]
        public string Address { get; set; }
        public List<Product> Products { get; set; }
    }
}