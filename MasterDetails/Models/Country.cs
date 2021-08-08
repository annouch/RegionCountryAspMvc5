namespace MasterDetails.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(2)]
        public string ShortName { get; set; }

        public int? RegionId { get; set; }

        public virtual Region Region { get; set; }
    }
}
