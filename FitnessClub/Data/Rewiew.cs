namespace FitnessClub.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rewiews")]
    public partial class Rewiew
    {
        public int RewiewId { get; set; }

        [Required]
        [StringLength(255)]
        public string RewiewText { get; set; }

        public byte RewiewScore { get; set; }

        public bool RewiewIsModerate { get; set; }

        public int Client_ClientId { get; set; }

        public int RewiewService_ServiceId { get; set; }

        public virtual Client Client { get; set; }

        public virtual Service Service { get; set; }
    }
}
