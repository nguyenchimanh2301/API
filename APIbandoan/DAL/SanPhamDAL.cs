using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;

namespace DAL
{
    public class SanPhamDAL
    {
        helper dh = new helper();
        string msg = string.Empty;
        public List<SanPhams> GetSanPhams()
        {
            SanPhams lp = new SanPhams();
            DataSet ds = dh.productget(lp,out msg);
            List<SanPhams> list = new List<SanPhams>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(new SanPhams
                {
                    Loaisp_id = dr["Loaisp_id"].ToString(),
                    sanpham_id = dr["sanpham_id"].ToString(),
                    sanpham_name = dr["sanpham_name"].ToString(),

                    gia = Convert.ToInt32(dr["gia"]),
                    Nhacungcap_id = dr["Nhacungcap_id"].ToString(),
                    Soluong = Convert.ToInt32(dr["Soluong"].ToString()),
                    picture = dr["picture"].ToString()

                });
            }
            return list;
        }
        public string AddLsp(SanPhams l)
        {
            string msg = string.Empty;
            try
            {
                msg = dh.Productadd(l);
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            return msg;
        }
        public List<SanPhams> GetSanPhamsid(string id)
        {
            SanPhams lp = new SanPhams();
            lp.sanpham_id = id;
            DataSet ds = dh.Productgetid(lp, out msg);
            List<SanPhams> list = new List<SanPhams>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(new SanPhams
                {
                    sanpham_id = dr["sanpham_id"].ToString(),
                    Loaisp_id = dr["Loaisp_id"].ToString(),
                    sanpham_name = dr["sanpham_name"].ToString(),
                    gia = Convert.ToInt32(dr["gia"]),
                    Nhacungcap_id = dr["Nhacungcap_id"].ToString(),
                    Soluong = Convert.ToInt32(dr["Soluong"]),
                    picture = dr["picture"].ToString()

                });
            }
            return list;
        }

    }
}
