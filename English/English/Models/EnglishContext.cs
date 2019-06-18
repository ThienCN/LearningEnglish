using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace English.Models
{
    public class EnglishContext : DbContext
    {
        public EnglishContext() : base("name=EnglishConnectionString")
        {

        }

        public DbSet<Animals> Animals { get; set; }
        public DbSet<Number> Number { get; set; }
    }
}