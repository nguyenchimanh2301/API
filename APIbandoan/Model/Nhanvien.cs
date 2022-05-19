using System;
using System.Collections.Generic;

#nullable disable

namespace Model
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Dathangs = new HashSet<Dathang>();
        }

        public string NvId { get; set; }
        public string NvName { get; set; }
        public string Gioitinh { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }

        public virtual ICollection<Dathang> Dathangs { get; set; }
    }
}
