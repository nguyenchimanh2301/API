using System;
using System.Collections.Generic;

#nullable disable

namespace Model
{
    public partial class Donhang
    {
        public string HoadonId { get; set; }
        public string SanphamId { get; set; }
        public string KhachhangId { get; set; }
        public string KhachhangName { get; set; }
        public string SanphamName { get; set; }
        public int Soluong { get; set; }
        public int? Giaban { get; set; }
        public int? Tongtien { get; set; }

        public virtual KhachHang Khachhang { get; set; }
        public virtual SanPham Sanpham { get; set; }
    }
}
