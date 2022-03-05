namespace MotorTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("motortest.carburant")]
    public partial class carburant
    {
        [Key]
        public int idCarburant { get; set; }

        [Required]
        [StringLength(50)]
        public string nomCarvurant { get; set; }
    }
}
