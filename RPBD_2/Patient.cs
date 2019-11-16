namespace RPBD_2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Priems = new HashSet<Priem>();
        }

        [Required]
        [StringLength(255)]
        public string passport { get; set; }

        [Required]
        [StringLength(255)]
        public string FIO { get; set; }

        [Required]
        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string telefon { get; set; }

        public int id_Stat { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Patient { get; set; }

        public virtual StatPatient StatPatient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Priem> Priems { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
