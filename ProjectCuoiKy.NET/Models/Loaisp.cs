using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class Loaisp
    {
        public Loaisp()
        {
            Products = new HashSet<Product>();
        }

        public string Idloai { get; set; }
        public string NameLoai { get; set; }
        public string Motatheloai { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
