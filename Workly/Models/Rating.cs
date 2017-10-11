using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workly.Models
{
    public class Rating
    {
        public int Rate { get; set; }
        public int Sum { get; set; }
        public int Times { get; set; }
        public double Average { get; set; }
        public string Email { get; set; }
        public Rating()
        {
            Sum = 0;
            Times = 0;
            Average = 0;
        }
    }
}