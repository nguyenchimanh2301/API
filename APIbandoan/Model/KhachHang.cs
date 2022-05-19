using System;
using System.Collections.Generic;

#nullable disable

namespace Model
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            Donhangs = new HashSet<Donhang>();
        }

        public string KhachhangId { get; set; }
        public string KhachhangName { get; set; }
        public string Gioitinh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string Sodt { get; set; }

        public virtual ICollection<Donhang> Donhangs { get; set; }
    }
}
