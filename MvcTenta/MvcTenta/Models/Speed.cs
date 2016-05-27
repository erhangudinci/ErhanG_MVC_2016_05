using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace MvcTenta.Models
{
    public class Speed
    {
        public double GetCurrentSpeed(string inputM, string inputS)
        {
            string inputMeter = inputM.Replace(".", ",");
            string inputSeconds = inputS.Replace(".", ",");
            double m = double.Parse(inputMeter);
            double s = double.Parse(inputSeconds);
            double sum = m/s;
            return sum;
        }
    }
}