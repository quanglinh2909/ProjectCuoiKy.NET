using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class Bosutap
    {
        public Bosutap()
        {
            Products = new HashSet<Product>();
        }

        public string IdBst { get; set; }
        public string Name { get; set; }
        public string Tieude { get; set; }
        public string MotaBst { get; set; }
        public string Img { get; set; }
        public int? Check { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
