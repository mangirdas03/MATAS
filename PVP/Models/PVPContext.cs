using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PVP.Models
{
    public partial class pvpContext : DbContext
    {
        public pvpContext()
        {
        }

        public pvpContext(DbContextOptions<pvpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }
        public virtual DbSet<Info> Infos { get; set; }
        public virtual DbSet<Realtimeinfo> Realtimeinfos { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<ManufacturedDevice> ManufacturedDevices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=10.0.0.4; port=3306; user=pvp; password=Slaptazodis123!; database=pvp", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.17-mariadb"));
                //optionsBuilder.UseMySql("server=localhost; port=3306; user=pvp; password=pvp; database=pvp", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.17-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("devices");

                entity.HasIndex(e => e.FkUser, "fk_user");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FkUser)
                    .HasColumnType("int(11)")
                    .HasColumnName("fk_user");

                entity.Property(e => e.IsOn).HasColumnName("is_on");

                entity.Property(e => e.IsRealtime).HasColumnName("is_realtime");

                entity.Property(e => e.SetupString)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("setup_string")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("tag")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Treshold)
                    .HasColumnType("int(11)")
                    .HasColumnName("treshold");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("has");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Info>(entity =>
            {
                entity.ToTable("infos");

                entity.HasIndex(e => e.FkDeviceId, "fk_device_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.FkDeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fk_device_id");

                entity.Property(e => e.Wattage)
                    .HasColumnType("int(11)")
                    .HasColumnName("wattage");

                entity.HasOne(d => d.FkDevice)
                    .WithMany(p => p.Infos)
                    .HasForeignKey(d => d.FkDeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shows");
            });

            modelBuilder.Entity<Realtimeinfo>(entity =>
            {
                entity.ToTable("realtimeinfos");

                entity.HasIndex(e => e.FkDeviceId, "fk_device_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FkDeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fk_device_id");

                entity.Property(e => e.Wattage)
                    .HasColumnType("int(11)")
                    .HasColumnName("wattage");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Mail, "Email").IsUnique();

                entity.HasIndex(e => e.PassHash, "Pass_hash");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mail")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PassHash)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("pass_hash")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<ManufacturedDevice>(entity =>
            {
                entity.ToTable("manufactureddevices");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.SetupString)
                    .HasMaxLength(30)
                    .HasColumnName("setupString")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
