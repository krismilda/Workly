using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Workly.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        public int Stars { get; set; }

        [StringLength(2000)]
        public string Comment { get; set; }
    }
}