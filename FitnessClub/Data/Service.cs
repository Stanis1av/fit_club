namespace FitnessClub.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Services")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            Rewiews = new HashSet<Rewiew>();
            ServiceGroups = new HashSet<ServiceGroup>();
            ServiceImages = new HashSet<ServiceImage>();
        }

        public int ServiceId { get; set; }

        [Required]
        [StringLength(64)]
        public string ServiceName { get; set; }

        [Required]
        [StringLength(255)]
        public string ServiceDescription { get; set; }

        public decimal ServiceWeekCost { get; set; }

        [StringLength(128)]
        public string ServicePhotoPath { get; set; }
        [Required]
        public byte [] ServicesPhoto { get; set; }

        public int ServiceType_ServiceTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rewiew> Rewiews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceGroup> ServiceGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceImage> ServiceImages { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
