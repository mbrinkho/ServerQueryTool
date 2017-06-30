namespace ServerQueryTool.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CMD : DbContext
    {
        public CMD()
            : base("name=CMD")
        {
        }

        public virtual DbSet<Server> Servers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Server>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.Owner)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.RequestedUser)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.CreatedUser)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.DNSHostName)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.OperatingSystem)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.CanonicalName)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.DistinguishedName)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.IPv4Address)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.VMHost)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            //modelBuilder.Entity<Server>()
            //    .Property(e => e.TotalMemoryGB);

            modelBuilder.Entity<Server>()
                .Property(e => e.FolderID)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.ResourcePool)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.VMVersion)
                .IsUnicode(false);

            //modelBuilder.Entity<Server>()
            //    .Property(e => e.TotalDiskGB);

            //modelBuilder.Entity<Server>()
            //    .Property(e => e.UsedDiskGB);

            modelBuilder.Entity<Server>()
                .Property(e => e.VMID)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.BuildTemplate)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.DeletedUser)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.Notes)
                .IsUnicode(false);
        }
    }
}
