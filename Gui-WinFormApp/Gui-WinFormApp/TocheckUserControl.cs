using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_WinFormApp
{
    public partial class TocheckUserControl : Form
    {
      

        public TocheckUserControl()
        {
            InitializeComponent();
        }

        private void productCard1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TocheckUserControl_Load(object sender, EventArgs e)
        {

            List<String> products = new List<string> { "product1", "product2", "product3", "product4", "product5" };
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in products)
            {
                ProductCard p = new ProductCard();
                p.Price = item;
                p.Title = item;
                 p.Desc = item;
                flowLayoutPanel1.Controls.Add(p);

            }
        }
    }
}
