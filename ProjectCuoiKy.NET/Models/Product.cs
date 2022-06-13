using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class Product
    {
        public Product()
        {
            Giohangs = new HashSet<Giohang>();
        }

        public string Masp { get; set; }
        public string Tensp { get; set; }
        public string IdboSuuTap { get; set; }
        public string Mota { get; set; }
        public float Dongia { get; set; }
        public float Sale { get; set; }
        public string Mau { get; set; }
        public DateTime Ngaynhap { get; set; }
        public DateTime? Ngaybatdausale { get; set; }
        public DateTime? Ngayketthucsale { get; set; }
        public string Loaisp { get; set; }
        public int Trangthai { get; set; }
        public int S { get; set; }
        public int L { get; set; }
        public int M { get; set; }
        public int Xl { get; set; }

        public virtual Bosutap IdboSuuTapNavigation { get; set; }
        public virtual Loaisp LoaispNavigation { get; set; }
        public virtual ICollection<Giohang> Giohangs { get; set; }
    }
}
