using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloDotNetWeb.Cores;
using HelloDotNetWeb.Cores.Entities;
using HelloDotNetWeb.Models;

namespace HelloDotNetWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {

            var db = new HelloDotNetDB();
            var dssp = db.ProductTable.ToList();
            var danhmuc = db.CategoryTable.FirstOrDefault(o => o.Id == 3);







            var m = new IndexModel();
            m.OwnerName = "Le Huynh Thanh";
            m.DanhSachSanPham = dssp;
            m.TenDanhMuc = danhmuc == null ? string.Empty : danhmuc.CategoryName;

            return View(m);
        }
        
        public ActionResult Demo(ProductModel model)
        {
            return Content(model.ProductName + " - " + model.Des);
        }
    }
}