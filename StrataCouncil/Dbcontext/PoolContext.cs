using StrataCouncil.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StrataCouncil.Dbcontext
{
    public class PoolContext: DbContext
    {
        public PoolContext() : base() { }
        public DbSet<Measure> Measures { get; set; }
        public DbSet<Vote> Votes { get; set; }
    }
}