using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloDotNetWeb.Models
{
    public class IndexModel
    {
        public string OwnerName { get; set; }
        public ProductListModel ProductList { get; set; }
    }
}