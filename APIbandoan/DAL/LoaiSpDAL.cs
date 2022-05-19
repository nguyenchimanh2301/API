using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;

namespace DAL
{
    public class LoaiSpDAL
    {
        
        helper dh  =  new helper();
        string msg = string.Empty;
        public List<LoaiSp> Getall()
        {

            LoaiSp lp = new LoaiSp();
            lp.type = "get";
            DataSet ds = dh.CategoryGet(lp, out msg);
            List<LoaiSp> list = new List<LoaiSp>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(new LoaiSp
                {
                    Loaisp_id = dr["Loaisp_id"].ToString(),
                    Loaisp_name = dr["Loaisp_name"].ToString(),
                    mota = dr["mota"].ToString()

                });
            }
            return list;
        }
        public List<LoaiSp> Getid(string id)
        {

            LoaiSp lp = new LoaiSp();
            lp.Loaisp_id = id;
            lp.type = "getbyid";
            DataSet ds = dh.CategoryGet(lp, out msg);
            List<LoaiSp> list = new List<LoaiSp>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(new LoaiSp
                {
                    Loaisp_id = dr["Loaisp_id"].ToString(),
                    Loaisp_name = dr["Loaisp_name"].ToString(),
                    mota = dr["mota"].ToString()

                });
            }
            return list;
        }
        public string AddLsp(LoaiSp l)
        {
            string msg = string.Empty;
            try
            {
                msg= dh.Categories(l);
            }
            catch (Exception ex)
            {

               msg= ex.Message;
            }
            return msg;
        }
        public string XoaLsp(string id)
        {
            string msg = string.Empty;
            try
            {
                LoaiSp lp = new LoaiSp();
                lp.Loaisp_id = id;
                lp.type = "delete";
                msg = dh.Categories(lp);
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            return msg;
        }
        public string update(LoaiSp l)
        {
            string msg = string.Empty;
            try
            {
                msg = dh.Categories(l);
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            return msg;
        }

    }
}
