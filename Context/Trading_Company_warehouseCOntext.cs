using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFcore_project.Context
{
    class Trading_Company_warehouseCOntext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Trading_Company;Integrated Security=True;TrustServerCertificate=True;");
    }
}
