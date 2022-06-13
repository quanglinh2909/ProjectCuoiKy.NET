using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class Thongbao
    {
        public string IdthongBao { get; set; }
        public string Title { get; set; }
        public string MoTa { get; set; }
        public string Link { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public int TrangThai { get; set; }
        public int LoaiThongBao { get; set; }
        public int PhanLoai { get; set; }
        public string IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; }
    }
}
