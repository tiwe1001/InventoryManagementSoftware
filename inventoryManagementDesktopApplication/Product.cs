using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryManagementDesktopApplication
{
    class Product
    {
        public int id { get; set; }
        public string brand { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public DateTime date { get; set; }

        public Product (int id, string brand, string name, string description, string category, int quantity, double price, DateTime date)
        {
            this.id = id;
            this.brand = brand;
            this.name = name;
            this.description = description;
            this.category = category;
            this.quantity = quantity;
            this.price = price;
            this.date = date;
        }

    }
}
