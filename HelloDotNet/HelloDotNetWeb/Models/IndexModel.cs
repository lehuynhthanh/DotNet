using System.Collections.Generic;
using HelloDotNetWeb.Cores.Entities;

namespace HelloDotNetWeb.Models
{
    public class IndexModel
    {
        public string OwnerName { get; set; }
        public List<Product> DanhSachSanPham { get; set; }
        public string TenDanhMuc { get; set; }
    }
}