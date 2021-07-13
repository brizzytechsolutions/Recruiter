using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recruiter.Models
{
    public class Package
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        [Display(Name = "In Stock")]
        public bool InStock { get; set; }
        [Display(Name = "Date Received")]
        public DateTime DateStored { get; set; }
    }
}
