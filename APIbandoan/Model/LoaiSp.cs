using System;
using System.Collections.Generic;

#nullable disable

namespace Model
{
    public partial class LoaiSp
    {
        public LoaiSp()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string LoaispId { get; set; }
        public string LoaispName { get; set; }
        public string Mota { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
