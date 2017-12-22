using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workly.Models
{
    public class WorklyUser
    {
        public int WorklyUserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Rating Rating { get; set; }
        public Review Review { get; set; }
        public List<Review> ReviewList { get; set; }
        public string Role { get; set; }
    }
}