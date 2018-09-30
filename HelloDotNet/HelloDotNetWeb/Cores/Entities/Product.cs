using System.ComponentModel.DataAnnotations.Schema;

namespace HelloDotNetWeb.Cores.Entities
{
    [Table("Product_Data")]
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}