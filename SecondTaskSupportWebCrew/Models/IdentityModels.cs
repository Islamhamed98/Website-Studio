using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace SecondTaskSupportWebCrew.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet <Customer> Customer { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Category> Category { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}