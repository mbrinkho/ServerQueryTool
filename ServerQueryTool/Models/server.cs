namespace ServerQueryTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Server
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid GUID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Owner { get; set; }

        public DateTime? CreatedDateUTC { get; set; }

        [StringLength(50)]
        public string RequestedUser { get; set; }

        [StringLength(50)]
        public string CreatedUser { get; set; }

        [StringLength(50)]
        public string DNSHostName { get; set; }

        [StringLength(50)]
        public string OperatingSystem { get; set; }

        [StringLength(200)]
        public string CanonicalName { get; set; }

        [StringLength(200)]
        public string DistinguishedName { get; set; }

        public DateTime? ADModifiedDateUTC { get; set; }

        public bool? ADEnabled { get; set; }

        [StringLength(50)]
        public string IPv4Address { get; set; }

        public DateTime? LastLogonDateUTC { get; set; }

        [StringLength(50)]
        public string VMHost { get; set; }

        [StringLength(125)]
        public string SerialNumber { get; set; }

        public byte? CPUSockets { get; set; }

        public byte? CPUCores { get; set; }

        //public string TotalMemoryGB { get; set; }

        [StringLength(50)]
        public string FolderID { get; set; }

        [StringLength(50)]
        public string ResourcePool { get; set; }

        [StringLength(10)]
        public string VMVersion { get; set; }

        //public string TotalDiskGB { get; set; }


        //public string UsedDiskGB { get; set; }

        [StringLength(50)]
        public string VMID { get; set; }

        [StringLength(50)]
        public string BuildTemplate { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Deleted { get; set; }

        [StringLength(50)]
        public string DeletedUser { get; set; }

        public DateTime? DeletedDateUTC { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }
    }
}
