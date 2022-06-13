using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class Hoadon
    {
        public string Mahoadon { get; set; }
        public string Iduser { get; set; }
        public int TrangThai { get; set; }
        public int? SoNgayDuKien { get; set; }
        public double TongTien { get; set; }

        public virtual User IduserNavigation { get; set; }
    }
}
