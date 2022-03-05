namespace MotorTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("motortest.client")]
    public partial class client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClient { get; set; }

        [Required]
        [StringLength(50)]
        public string nom { get; set; }

        [Required]
        [StringLength(50)]
        public string prenom { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string mail { get; set; }

        [Required]
        [StringLength(10)]
        public string tel { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string adresse { get; set; }

        [Required]
        [StringLength(5)]
        public string codePostal { get; set; }

        [Required]
        [StringLength(50)]
        public string ville { get; set; }
    }
}
