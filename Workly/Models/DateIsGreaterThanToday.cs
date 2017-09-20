using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Workly.Models
{
    public class DateIsGreaterThanToday: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Job job = (Job) validationContext.ObjectInstance;
            if (job.Start >= DateTime.Today)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Date should be greater than today");
            }
        }
    }
}