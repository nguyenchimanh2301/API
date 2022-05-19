using System;
using System.Collections.Generic;

#nullable disable

namespace Model
{
    public partial class SanPham
    {
        public SanPham()
        {
            Dathangs = new HashSet<Dathang>();
            Donhangs = new HashSet<Donhang>();
        }

        public string SanphamId { get; set; }
        public string LoaispId { get; set; }
        public string SanphamName { get; set; }
        public int? Gia { get; set; }
        public string NhacungcapId { get; set; }
        public int? Soluong { get; set; }
        public string Picture { get; set; }

        public virtual LoaiSp Loaisp { get; set; }
        public virtual Nhacungcap Nhacungcap { get; set; }
        public virtual ICollection<Dathang> Dathangs { get; set; }
        public virtual ICollection<Donhang> Donhangs { get; set; }
    }
}
