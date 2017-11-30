using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeRegister.DataAccessLayer
{
    public class RegisterContext : DbContext
    {
        public RegisterContext() : base("EmployeeRegister")
        { }

        public DbSet<Models.Employee> Employees { get; set; }

    }
}