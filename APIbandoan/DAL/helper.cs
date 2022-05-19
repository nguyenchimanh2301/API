using Model1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class helper
    {

        protected SqlConnection cns = new SqlConnection("Data Source=LAPTOP-LLHPT87U\\SQLEXPRESS;Initial Catalog=DOAN3;Integrated Security=True");
        SqlConnection con;
       
      
       
        public string Categories(LoaiSp lp)
        {
            string msg = string.Empty;
            try
            {
                SqlCommand com = new SqlCommand("getall_lsp", cns);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Loaisp_id", lp.Loaisp_id);
                com.Parameters.AddWithValue("@Loaisp_name", lp.Loaisp_name);
                com.Parameters.AddWithValue("@mota", lp.mota);
                com.Parameters.AddWithValue("@type", lp.type);
                cns.Open();
                com.ExecuteNonQuery();
                cns.Close();
                msg = "comple";
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            finally
            {
                if (cns.State == ConnectionState.Open)
                {
                    cns.Close();
                }
            }
            return msg;
        }
        public DataSet CategoryGet(LoaiSp lp, out string msg)
        {
            msg = string.Empty;

            DataSet ds = new DataSet();
            try
            {
                SqlCommand com = new SqlCommand("getall_lsp", cns);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Loaisp_id", lp.Loaisp_id);
                com.Parameters.AddWithValue("@Loaisp_name", lp.Loaisp_name);
                com.Parameters.AddWithValue("@mota", lp.mota);
                com.Parameters.AddWithValue("@type", lp.type);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
                msg = "comple";
                return ds;
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }

            return ds;
        }
       
        public DataSet productget(SanPhams lp, out string msg)
        {
            msg = string.Empty;

            DataSet ds = new DataSet();
            try
            {
                SqlCommand com = new SqlCommand("Get_sanpham", cns);
             
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
                msg = "comple";
                return ds;
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }

            return ds;
        }
        public string Productadd(SanPhams lp)
        {
            string msg = string.Empty;
            try
            {
                SqlCommand com = new SqlCommand("add_product", cns);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@sanpham_id", lp.sanpham_id);
                com.Parameters.AddWithValue("@Loaisp_id", lp.Loaisp_id);
                com.Parameters.AddWithValue("@sanpham_name", lp.sanpham_name);
                com.Parameters.AddWithValue("@gia", lp.gia);
                com.Parameters.AddWithValue("@Nhacungcap_id", lp.Nhacungcap_id);
                com.Parameters.AddWithValue("@Soluong", lp.Soluong);
                com.Parameters.AddWithValue("@picture", lp.picture);
                cns.Open();
                com.ExecuteNonQuery();
                cns.Close();
                msg = "comple";
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            finally
            {
                if (cns.State == ConnectionState.Open)
                {
                    cns.Close();
                }
            }
            return msg;
        }
        public DataSet Productgetid(SanPhams lp, out string msg)
        {
            msg = string.Empty;

            DataSet ds = new DataSet();
            try
            {
                SqlCommand com = new SqlCommand("get_product_id", cns);

                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@sanpham_id", lp.sanpham_id);
                com.Parameters.AddWithValue("@Loaisp_id", lp.Loaisp_id);
                com.Parameters.AddWithValue("@sanpham_name", lp.sanpham_name);
                com.Parameters.AddWithValue("@gia", lp.gia);
                com.Parameters.AddWithValue("@Nhacungcap_id", lp.Nhacungcap_id);
                com.Parameters.AddWithValue("@Soluong", lp.Soluong);
                com.Parameters.AddWithValue("@picture", lp.picture);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
                msg = "comple";
                return ds;
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }

            return ds;
        }
    }
}
