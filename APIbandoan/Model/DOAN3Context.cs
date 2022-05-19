using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Model
{
    public partial class DOAN3Context : DbContext
    {
        public DOAN3Context()
        {
        }

        public DOAN3Context(DbContextOptions<DOAN3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Dathang> Dathangs { get; set; }
        public virtual DbSet<Donhang> Donhangs { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSp> LoaiSps { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Userss> Usersses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-LLHPT87U\\SQLEXPRESS;Database=DOAN3;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Dathang>(entity =>
            {
                entity.HasKey(e => e.HoadonId)
                    .HasName("PK__Dathang__D385C07FDC540C76");

                entity.ToTable("Dathang");

                entity.Property(e => e.HoadonId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Hoadon_id");

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.KhachhangName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Khachhang_name");

                entity.Property(e => e.Ngaydathang)
                    .HasColumnType("date")
                    .HasColumnName("ngaydathang");

                entity.Property(e => e.NvId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NV_id");

                entity.Property(e => e.SanphamId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sanpham_id");

                entity.HasOne(d => d.Nv)
                    .WithMany(p => p.Dathangs)
                    .HasForeignKey(d => d.NvId)
                    .HasConstraintName("FK__Dathang__NV_id__46E78A0C");

                entity.HasOne(d => d.Sanpham)
                    .WithMany(p => p.Dathangs)
                    .HasForeignKey(d => d.SanphamId)
                    .HasConstraintName("FK__Dathang__sanpham__45F365D3");
            });

            modelBuilder.Entity<Donhang>(entity =>
            {
                entity.HasKey(e => e.HoadonId)
                    .HasName("PK__Donhang__D385C07FBF2D513F");

                entity.ToTable("Donhang");

                entity.Property(e => e.HoadonId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Hoadon_id");

                entity.Property(e => e.Giaban).HasColumnName("giaban");

                entity.Property(e => e.KhachhangId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Khachhang_id");

                entity.Property(e => e.KhachhangName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Khachhang_name");

                entity.Property(e => e.SanphamId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sanpham_id");

                entity.Property(e => e.SanphamName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("sanpham_name");

                entity.Property(e => e.Soluong).HasColumnName("soluong");

                entity.Property(e => e.Tongtien).HasColumnName("tongtien");

                entity.HasOne(d => d.Khachhang)
                    .WithMany(p => p.Donhangs)
                    .HasForeignKey(d => d.KhachhangId)
                    .HasConstraintName("FK__Donhang__Khachha__412EB0B6");

                entity.HasOne(d => d.Sanpham)
                    .WithMany(p => p.Donhangs)
                    .HasForeignKey(d => d.SanphamId)
                    .HasConstraintName("FK__Donhang__sanpham__403A8C7D");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Mahoadon)
                    .HasName("PK__Hoadon__3B2ABEFD3D795F77");

                entity.ToTable("Hoadon");

                entity.Property(e => e.Mahoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.KhachhangName)
                    .HasMaxLength(40)
                    .HasColumnName("Khachhang_name");

                entity.Property(e => e.Listsanpham)
                    .HasMaxLength(400)
                    .HasColumnName("listsanpham");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .IsFixedLength(true);

                entity.Property(e => e.Tongtien).HasColumnName("tongtien");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.ToTable("KhachHang");

                entity.Property(e => e.KhachhangId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Khachhang_id");

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Gioitinh)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.KhachhangName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Khachhang_name");

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.Sodt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.ToTable("LoaiSp");

                entity.Property(e => e.LoaispId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Loaisp_id");

                entity.Property(e => e.LoaispName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Loaisp_name");

                entity.Property(e => e.Mota)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("mota");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasKey(e => e.Mabaiviet)
                    .HasName("PK__News__2F6032E003330887");

                entity.Property(e => e.Mabaiviet)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Anh).IsUnicode(false);

                entity.Property(e => e.Noidung).HasMaxLength(1000);

                entity.Property(e => e.Tieude).HasMaxLength(100);
            });

            modelBuilder.Entity<Nhacungcap>(entity =>
            {
                entity.ToTable("Nhacungcap");

                entity.Property(e => e.NhacungcapId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Nhacungcap_id");

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NhacungcapName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Nhacungcap_name");

                entity.Property(e => e.Sodt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.NvId)
                    .HasName("PK__NHANVIEN__E50ADCA22BB553BD");

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.NvId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NV_id");

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("diachi");

                entity.Property(e => e.Gioitinh)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("gioitinh");

                entity.Property(e => e.NvName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("NV_name");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("sdt");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.SanphamId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sanpham_id");

                entity.Property(e => e.Gia).HasColumnName("gia");

                entity.Property(e => e.LoaispId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Loaisp_id");

                entity.Property(e => e.NhacungcapId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Nhacungcap_id");

                entity.Property(e => e.Picture)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("picture");

                entity.Property(e => e.SanphamName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("sanpham_name");

                entity.HasOne(d => d.Loaisp)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.LoaispId)
                    .HasConstraintName("FK__SanPhams__Loaisp__3A81B327");

                entity.HasOne(d => d.Nhacungcap)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.NhacungcapId)
                    .HasConstraintName("FK_SanPhams_Nhacungcap");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("TEST");

                entity.Property(e => e.Id)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Anh)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("anh");
            });

            modelBuilder.Entity<Userss>(entity =>
            {
                entity.HasKey(e => e.UsersId)
                    .HasName("PK__Userss__EB6B2D4578D07D36");

                entity.ToTable("Userss");

                entity.Property(e => e.UsersId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Users_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Passwords)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
