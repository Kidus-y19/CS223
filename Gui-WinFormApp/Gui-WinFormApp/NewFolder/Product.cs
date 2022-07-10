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
        public void save()
        {
            MessageBox.Show("Saved");
           //DBConnect()
           //Insert
        }
    }
}
