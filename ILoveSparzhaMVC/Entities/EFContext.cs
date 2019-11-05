using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ILoveSparzhaMVC.Entities
{

    public class EFContext : DbContext
    {
        public EFContext() : base("DefaultConnection")
        {
            Database.SetInitializer<EFContext>(new CreateDatabaseIfNotExists<EFContext>());

        }


        public DbSet<User> Users { get; set; }
    }

}