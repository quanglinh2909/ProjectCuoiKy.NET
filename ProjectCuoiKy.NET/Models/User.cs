using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class User
    {
        public User()
        {
            Giohangs = new HashSet<Giohang>();
            Hoadons = new HashSet<Hoadon>();
            Nhanxets = new HashSet<Nhanxet>();
            Thongbaos = new HashSet<Thongbao>();
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public string Usermail { get; set; }
        public int Role { get; set; }
        public string Vericaioncode { get; set; }
        public long? Dateregister { get; set; }
        public int Isvirification { get; set; }

        public virtual Khachhang Khachhang { get; set; }
        public virtual ICollection<Giohang> Giohangs { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
        public virtual ICollection<Nhanxet> Nhanxets { get; set; }
        public virtual ICollection<Thongbao> Thongbaos { get; set; }
    }
}
