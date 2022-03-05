namespace MotorTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("motortest.peinture")]
    public partial class peinture
    {
        [Key]
        public int idPeinture { get; set; }

        [Required]
        [StringLength(50)]
        public string nomPeinture { get; set; }
    }
}
