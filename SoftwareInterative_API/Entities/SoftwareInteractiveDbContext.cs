using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Entities
{
    public class SoftwareInteractiveDbContext : DbContext
    {
        private readonly string _connectionString;
        public SoftwareInteractiveDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SoftwareInteractiveDBConnection");
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Answer> Answers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
               .Property(q => q.Content)
               .IsRequired()
               .HasMaxLength(1000);

            modelBuilder.Entity<Option>()
                .Property(o => o.Content)
                .IsRequired()
                .HasMaxLength(500);
            modelBuilder.Entity<Option>()
                .Property(o => o.QuestionId)
                .IsRequired(); 

            modelBuilder.Entity<Answer>()
                .Property(a => a.UserName)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Answer>()
                .Property(a => a.OptionId)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
