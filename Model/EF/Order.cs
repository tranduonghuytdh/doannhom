namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public long ID { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(10)]
        public string CustomerID { get; set; }

        [StringLength(250)]
        public string ShipName { get; set; }

        [StringLength(15)]
        public string ShipMoblie { get; set; }

        [StringLength(250)]
        public string ShipAddress { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public long? StatusOder { get; set; }

        public bool Status { get; set; }
    }
}
