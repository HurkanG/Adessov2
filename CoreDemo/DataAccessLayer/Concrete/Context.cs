using System;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=localhost; User Id=sa; Password=reallyStrongPwd123; Database=AdessoDb; integrated security=true; Trusted_Connection=false; TrustServerCertificate=true;");
        }


        public DbSet<User> Users { get; set; }
        public DbSet<TravelPlan> TravelPlans { get; set; }
    

    }
}

