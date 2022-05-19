using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Model1;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace APIbandoan.Controllers
{

    [Route("api/[controller]")]

    public class LoaiSpController : Controller
    {

        public BLLLoaiSp _bll = new BLLLoaiSp() ;


        [Route("getall")]
        [HttpGet]
        public List<LoaiSp> Getall()
        {
            return _bll.getall();
        }
        [HttpGet("{id}")]
        public List<LoaiSp> Getid(string id)
        {
            return _bll.getbyid(id);
        }
        [Route("add")]

        [HttpPost]
        public string AddLSP(LoaiSp l)
        {
            return _bll.add(l);
        }
        [Route("update")]

        [HttpPost]
        public string UpdateLSP(LoaiSp l)
        {
            return _bll.update(l);
        }
        [Route("delete")]
        [HttpDelete]
        public string Delete(string id)
        {
            return _bll.xoa(id);
        }

    }
}
