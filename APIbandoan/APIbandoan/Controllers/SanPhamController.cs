using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model1;
using BLL;
namespace APIbandoan.Controllers
{
    [Route("api/[controller]")]
    public class SanPhamController : Controller
    {
        // GET: SanPhamController
        BLLSanPham bll = new BLLSanPham();
        [Route("getall")]
        [HttpGet]
        public List<SanPhams> getall()
        {
            return bll.Getall();
        }
        [HttpGet("{id}")]
        public List<SanPhams> Getid(string id)
        {
            return bll.getid(id);
        }
        [HttpPost]
        public string add(SanPhams id)
        {
            return bll.add(id);
        }
        /*   public ActionResult Index()
           {
               return View();
           }*/
        // GET: SanPhamController/Details/5
        /* public ActionResult Details(int id)
         {
             return View();
         }

         // GET: SanPhamController/Create
         public ActionResult Create()
         {
             return View();
         }

         // POST: SanPhamController/Create
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Create(IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }

         // GET: SanPhamController/Edit/5
         public ActionResult Edit(int id)
         {
             return View();
         }

         // POST: SanPhamController/Edit/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Edit(int id, IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }

         // GET: SanPhamController/Delete/5
         public ActionResult Delete(int id)
         {
             return View();
         }

         // POST: SanPhamController/Delete/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Delete(int id, IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }*/
    }
}
