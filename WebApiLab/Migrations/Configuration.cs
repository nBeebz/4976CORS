namespace WebApiLab.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiLab.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiLab.Models.StudContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiLab.Models.StudContext context)
        {

            context.Students.AddOrUpdate(
              s => s.StudentId,
              new Student {  StudentId = "A00111111", FirstName = "John", LastName = "Archer", Program = "CIT"},
              new Student {  StudentId = "A00222222", FirstName = "Jane", LastName = "Baker", Program = "CST"},
              new Student {  StudentId = "A00333333", FirstName = "Bill", LastName = "Carter", Program = "BTECH"},
              new Student {  StudentId = "A00444444", FirstName = "Judy", LastName = "Fisher", Program = "Nursing"}
            );

        }
    }
}
