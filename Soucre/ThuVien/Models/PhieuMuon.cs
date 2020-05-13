namespace ThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuMuon")]
    public partial class PhieuMuon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuMuon()
        {
            Saches = new HashSet<Sach>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MaMuon { get; set; }

        public int? NguoiMuon { get; set; }

        public DateTime? NgayMuon { get; set; }

        public DateTime? NgayTra { get; set; }

        [StringLength(150)]
        public string HinhThuc { get; set; }

        public DateTime? TimeUpdate { get; set; }

        public DateTime? TimeCreate { get; set; }

        public int? SoNgayMuon { get; set; }

        public virtual SinhVien SinhVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
