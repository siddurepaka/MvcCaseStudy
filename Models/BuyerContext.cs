using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmartMVCCaseStudy.Models;

namespace EmartMVCCaseStudy.Models
{
    public class BuyerContext:DbContext
    {
        public BuyerContext(DbContextOptions<BuyerContext> options) : base(options)
        {

        }
        public DbSet<Buyer> Buyers { get; set; }
    }
}
