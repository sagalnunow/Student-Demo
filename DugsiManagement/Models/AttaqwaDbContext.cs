using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DugsiManagement.Models
{
    public class AttaqwaDbContext : DbContext
    {
        //1 Create method that talks to our connection string that was inside our web config
        public AttaqwaDbContext() :base("attaqwaDatabaseConnection")
        {
            Database.SetInitializer<AttaqwaDbContext>(new CreateDatabaseIfNotExists<AttaqwaDbContext>());
        }

        //2 add student and teacher classes that will be converted to database tables
        public  DbSet<Student> Students { get; set; }
     

    }
}