namespace DoAn.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TEN_TK { get; set; }

        [Required]
        [StringLength(255)]
        public string MK_TK { get; set; }

        [Required]
        [StringLength(255)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(11)]
        public string SDT { get; set; }

        [Required]
        [StringLength(50)]
        public string ROLE { get; set; }

        public int TRANG_THAI { get; set; }
    }
}
