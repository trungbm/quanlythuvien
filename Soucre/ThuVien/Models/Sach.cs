namespace ThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSach { get; set; }

        [StringLength(150)]
        public string TenSach { get; set; }

        public int? LoaiSach { get; set; }

        [StringLength(10)]
        public string NamXB { get; set; }

        public int? NXB { get; set; }

        public int? TacGia { get; set; }

        public int? ViTri { get; set; }

        public int? SoLuong { get; set; }

        public int? Muon { get; set; }

        [StringLength(150)]
        public string NgonNgu { get; set; }

        public DateTime? TimeCreate { get; set; }

        public DateTime? TimeUpdate { get; set; }

        public virtual LoaiSach LoaiSach1 { get; set; }

        public virtual NXB NXB1 { get; set; }

        public virtual PhieuMuon PhieuMuon { get; set; }

        public virtual TacGia TacGia1 { get; set; }

        public virtual ViTri ViTri1 { get; set; }
    }
}
