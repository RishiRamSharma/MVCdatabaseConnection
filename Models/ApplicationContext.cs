using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCdatabaseConnection.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext():base("conString")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        
        
    }
}