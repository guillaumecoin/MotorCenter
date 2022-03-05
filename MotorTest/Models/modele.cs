namespace MotorTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("motortest.modele")]
    public partial class modele
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idModele { get; set; }

        public int vitesseMax { get; set; }

        [Required]
        [StringLength(50)]
        public string nom { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string description { get; set; }

        public int constructeurId { get; set; }

        public int idConstructeur { get; set; }

        public virtual constructeur constructeur { get; set; }
    }
}
