using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMVCCaseStudy.Models
{
    public class Catogery
    {
        [Key]
        public string CID { get; set; }
        public string CName { get; set; }
        public string CDetails { get; set; }


    }
}
