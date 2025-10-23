namespace DoAn.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string OrderID { get; set; }

        [Column(TypeName = "date")]
        public DateTime InvoiceDate { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceStatus { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SKU { get; set; }

        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
