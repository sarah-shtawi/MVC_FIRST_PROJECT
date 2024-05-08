using FirstProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet <Employee> Employees {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=MVC;trusted_connection=true;trustServerCertificate=true");

        }
    }
}
