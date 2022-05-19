using System;
using System.Collections.Generic;

#nullable disable

namespace Model
{
    public partial class Nhacungcap
    {
        public Nhacungcap()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string NhacungcapId { get; set; }
        public string NhacungcapName { get; set; }
        public string Diachi { get; set; }
        public string Sodt { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
