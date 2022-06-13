using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class Khachhang
    {
        public string Iduser { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string TinhTp { get; set; }
        public string QuanHuyen { get; set; }
        public string PhuongXa { get; set; }

        public virtual User IduserNavigation { get; set; }
    }
}
