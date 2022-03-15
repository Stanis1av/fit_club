namespace FitnessClub.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceOrders")]
    public partial class ServiceOrder
    {
        public int ServiceOrderId { get; set; }

        public int ServiceGroup_ServiceGroupId { get; set; }

        public int Subscription_SubscriptionId { get; set; }

        public virtual ServiceGroup ServiceGroup { get; set; }

        public virtual Subscription Subscription { get; set; }
    }
}
