namespace FitnessClub.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceImages")]
    public partial class ServiceImage
    {
        public int ServiceImageId { get; set; }

        [Required]
        [StringLength(64)]
        public string ServiceImagePath { get; set; }

        public int? Service_ServiceId { get; set; }

        public virtual Service Service { get; set; }
    }
}
