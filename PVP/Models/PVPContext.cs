using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PVP.Models
{
    public class PVPContext : DbContext
    {
        public PVPContext(DbContextOptions<PVPContext> options) : base(options)
        {

        }

        public DbSet<User> Users { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey(u => u.id).HasName("id");
            modelBuilder.Entity<User>().HasIndex(u => u.mail).HasDatabaseName("Email");
            modelBuilder.Entity<User>().HasIndex(u => u.pass_hash).HasDatabaseName("Pass_hash");

            modelBuilder.Entity<User>().Property(u => u.id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<User>().Property(u => u.mail).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(u => u.pass_hash).HasColumnType("nvarchar(150)").IsRequired();
        }
    }
}
