namespace FitnessClub.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trainers")]
    public partial class Trainer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainer()
        {
            Subscriptions = new HashSet<Subscription>();
        }

        public int TrainerId { get; set; }

        [Required]
        [StringLength(64)]
        public string TrainerFirstName { get; set; }

        [Required]
        [StringLength(64)]
        public string TrainerLastName { get; set; }

        [StringLength(64)]
        public string TrainerMiddleName { get; set; }

        [StringLength(255)]
        public string TrainerDescription { get; set; }

        [Required]
        [StringLength(128)]
        public string TrainerPhotoPath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
