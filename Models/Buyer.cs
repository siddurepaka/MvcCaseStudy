using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMVCCaseStudy.Models
{
    public class Buyer
    {
        [Key]
        public int Bid { get; set; }
        public string BUname { get; set; }
        
        public string BPassword { get; set; }
        public string BEmail { get; set; }
        public int BMobileNo { get; set; }
       public DateTime BDOB { get; set; }
    }
}
