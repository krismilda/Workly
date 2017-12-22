using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workly.Models
{
    public class InterestedJobs
    {
        public int Id { get; set; }
        public int WorklyUserId { get; set; }
        public int JobId { get; set; }
    }
}