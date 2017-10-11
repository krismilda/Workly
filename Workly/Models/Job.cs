
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Workly.Models
{
    public class Job
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Work { get; set; }
        [Required]
        [StringLength(50)]
        public string Field { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy - MM - d}")]
        [DateIsGreaterThanToday]
        public DateTime Start { get; set; }
        [Required]
        [StringLength(50)]
        public string Locality { get; set; }
        [Required]
        [Range(0, 10000)]
        public float Salary { get; set; }
        [StringLength(50)]
        public string Duration { get; set; }
    }
}