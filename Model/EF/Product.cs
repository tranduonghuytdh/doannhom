namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Decription { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public decimal? Price { get; set; }

        public decimal? PromationPrice { get; set; }

        public int? Quanlity { get; set; }

        public long? CategoryID { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        [StringLength(250)]
        public string CreateDate { get; set; }

        [StringLength(250)]
        public string ModifiedDate { get; set; }

        [StringLength(250)]
        public string ModifedBy { get; set; }

        [StringLength(250)]
        public string MetakeyWords { get; set; }

        [StringLength(250)]
        public string MetaDecriptions { get; set; }

        public bool Status { get; set; }
    }
}
