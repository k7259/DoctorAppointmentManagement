using Microsoft.EntityFrameworkCore;

namespace DoctorAppointmentManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Speciality> Specialities { get; set; }
        public string connectionString;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {



        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}


   
