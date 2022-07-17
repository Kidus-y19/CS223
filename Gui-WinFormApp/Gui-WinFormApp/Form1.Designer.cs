namespace Gui_WinFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_SKU = new System.Windows.Forms.TextBox();
            this.dtp_datepicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_sku = new System.Windows.Forms.Label();
            this.txt_objectName = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.lbl_ObjName = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.dgvShowProducts = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_phoneNo = new System.Windows.Forms.Label();
            this.txt_PhonNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSelected = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(141, 44);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(191, 32);
            this.txt_number.TabIndex = 0;
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_SKU
            // 
            this.txt_SKU.Location = new System.Drawing.Point(141, 196);
            this.txt_SKU.Name = "txt_SKU";
            this.txt_SKU.Size = new System.Drawing.Size(191, 32);
            this.txt_SKU.TabIndex = 2;
            // 
            // dtp_datepicker1
            // 
            this.dtp_datepicker1.Location = new System.Drawing.Point(112, 230);
            this.dtp_datepicker1.Name = "dtp_datepicker1";
            this.dtp_datepicker1.Size = new System.Drawing.Size(250, 32);
            this.dtp_datepicker1.TabIndex = 3;
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_number.Location = new System.Drawing.Point(15, 51);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(76, 21);
            this.lbl_number.TabIndex = 4;
            this.lbl_number.Text = "Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(15, 236);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(53, 21);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Date";
            // 
            // lbl_sku
            // 
            this.lbl_sku.AutoSize = true;
            this.lbl_sku.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sku.Location = new System.Drawing.Point(15, 203);
            this.lbl_sku.Name = "lbl_sku";
            this.lbl_sku.Size = new System.Drawing.Size(40, 21);
            this.lbl_sku.TabIndex = 4;
            this.lbl_sku.Text = "SKU";
            // 
            // txt_objectName
            // 
            this.txt_objectName.Location = new System.Drawing.Point(141, 82);
            this.txt_objectName.Name = "txt_objectName";
            this.txt_objectName.Size = new System.Drawing.Size(191, 32);
            this.txt_objectName.TabIndex = 0;
            this.txt_objectName.TextChanged += new System.EventHandler(this.txt_objectName_TextChanged);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_count.Location = new System.Drawing.Point(15, 120);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(62, 21);
            this.lbl_count.TabIndex = 4;
            this.lbl_count.Text = "Count";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(141, 120);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(191, 32);
            this.txt_count.TabIndex = 2;
            // 
            // lbl_ObjName
            // 
            this.lbl_ObjName.AutoSize = true;
            this.lbl_ObjName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ObjName.Location = new System.Drawing.Point(15, 86);
            this.lbl_ObjName.Name = "lbl_ObjName";
            this.lbl_ObjName.Size = new System.Drawing.Size(125, 21);
            this.lbl_ObjName.TabIndex = 4;
            this.lbl_ObjName.Text = "Object Name";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(141, 158);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(191, 32);
            this.txt_price.TabIndex = 2;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.Location = new System.Drawing.Point(15, 160);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(50, 21);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(0, 143);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(247, 122);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.MouseHover += new System.EventHandler(this.btn_add_MouseHover);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(3, 271);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(247, 122);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.Location = new System.Drawing.Point(3, 388);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(247, 122);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // dgvShowProducts
            // 
            this.dgvShowProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvShowProducts.Name = "dgvShowProducts";
            this.dgvShowProducts.RowHeadersWidth = 51;
            this.dgvShowProducts.RowTemplate.Height = 29;
            this.dgvShowProducts.Size = new System.Drawing.Size(936, 326);
            this.dgvShowProducts.TabIndex = 9;
            this.dgvShowProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowProducts_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_phoneNo
            // 
            this.lbl_phoneNo.AutoSize = true;
            this.lbl_phoneNo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_phoneNo.Location = new System.Drawing.Point(3, 102);
            this.lbl_phoneNo.Name = "lbl_phoneNo";
            this.lbl_phoneNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_phoneNo.TabIndex = 10;
            this.lbl_phoneNo.Text = "PhoneNum";
            // 
            // txt_PhonNo
            // 
            this.txt_PhonNo.Location = new System.Drawing.Point(117, 93);
            this.txt_PhonNo.Name = "txt_PhonNo";
            this.txt_PhonNo.Size = new System.Drawing.Size(199, 32);
            this.txt_PhonNo.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 594);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.lblHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 125);
            this.panel3.TabIndex = 0;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHome.ForeColor = System.Drawing.Color.Black;
            this.lblHome.Location = new System.Drawing.Point(53, 23);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(134, 72);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Shop";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvShowProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(250, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 326);
            this.panel2.TabIndex = 13;
            // 
            // panelSelected
            // 
            this.panelSelected.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelSelected.Location = new System.Drawing.Point(250, 131);
            this.panelSelected.Name = "panelSelected";
            this.panelSelected.Size = new System.Drawing.Size(7, 141);
            this.panelSelected.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbl_number);
            this.panel4.Controls.Add(this.txt_number);
            this.panel4.Controls.Add(this.lbl_ObjName);
            this.panel4.Controls.Add(this.txt_objectName);
            this.panel4.Controls.Add(this.lbl_count);
            this.panel4.Controls.Add(this.dtp_datepicker1);
            this.panel4.Controls.Add(this.lbl_date);
            this.panel4.Controls.Add(this.lbl_sku);
            this.panel4.Controls.Add(this.lbl_price);
            this.panel4.Controls.Add(this.txt_SKU);
            this.panel4.Controls.Add(this.txt_count);
            this.panel4.Controls.Add(this.txt_price);
            this.panel4.Location = new System.Drawing.Point(273, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 268);
            this.panel4.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblCustName);
            this.panel5.Controls.Add(this.txt_Name);
            this.panel5.Controls.Add(this.txt_Email);
            this.panel5.Controls.Add(this.lblCustEmail);
            this.panel5.Controls.Add(this.lblCustomerDetails);
            this.panel5.Controls.Add(this.lbl_phoneNo);
            this.panel5.Controls.Add(this.txt_PhonNo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(649, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(537, 268);
            this.panel5.TabIndex = 16;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustName.Location = new System.Drawing.Point(3, 60);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(61, 21);
            this.lblCustName.TabIndex = 10;
            this.lblCustName.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(117, 51);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(199, 32);
            this.txt_Name.TabIndex = 14;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(117, 143);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(199, 32);
            this.txt_Email.TabIndex = 13;
            this.txt_Email.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustEmail.Location = new System.Drawing.Point(3, 146);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(52, 21);
            this.lblCustEmail.TabIndex = 12;
            this.lblCustEmail.Text = "Email";
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Location = new System.Drawing.Point(22, 23);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(175, 23);
            this.lblCustomerDetails.TabIndex = 0;
            this.lblCustomerDetails.Text = "Customer Details";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1186, 594);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelSelected);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_number;
        private TextBox txt_SKU;
        private DateTimePicker dtp_datepicker1;
        private Label lbl_number;
        private Label lbl_date;
        private Label lbl_sku;
        private TextBox txt_objectName;
        private Label lbl_count;
        private TextBox txt_count;
        private Label lbl_ObjName;
        private TextBox txt_price;
        private Label lbl_price;
        private Button btn_add;
        private Button btn_cancel;
        private Button btn_reset;
        private DataGridView dgvShowProducts;
        private ErrorProvider errorProvider1;
        private TextBox txt_PhonNo;
        private Label lbl_phoneNo;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label lblHome;
        private Panel panelSelected;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private Label lblCustName;
        private TextBox txt_Name;
        private TextBox txt_Email;
        private Label lblCustEmail;
        private Label lblCustomerDetails;
    }
}