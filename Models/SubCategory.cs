using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMVCCaseStudy.Models
{
    public class SubCategory
    {
        [Key]
        public string SubId { get; set; }
        public string SubName { get; set; }
    }
}
