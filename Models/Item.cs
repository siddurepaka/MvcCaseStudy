using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMVCCaseStudy.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }
        public string category_id { get; set; }
        public string subcategory_id { get; set; }
        public float price { get; set; }
        public string item_name { get; set; }
        public string description { get; set; }
        public int stock_number { get; set; }
        public string remarks { get; set; }

    }
}
