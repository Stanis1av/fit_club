namespace FitnessClub.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceGroups")]
    public partial class ServiceGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceGroup()
        {
            ServiceOrders = new HashSet<ServiceOrder>();
        }

        public int ServiceGroupId { get; set; }

        [Required]
        [StringLength(64)]
        public string ServiceGroupName { get; set; }

        public TimeSpan? MondayTime { get; set; }

        public TimeSpan? Tuesday { get; set; }

        public TimeSpan? Wednesday { get; set; }

        public TimeSpan? Thursday { get; set; }

        public TimeSpan? Friday { get; set; }

        public TimeSpan? Saturday { get; set; }

        public TimeSpan? Sunday { get; set; }

        public int Service_ServiceId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceOrder> ServiceOrders { get; set; }

        public virtual Service Service { get; set; }
    }
}
