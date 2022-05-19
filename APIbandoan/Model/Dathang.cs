using System;
using System.Collections.Generic;

#nullable disable

namespace Model
{
    public partial class Dathang
    {
        public string HoadonId { get; set; }
        public string SanphamId { get; set; }
        public string KhachhangName { get; set; }
        public string Diachi { get; set; }
        public string NvId { get; set; }
        public DateTime? Ngaydathang { get; set; }

        public virtual Nhanvien Nv { get; set; }
        public virtual SanPham Sanpham { get; set; }
    }
}
