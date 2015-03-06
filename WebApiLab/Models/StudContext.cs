using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Web;

namespace WebApiLab.Models
{
    public class StudContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}