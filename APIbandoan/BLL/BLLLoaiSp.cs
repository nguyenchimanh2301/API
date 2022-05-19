using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;
using DAL;
namespace BLL
{
    public class BLLLoaiSp
    {
        LoaiSpDAL lsp = new LoaiSpDAL();
        public List<LoaiSp> getall()
        {
            return lsp.Getall();
        }
        public List<LoaiSp> getbyid(string id)
        {
            return lsp.Getid(id);
        }
        public string add(LoaiSp l)
        {
            return lsp.AddLsp(l);
        }
        public string update(LoaiSp l)
        {
            return lsp.update(l);
        }
        public string xoa(string id)
        {
            return lsp.XoaLsp(id);
        }
    }
}
