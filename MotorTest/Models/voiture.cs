namespace MotorTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("motortest.voiture")]
    public partial class voiture
    {
        [Required]
        [StringLength(50)]
        public string idCarburant { get; set; }

        public int nbPorte { get; set; }

        public int puissanceFiscale { get; set; }

        public int criterePollution { get; set; }

        [Required]
        [StringLength(50)]
        public string typeTransmission { get; set; }

        public int modeleId { get; set; }

        public int prix { get; set; }

        [Key]
        public int idVoiture { get; set; }

        [Required]
        [StringLength(50)]
        public string finition { get; set; }
    }
}
