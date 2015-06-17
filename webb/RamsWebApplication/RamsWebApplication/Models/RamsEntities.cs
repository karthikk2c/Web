using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RamsWebApplication.Models
{
    public class RamsEntities:DbContext
    {
        public DbSet<Rams> rams { set; get; }
    }
}