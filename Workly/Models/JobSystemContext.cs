using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Workly.Models
{
    public class JobSystemContext : DbContext
    {
        internal object Reviews;

        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public JobSystemContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<WorklyUser> WorklyUsers { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<InterestedJobs> InterestedJobs { get; set; }
    }
}
