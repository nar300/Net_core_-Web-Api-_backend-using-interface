using Blogpost.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Blogpost.Data
{
    public class BlogDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-0N1R6GU\SQLEXPRESS;database=Blogpost;integrated security=true;");
        }
        public DbSet<blg> blgs { get; set; }
    }
}
