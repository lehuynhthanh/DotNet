using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloDotNetWeb.Cores.Entities;
using HelloDotNetWeb.Models;

namespace HelloDotNetWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var dssp = new List<Product>();

            var productListModel = new ProductListModel
            {
                DanhSachSanPham = dssp
            };


            var m = new IndexModel();
            m.OwnerName = "Le Huynh Thanh";
            m.ProductList = productListModel;






            return View(m);
        }
        
        public ActionResult Demo(ProductModel model)
        {
            return Content(model.ProductName + " - " + model.Des);
        }
    }
}