using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Corse> Corses { get; set; }
        public DbSet<StudentCorse> StudentCorses { get; set; }

        public Context()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=EF_Test;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentCorse>()
                .HasKey(x => new {
                    x.StudentId,
                    x.CorseId
                });

            builder.Entity<StudentCorse>()
                .HasOne(x => x.Student)
                .WithMany(t => t.StudentCorse)
                .HasForeignKey(fk => fk.StudentId);

            builder.Entity<StudentCorse>()
                .HasOne(x => x.Corse)
                .WithMany(t => t.StudentCorse)
                .HasForeignKey(fk => fk.CorseId);
        }
    }
}
