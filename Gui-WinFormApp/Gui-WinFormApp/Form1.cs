using Gui_WinFormApp.NewFolder;
using System.Text.RegularExpressions;
namespace Gui_WinFormApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelSelected.Height = btn_add.Height;
            panelSelected.Top = btn_add.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            panelSelected.Height = btn_cancel.Height;
            panelSelected.Top = btn_cancel.Top;
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            panelSelected.Height = btn_add.Height;
            panelSelected.Top = btn_add.Top;
            Product p = new Product();
            do
            {
                if (!string.IsNullOrEmpty(txt_objectName.Text) && !string.IsNullOrEmpty(txt_count.Text)
                    && !string.IsNullOrEmpty(txt_number.Text) && !string.IsNullOrEmpty(txt_price.Text)
                    && !string.IsNullOrEmpty(txt_SKU.Text) && !string.IsNullOrEmpty(txt_PhonNo.Text) 
                    && !string.IsNullOrEmpty(txt_Email.Text))
                {
                    //try{
                        p.Count = Convert.ToInt32(txt_count.Text);
                    //}catch (Exception);
                    p.ItemName = txt_objectName.Text;
                    p.ItemNumber = txt_number.Text;
                    p.Date = dtp_datepicker1.Value;
                    p.Price = Convert.ToInt32(txt_price.Text);
                    p.Sku = txt_SKU.Text;
                    p.Name = txt_Name.Text;
                    Regex r = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
                    if (r.IsMatch(txt_PhonNo.Text))
                    {
                        p.phoneNo = txt_PhonNo.Text;
                    }
                    Regex rEmail = new Regex(@"^[^@\s]+@[^@\s\.]+\.[^@\.\s]+$");
                    if (rEmail.IsMatch(txt_Email.Text))
                    {
                        p.Email = txt_Email.Text;
                    }
                    else 
                    {
                        txt_Email.Text = "ex: abc1@gmail.com";
                    }
                    p.save();
                    dgvShowProducts.DataSource = null;
                    dgvShowProducts.DataSource = Product.getAllProducts();
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(txt_objectName, "Name is required!");
                    errorProvider1.SetError(txt_Name, "Name is required!");
                    errorProvider1.SetError(txt_PhonNo , "Phone is required!");
                    errorProvider1.SetError(txt_price, "Price is required!");
                    //MessageBox.Show("Can't insert null values. Try again please");
                }
            }while(txt_count.Text == null || txt_objectName.Text == null || txt_number.Text == null ||
                    dtp_datepicker1.Text == null || txt_price.Text == null || txt_SKU.Text == null ||
                    txt_Name.Text == null || txt_Email.Text == null);
        }

        private void btn_add_MouseHover(object sender, EventArgs e)
        {
           //MessageBox.Show("Move the cursor Away!!");
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            panelSelected.Height = btn_reset.Height;    
            panelSelected.Top = btn_reset.Top;
            txt_number.Text = "";
            txt_count.Text = "";
            txt_objectName.Text = "";
            txt_price.Text = "";
            txt_SKU.Text = "";

        }

        private void dgvShowProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt_objectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}