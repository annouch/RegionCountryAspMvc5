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
        public int ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(2)]
        public string SHORTNAME { get; set; }

        [NotMapped]
        public string FULLNAME
        {
            get
            {
                return this.NAME + " (" + this.SHORTNAME + ")";
            }
        }

        public int REGIONID { get; set; }

        public Region REGION { get; set; }
    }
}