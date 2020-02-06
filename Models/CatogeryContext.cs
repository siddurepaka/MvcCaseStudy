using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmartMVCCaseStudy.Models
{
    public class CatogeryContext:DbContext
    {
        public CatogeryContext(DbContextOptions<CatogeryContext>options):base(options)
        { }
        public DbSet<Catogery> catogeries { get; set; }
    }
}
