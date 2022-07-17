using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_WinFormApp.NewFolder
{
    internal class Product
    {
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public string Sku { get; set; }
        public string phoneNo { get; set; }

        // The below properties will move to their own Customer class later
        public string Email { get; set; }
        public string Name { get; set; }
        // static: because the list is shared for all objects.
        static List<Product> products = new List<Product>();
        public void save()
        {
            products.Add(this);
           // MessageBox.Show("Saved");
           //DBConnect()
           //Insert
        }
        static public List<Product> getAllProducts()
        {
            return products;
        }
    }
}
