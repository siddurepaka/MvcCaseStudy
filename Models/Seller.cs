using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMVCCaseStudy.Models
{
    public class Seller
    {
        [Key]
        public int Sid { get; set; }
        public string SUname {get;set;}
        public string SPassword { get; set; }
        public string SEmail { get; set; }
        public int SMobileNo { get; set; }
        public string SCompanyName { get; set; }



    }
}
