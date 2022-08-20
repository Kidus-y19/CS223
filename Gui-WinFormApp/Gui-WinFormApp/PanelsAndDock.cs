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
    public partial class PanelsAndDock : Form
    {
        public PanelsAndDock()
        {
            InitializeComponent();
        }

        private void btnPan1_Click(object sender, EventArgs e)
        {
            panCenter.BackColor = Color.Red;
            panIndicator.Height = btnPan1.Height;
            panIndicator.Top = btnPan1.Top;
            panIndicator.BackColor = Color.Red;


        }

        private void btnPan2_Click(object sender, EventArgs e)
        {
            panCenter.BackColor = Color.Blue;
            panIndicator.Height = btnPan2.Height;
            panIndicator.Top = btnPan2.Top;
            panIndicator.BackColor = Color.Blue;
        }

        private void btnPan3_Click(object sender, EventArgs e)
        {
            panCenter.BackColor = Color.Orange;
            panIndicator.Height = btnPan3.Height;
            panIndicator.Top = btnPan3.Top;
            panIndicator.BackColor = Color.Orange;
        }

        private void btnPan4_Click(object sender, EventArgs e)
        {
            panCenter.BackColor = Color.Violet;
            panIndicator.Height = btnPan3.Height;
            panIndicator.Top = btnPan4.Top;
            panIndicator.BackColor = Color.Violet;
        }

        private void panCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelsAndDock_Load(object sender, EventArgs e)
        {

            List<String> products = new List<string> { "product1", "product2", "product3", "product4", "product5" };
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in products)
            {
                ProductCard p = new ProductCard();
                p.Price = item;
                //p.Title = item;
               // p.Desc = item;
                flowLayoutPanel1.Controls.Add(p);
            
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
