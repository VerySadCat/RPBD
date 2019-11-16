namespace RPBD_2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Priem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Priem { get; set; }

        public int? id_Disease { get; set; }

        public int id_Schedule { get; set; }

        public int id_Patient { get; set; }

        [StringLength(255)]
        public string prtim { get; set; }

        public virtual Disease Disease { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
