using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class shopthoitrangContext : DbContext
    {
        public shopthoitrangContext()
        {
        }

        public shopthoitrangContext(DbContextOptions<shopthoitrangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bosutap> Bosutaps { get; set; }
        public virtual DbSet<Cthoadon> Cthoadons { get; set; }
        public virtual DbSet<Giohang> Giohangs { get; set; }
        public virtual DbSet<Hinhanh> Hinhanhs { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Loaisp> Loaisps { get; set; }
        public virtual DbSet<Nhanxet> Nhanxets { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Quangcao> Quangcaos { get; set; }
        public virtual DbSet<Thongbao> Thongbaos { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=localhost;Database=shopthoitrang;User=root;Password=;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bosutap>(entity =>
            {
                entity.HasKey(e => e.IdBst)
                    .HasName("PRIMARY");

                entity.ToTable("bosutap");

                entity.Property(e => e.IdBst)
                    .HasMaxLength(255)
                    .HasColumnName("IdBST");

                entity.Property(e => e.Check)
                    .HasColumnType("int(11)")
                    .HasColumnName("check")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Img)
                    .HasMaxLength(255)
                    .HasColumnName("img")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MotaBst)
                    .HasColumnName("motaBST")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.Property(e => e.Tieude)
                    .HasMaxLength(500)
                    .HasColumnName("tieude")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Cthoadon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cthoadon");

                entity.HasIndex(e => e.MaHd, "ma_hd_pk");

                entity.HasIndex(e => e.MaSp, "ma_sp_pk_ct");

                entity.Property(e => e.MaHd)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaSp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Size)
                    .HasMaxLength(255)
                    .HasColumnName("SIZE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SoLuong).HasColumnType("int(11)");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ma_hd_pk");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ma_sp_pk_ct");
            });

            modelBuilder.Entity<Giohang>(entity =>
            {
                entity.ToTable("giohang");

                entity.HasIndex(e => e.Idsp, "prokey_idSP");

                entity.HasIndex(e => e.Iduser, "prokey_idUser");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Idsp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("IDSP");

                entity.Property(e => e.Iduser)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("IDUSER");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("SIZE");

                entity.Property(e => e.Soluong)
                    .HasColumnType("int(11)")
                    .HasColumnName("SOLUONG")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.IdspNavigation)
                    .WithMany(p => p.Giohangs)
                    .HasForeignKey(d => d.Idsp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prokey_idSP");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Giohangs)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prokey_idUser");
            });

            modelBuilder.Entity<Hinhanh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hinhanh");

                entity.HasIndex(e => e.Idsp, "IDSP");

                entity.Property(e => e.Idsp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("IDSP");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("URL");

                entity.HasOne(d => d.IdspNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idsp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("hinhanh_ibfk_1");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Mahoadon)
                    .HasName("PRIMARY");

                entity.ToTable("hoadon");

                entity.HasIndex(e => e.Iduser, "iduset_pk_hd");

                entity.Property(e => e.Mahoadon)
                    .HasMaxLength(255)
                    .HasColumnName("MAHOADON");

                entity.Property(e => e.Iduser)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("IDUSER");

                entity.Property(e => e.SoNgayDuKien)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TongTien).HasColumnName("tongTien");

                entity.Property(e => e.TrangThai).HasColumnType("int(11)");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("iduset_pk_hd");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Iduser)
                    .HasName("PRIMARY");

                entity.ToTable("khachhang");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(255)
                    .HasColumnName("IDUSER");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DienThoai)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PhuongXa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.QuanHuyen)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TinhTp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("TinhTP");

                entity.HasOne(d => d.IduserNavigation)
                    .WithOne(p => p.Khachhang)
                    .HasForeignKey<Khachhang>(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("iduser_pk");
            });

            modelBuilder.Entity<Loaisp>(entity =>
            {
                entity.HasKey(e => e.Idloai)
                    .HasName("PRIMARY");

                entity.ToTable("loaisp");

                entity.Property(e => e.Idloai)
                    .HasMaxLength(255)
                    .HasColumnName("IDLOAI");

                entity.Property(e => e.Motatheloai)
                    .HasColumnName("MOTATHELOAI")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NameLoai)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Nhanxet>(entity =>
            {
                entity.HasKey(e => e.IdnhanXet)
                    .HasName("PRIMARY");

                entity.ToTable("nhanxet");

                entity.HasIndex(e => e.Iduser, "fk_nhan_xet");

                entity.Property(e => e.IdnhanXet)
                    .HasMaxLength(255)
                    .HasColumnName("IDNhanXet");

                entity.Property(e => e.Iduser)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("IDUSER");

                entity.Property(e => e.Imguser)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("IMGUSER");

                entity.Property(e => e.Nhanxet1)
                    .IsRequired()
                    .HasColumnName("NHANXET");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Nhanxets)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nhan_xet");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Masp)
                    .HasName("PRIMARY");

                entity.ToTable("products");

                entity.HasIndex(e => e.IdboSuuTap, "khoangoai1pro");

                entity.HasIndex(e => e.Loaisp, "khoangoai2pro");

                entity.Property(e => e.Masp)
                    .HasMaxLength(255)
                    .HasColumnName("MASP");

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.IdboSuuTap)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("IDBoSuuTap");

                entity.Property(e => e.L).HasColumnType("int(11)");

                entity.Property(e => e.Loaisp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LOAISP");

                entity.Property(e => e.M).HasColumnType("int(11)");

                entity.Property(e => e.Mau)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MAU");

                entity.Property(e => e.Mota)
                    .HasColumnName("MOTA")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ngaybatdausale)
                    .HasColumnType("date")
                    .HasColumnName("NGAYBATDAUSALE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ngayketthucsale)
                    .HasColumnType("date")
                    .HasColumnName("NGAYKETTHUCSALE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ngaynhap)
                    .HasColumnType("date")
                    .HasColumnName("NGAYNHAP");

                entity.Property(e => e.S).HasColumnType("int(11)");

                entity.Property(e => e.Sale).HasColumnName("SALE");

                entity.Property(e => e.Tensp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("TENSP");

                entity.Property(e => e.Trangthai)
                    .HasColumnType("int(11)")
                    .HasColumnName("TRANGTHAI");

                entity.Property(e => e.Xl)
                    .HasColumnType("int(11)")
                    .HasColumnName("XL");

                entity.HasOne(d => d.IdboSuuTapNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdboSuuTap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("khoangoai1pro");

                entity.HasOne(d => d.LoaispNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Loaisp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("khoangoai2pro");
            });

            modelBuilder.Entity<Quangcao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("quangcao");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Mota)
                    .IsRequired()
                    .HasColumnName("mota");

                entity.Property(e => e.Tieude)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("tieude");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("url");

                entity.Property(e => e.UrlImg)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("urlImg");
            });

            modelBuilder.Entity<Thongbao>(entity =>
            {
                entity.HasKey(e => e.IdthongBao)
                    .HasName("PRIMARY");

                entity.ToTable("thongbao");

                entity.HasIndex(e => e.IdUser, "pk_thong_bao_idUser");

                entity.Property(e => e.IdthongBao)
                    .HasMaxLength(255)
                    .HasColumnName("IDThongBao");

                entity.Property(e => e.IdUser)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LoaiThongBao).HasColumnType("int(11)");

                entity.Property(e => e.MoTa).IsRequired();

                entity.Property(e => e.NgayCapNhat).HasColumnType("date");

                entity.Property(e => e.PhanLoai).HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TrangThai).HasColumnType("int(11)");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Thongbaos)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pk_thong_bao_idUser");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Usermail, "USERMAIL")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "USERNAME")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.Dateregister)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("DATEREGISTER")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Isvirification)
                    .HasColumnType("int(11)")
                    .HasColumnName("ISVIRIFICATION");

                entity.Property(e => e.Role)
                    .HasColumnType("int(11)")
                    .HasColumnName("ROLE");

                entity.Property(e => e.Usermail)
                    .HasMaxLength(50)
                    .HasColumnName("USERMAIL")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Userpassword)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("USERPASSWORD");

                entity.Property(e => e.Vericaioncode)
                    .HasMaxLength(255)
                    .HasColumnName("VERICAIONCODE")
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
