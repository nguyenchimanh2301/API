using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model1;

namespace BLL
{
    public class BLLSanPham
    {
        SanPhamDAL dal = new SanPhamDAL();
        public List<SanPhams> Getall()
        {
            return dal.GetSanPhams();
        }
        public List<SanPhams> getid(string id)
        {
            return dal.GetSanPhamsid(id);
        }
        public string add(SanPhams id)
        {
            return dal.AddLsp(id);
        }
    }
}
