using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class Cthoadon
    {
        public string MaHd { get; set; }
        public float Price { get; set; }
        public int SoLuong { get; set; }
        public string MaSp { get; set; }
        public string Size { get; set; }

        public virtual Hoadon MaHdNavigation { get; set; }
        public virtual Product MaSpNavigation { get; set; }
    }
}
