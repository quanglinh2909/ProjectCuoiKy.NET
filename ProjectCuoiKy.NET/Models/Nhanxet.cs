using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectCuoiKy.NET.Models
{
    public partial class Nhanxet
    {
        public string IdnhanXet { get; set; }
        public string Iduser { get; set; }
        public string Imguser { get; set; }
        public string Nhanxet1 { get; set; }

        public virtual User IduserNavigation { get; set; }
    }
}
