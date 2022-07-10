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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_addItem = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(81, 114);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(125, 27);
            this.txt_number.TabIndex = 0;
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_SKU
            // 
            this.txt_SKU.Location = new System.Drawing.Point(519, 116);
            this.txt_SKU.Name = "txt_SKU";
            this.txt_SKU.Size = new System.Drawing.Size(125, 27);
            this.txt_SKU.TabIndex = 2;
            // 
            // dtp_datepicker1
            // 
            this.dtp_datepicker1.Location = new System.Drawing.Point(238, 114);
            this.dtp_datepicker1.Name = "dtp_datepicker1";
            this.dtp_datepicker1.Size = new System.Drawing.Size(250, 27);
            this.dtp_datepicker1.TabIndex = 3;
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_number.Location = new System.Drawing.Point(81, 78);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(81, 25);
            this.lbl_number.TabIndex = 4;
            this.lbl_number.Text = "Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(238, 78);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(52, 25);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Date";
            // 
            // lbl_sku
            // 
            this.lbl_sku.AutoSize = true;
            this.lbl_sku.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sku.Location = new System.Drawing.Point(519, 78);
            this.lbl_sku.Name = "lbl_sku";
            this.lbl_sku.Size = new System.Drawing.Size(47, 25);
            this.lbl_sku.TabIndex = 4;
            this.lbl_sku.Text = "SKU";
            // 
            // txt_objectName
            // 
            this.txt_objectName.Location = new System.Drawing.Point(81, 212);
            this.txt_objectName.Name = "txt_objectName";
            this.txt_objectName.Size = new System.Drawing.Size(369, 27);
            this.txt_objectName.TabIndex = 0;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_count.Location = new System.Drawing.Point(81, 254);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(63, 25);
            this.lbl_count.TabIndex = 4;
            this.lbl_count.Text = "Count";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(79, 294);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(125, 27);
            this.txt_count.TabIndex = 2;
            // 
            // lbl_ObjName
            // 
            this.lbl_ObjName.AutoSize = true;
            this.lbl_ObjName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ObjName.Location = new System.Drawing.Point(81, 173);
            this.lbl_ObjName.Name = "lbl_ObjName";
            this.lbl_ObjName.Size = new System.Drawing.Size(123, 25);
            this.lbl_ObjName.TabIndex = 4;
            this.lbl_ObjName.Text = "Object Name";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(238, 294);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(125, 27);
            this.txt_price.TabIndex = 2;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.Location = new System.Drawing.Point(238, 254);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(54, 25);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(81, 358);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.MouseHover += new System.EventHandler(this.btn_add_MouseHover);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(238, 358);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lbl_addItem);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 70);
            this.panel1.TabIndex = 7;
            // 
            // lbl_addItem
            // 
            this.lbl_addItem.AutoSize = true;
            this.lbl_addItem.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_addItem.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_addItem.Location = new System.Drawing.Point(91, 22);
            this.lbl_addItem.Name = "lbl_addItem";
            this.lbl_addItem.Size = new System.Drawing.Size(125, 26);
            this.lbl_addItem.TabIndex = 8;
            this.lbl_addItem.Text = "ADD ITEM";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(407, 358);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 29);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_sku);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_ObjName);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.dtp_datepicker1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_objectName);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_SKU);
            this.Controls.Add(this.txt_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel panel1;
        private Label lbl_addItem;
        private Button btn_reset;
    }
}