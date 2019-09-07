using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using bracketplusMVC.Models;

namespace bracketplusMVC.Context
{
    public class BracketPlusContext:DbContext
    {
        public BracketPlusContext() : base("BracketContext")
        {
            if (Database.Exists())
            {
                Database.SetInitializer<BracketPlusContext>(null);

            }
            else
            {
               // Database.SetInitializer<BracketPlusContext>(new DbInitializer());
                //Database.SetInitializer(new DbInitializer());
            }
            //base.Configuration.ProxyCreationEnabled = true;
            base.Configuration.ProxyCreationEnabled = false;

            //this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.LazyLoadingEnabled = false;
        }
        
        public DbSet<BusinessEntities> BusinessEntities { get; set; }
    }
}