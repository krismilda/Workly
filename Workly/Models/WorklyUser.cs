using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workly.Models
{
    public class WorklyUser
    {
        public int WorklyUserId { get; set; }
        public string Email { get; set; }
        public float Rating { get; set; }
        public List<Review> Reviews { get; set; }
    }
}