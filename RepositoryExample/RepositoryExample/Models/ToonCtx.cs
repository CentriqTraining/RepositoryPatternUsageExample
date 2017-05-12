using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryExample.Models
{
    public class ToonCtx : DbContext
    {
        public ToonCtx()
        {
            Database.SetInitializer<ToonCtx>(new DBInit());
        }
        public DbSet<Employee> Employees { get; set; }
    }
}