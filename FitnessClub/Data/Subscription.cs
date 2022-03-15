namespace FitnessClub.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subscriptions")]
    public partial class Subscription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subscription()
        {
            ServiceOrders = new HashSet<ServiceOrder>();
        }

        public int SubscriptionId { get; set; }

        public DateTime DateEnd { get; set; }

        public int Hall_HallId { get; set; }

        public int SubscriptionClient_ClientId { get; set; }

        public int? Trainer_TrainerId { get; set; }

        public virtual Client Client { get; set; }

        public virtual Hall Hall { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceOrder> ServiceOrders { get; set; }

        public virtual Trainer Trainer { get; set; }
    }
}
