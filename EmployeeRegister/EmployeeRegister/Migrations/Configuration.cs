namespace EmployeeRegister.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegister.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeRegister.DataAccessLayer.RegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                { FirstName = "Michael", LastName = "Jackson", Salary = 500,
                    Position = "Cashier", Department = "Music" },
                
                new Employee()
                {
                    FirstName = "Johnny",
                    LastName = "Depp",
                    Salary = 500,
                    Position = "Cashier",
                    Department = "Movies"
                },

                new Employee()
                {
                    FirstName = "Albert",
                    LastName = "Einstein",
                    Salary = 600,
                    Position = "Sales Rep",
                    Department = "Science"
                },

                new Employee()
                {
                    FirstName = "Donald",
                    LastName = "Trump",
                    Salary = 200,
                    Position = "Cleaner",
                    Department = "Maintenance"
                },
                
                new Employee()
                {
                    FirstName = "Hillary",
                    LastName = "Clinton",
                    Salary = 900,
                    Position = "Store Manager",
                    Department = "Admin"                
                });


        }
    }
}
