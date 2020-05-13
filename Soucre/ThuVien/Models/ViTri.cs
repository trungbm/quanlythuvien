namespace ThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViTri")]
    public partial class ViTri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ViTri()
        {
            Saches = new HashSet<Sach>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MaViTri { get; set; }

        [StringLength(150)]
        public string Ngan { get; set; }

        [StringLength(150)]
        public string Ke { get; set; }

        public DateTime? TimeUpdate { get; set; }

        public DateTime? TimeCreate { get; set; }

        [StringLength(150)]
        public string Khu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
