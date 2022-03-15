namespace FitnessClub.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clients")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Rewiews = new HashSet<Rewiew>();
            Subscriptions = new HashSet<Subscription>();
        }

        public int ClientId { get; set; }

        [Required]
        [StringLength(64)]
        public string ClientFirstName { get; set; }

        [Required]
        [StringLength(64)]
        public string ClientLastName { get; set; }

        [StringLength(64)]
        public string ClientMiddleName { get; set; }

        public DateTime ClientDateOfBirth { get; set; }

        public float ClientMass { get; set; }

        public int ClientHeigth { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rewiew> Rewiews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
