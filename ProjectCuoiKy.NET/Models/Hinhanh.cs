using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class Hinhanh
    {
        public string Idsp { get; set; }
        public string Url { get; set; }

        public virtual Product IdspNavigation { get; set; }
    }
}
