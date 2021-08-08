namespace MasterDetails.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Region")]
    public partial class Region
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string NOM { get; set; }
    }
}
