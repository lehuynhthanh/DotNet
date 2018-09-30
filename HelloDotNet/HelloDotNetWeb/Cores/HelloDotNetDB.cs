using System.Data.Entity;
using HelloDotNetWeb.Cores.Entities;

namespace HelloDotNetWeb.Cores
{
    public class HelloDotNetDB : DbContext
    {
        public HelloDotNetDB() : base("name=HelloDotNetDBConnectionString")
        {
            
        }
        public DbSet<Product> ProductTable { get; set; }
        public DbSet<Category> CategoryTable { get; set; }
    }
}