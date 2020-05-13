namespace ThuVien.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<LoaiSach> LoaiSaches { get; set; }
        public virtual DbSet<NXB> NXBs { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TacGia> TacGias { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ViTri> ViTris { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSach>()
                .Property(e => e.MaLoaiSach)
                .IsFixedLength();

            modelBuilder.Entity<LoaiSach>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.LoaiSach1)
                .HasForeignKey(e => e.LoaiSach);

            modelBuilder.Entity<NXB>()
                .Property(e => e.MaNXB)
                .IsFixedLength();

            modelBuilder.Entity<NXB>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.NXB1)
                .HasForeignKey(e => e.NXB);

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.MaMuon)
                .IsFixedLength();

            modelBuilder.Entity<PhieuMuon>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.PhieuMuon)
                .HasForeignKey(e => e.Muon);

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<Sach>()
                .Property(e => e.NamXB)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSV)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.PhieuMuons)
                .WithOptional(e => e.SinhVien)
                .HasForeignKey(e => e.NguoiMuon);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.MaTacGia)
                .IsFixedLength();

            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.TacGia1)
                .HasForeignKey(e => e.TacGia);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<ViTri>()
                .Property(e => e.MaViTri)
                .IsFixedLength();

            modelBuilder.Entity<ViTri>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.ViTri1)
                .HasForeignKey(e => e.ViTri);
        }
    }
}
