namespace DoAn.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SKU { get; set; }

        public int instock { get; set; }

        public virtual Product Product { get; set; }
    }
}
