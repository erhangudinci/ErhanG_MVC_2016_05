using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTenta.Models
{
    public class ProductNumberAttribute : ValidationAttribute 
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            var check = value.ToString().ToLower();
            return check.StartsWith("p-");
        }

        public override string FormatErrorMessage(string name)
        {
            return name + " startar inte på med ex p-22";
        }
    }
}