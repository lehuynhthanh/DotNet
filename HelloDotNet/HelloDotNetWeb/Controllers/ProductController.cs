using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public Category GetCategoryById(int id)
        {
            var db1 = new HelloDotNetDB();
            return db1.CategoryTable.FirstOrDefault(o => o.Id == id);
        }

        // GET: Product
        public ActionResult Index()
        {

            var db = new HelloDotNetDB();
            var danhmuc = db.CategoryTable.FirstOrDefault(o => o.Id == 3); //danhmuc được khởi tạo bằng db (DbContext) nên chịu sự quản lý của db
            danhmuc.CategoryName = "VLXD2"; //cập nhật giá trị mới cho danhmuc -> dữ liệu trong database sẽ đc cập nhật sau dòng db.SaveChanges()

            //db.Entry(danhmuc).State = EntityState.Modified;

            var danhmucao = new Category { CategoryName = "Noi that" }; //đây là object độc lập, ko chịu sự quản lý của db (DbContext)
            //db.CategoryTable.Add(danhmucao);
            db.Entry(danhmucao).State = EntityState.Added; //gắn danhmucao vào db (DbContext), đồng thời thông báo cho db rằng đối tượng này sẽ được thêm vào database (Added)
            db.SaveChanges();




            var dssp = db.ProductTable.ToList();
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