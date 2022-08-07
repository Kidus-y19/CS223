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
    public partial class ontainer : Form
    {
        public ontainer()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
           
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //var form = this.ActivateMdiChild;
            // Login login = new Login();
            // login.MdiParent = this;
            // login.Show();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Dock = DockStyle.Fill;    
            form1.Show();
        }
    }
}
