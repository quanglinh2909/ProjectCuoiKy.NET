using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class Giohang
    {
        public int Id { get; set; }
        public string Iduser { get; set; }
        public string Size { get; set; }
        public string Idsp { get; set; }
        public int? Soluong { get; set; }

        public virtual Product IdspNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}
