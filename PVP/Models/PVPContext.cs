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
        public DbSet<Device> Devices { set; get; }
        public DbSet<Info> Infos { set; get; }
        public DbSet<RealtimeInfo> RealtimeInfos { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey(u => u.id).HasName("id");
            modelBuilder.Entity<User>().HasIndex(u => u.mail).HasDatabaseName("Email");
            modelBuilder.Entity<User>().HasIndex(u => u.pass_hash).HasDatabaseName("Pass_hash");
            modelBuilder.Entity<User>().Property(u => u.id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<User>().Property(u => u.mail).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(u => u.pass_hash).HasColumnType("nvarchar(150)").IsRequired();
            //
            modelBuilder.Entity<Device>().ToTable("Devices");
            modelBuilder.Entity<Device>().HasKey(u => u.id).HasName("id");
            modelBuilder.Entity<Device>().Property(u => u.id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Device>().Property(u => u.tag).HasColumnType("nvarchar(50)").HasColumnName("tag");
            modelBuilder.Entity<Device>().Property(u => u.is_on).HasColumnType("tinyint(1)").IsRequired().HasColumnName("is_on");
            modelBuilder.Entity<Device>().Property(u => u.is_realtime).HasColumnType("tinyint(1)").IsRequired().HasColumnName("is_realtime");
            modelBuilder.Entity<Device>().Property(u => u.setup_string).HasColumnType("nvarchar(50)").IsRequired().HasColumnName("setup_string");
            modelBuilder.Entity<Device>().Property(u => u.treshold).HasColumnType("int").HasColumnName("treshold");
            modelBuilder.Entity<Device>().HasIndex(u => u.fk_user).HasDatabaseName("fk_user");
            modelBuilder.Entity<Device>().Property(u => u.fk_user).IsRequired().HasColumnName("fk_user");
            modelBuilder.Entity<Device>().HasOne(u => u.fk_userNavigation) // fk stuff
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.fk_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("has");
            //
            modelBuilder.Entity<Info>().ToTable("Infos");
            modelBuilder.Entity<Info>().HasKey(u => u.id).HasName("id");
            modelBuilder.Entity<Info>().Property(u => u.id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Info>().Property(u => u.date_time).HasColumnType("datetime").HasColumnName("date_time").IsRequired();
            modelBuilder.Entity<Info>().Property(u => u.wattage).HasColumnType("int").HasColumnName("wattage").IsRequired();
            modelBuilder.Entity<Info>().HasIndex(u => u.fk_device_id).HasDatabaseName("fk_device_id");
            modelBuilder.Entity<Info>().Property(u => u.fk_device_id).IsRequired().HasColumnName("fk_device_id");
            modelBuilder.Entity<Info>().HasOne(u => u.fk_device_idNavigation) // fk stuff
                    .WithMany(p => p.Infos)
                    .HasForeignKey(d => d.fk_device_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shows");
            //
            modelBuilder.Entity<RealtimeInfo>().ToTable("RealtimeInfos");
            modelBuilder.Entity<RealtimeInfo>().HasKey(u => u.id).HasName("id");
            modelBuilder.Entity<RealtimeInfo>().Property(u => u.id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<RealtimeInfo>().Property(u => u.wattage).HasColumnType("int").HasColumnName("wattage").IsRequired();
            modelBuilder.Entity<RealtimeInfo>().HasIndex(u => u.fk_device_id).HasDatabaseName("fk_device_id");
            modelBuilder.Entity<RealtimeInfo>().Property(u => u.fk_device_id).IsRequired().HasColumnName("fk_device_id");
        }
    }
}
