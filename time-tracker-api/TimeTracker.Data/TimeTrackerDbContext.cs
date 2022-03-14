using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeTracker.Data.Models;

namespace TimeTracker.Data
{
    public class TimeTrackerDbContext : IdentityDbContext
    {
        public TimeTrackerDbContext()
        {

        }

        public TimeTrackerDbContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Day> Days {get; set;}
        public virtual DbSet<Project> Projects {get; set;}
        public virtual DbSet<User> Users {get; set;}
        public virtual DbSet<Week> Weeks {get; set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.LoggedWeeks).WithOne(s => s.User).HasForeignKey(s => s.UserId);
            modelBuilder.Entity<Week>().HasMany(u => u.Days).WithOne(s => s.Week).HasForeignKey(s => s.WeekId);
            modelBuilder.Entity<Day>().HasMany(u => u.Projects).WithOne(s => s.Day).HasForeignKey(s => s.DayId);
        }
    }
}