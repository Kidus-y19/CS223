using Gui_WinFormApp.NewFolder;

namespace Gui_WinFormApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            do
            {
                if (!string.IsNullOrEmpty(txt_objectName.Text) && !string.IsNullOrEmpty(txt_count.Text)
                    && !string.IsNullOrEmpty(txt_number.Text) && !string.IsNullOrEmpty(txt_price.Text)
                    && !string.IsNullOrEmpty(txt_SKU.Text))
                {
                    p.Count = Convert.ToInt32(txt_count.Text);
                    p.ItemName = txt_objectName.Text;
                    p.ItemNumber = txt_number.Text;
                    p.Date = dtp_datepicker1.Value;
                    p.Price = Convert.ToInt32(txt_price.Text);
                    p.Sku = txt_SKU.Text;
                    p.save();
                }
                else
                {
                    MessageBox.Show("Can't insert null values. Try again please");
                }
            }while(txt_count.Text == null || txt_objectName.Text == null || txt_number.Text == null ||
                    dtp_datepicker1.Text == null || txt_price.Text == null || txt_SKU.Text == null);
        }

        private void btn_add_MouseHover(object sender, EventArgs e)
        {
           // MessageBox.Show("Move the cursor Away!!");
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_number.Text = "";
            txt_count.Text = "";
            txt_objectName.Text = "";
            txt_price.Text = "";
            txt_SKU.Text = "";

        }
    }
}