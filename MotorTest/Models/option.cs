namespace MotorTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("motortest.option")]
    public partial class option
    {
        [Key]
        public int idOption { get; set; }

        public int prix { get; set; }

        [Required]
        [StringLength(50)]
        public string nomOption { get; set; }
    }
}
