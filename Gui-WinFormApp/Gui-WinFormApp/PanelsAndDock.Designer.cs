namespace Gui_WinFormApp
{
    partial class PanelsAndDock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnPan4 = new System.Windows.Forms.Button();
            this.panIndicator = new System.Windows.Forms.Panel();
            this.btnPan3 = new System.Windows.Forms.Button();
            this.btnPan2 = new System.Windows.Forms.Button();
            this.btnPan1 = new System.Windows.Forms.Button();
            this.panCenter = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panMenu.SuspendLayout();
            this.panCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.btnPan4);
            this.panMenu.Controls.Add(this.panIndicator);
            this.panMenu.Controls.Add(this.btnPan3);
            this.panMenu.Controls.Add(this.btnPan2);
            this.panMenu.Controls.Add(this.btnPan1);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(250, 450);
            this.panMenu.TabIndex = 0;
            // 
            // btnPan4
            // 
            this.btnPan4.Location = new System.Drawing.Point(74, 328);
            this.btnPan4.Name = "btnPan4";
            this.btnPan4.Size = new System.Drawing.Size(94, 29);
            this.btnPan4.TabIndex = 4;
            this.btnPan4.Text = "Violet";
            this.btnPan4.UseVisualStyleBackColor = true;
            this.btnPan4.Click += new System.EventHandler(this.btnPan4_Click);
            // 
            // panIndicator
            // 
            this.panIndicator.Location = new System.Drawing.Point(174, 95);
            this.panIndicator.Name = "panIndicator";
            this.panIndicator.Size = new System.Drawing.Size(32, 26);
            this.panIndicator.TabIndex = 3;
            // 
            // btnPan3
            // 
            this.btnPan3.Location = new System.Drawing.Point(74, 255);
            this.btnPan3.Name = "btnPan3";
            this.btnPan3.Size = new System.Drawing.Size(94, 29);
            this.btnPan3.TabIndex = 2;
            this.btnPan3.Text = "Orange";
            this.btnPan3.UseVisualStyleBackColor = true;
            this.btnPan3.Click += new System.EventHandler(this.btnPan3_Click);
            // 
            // btnPan2
            // 
            this.btnPan2.Location = new System.Drawing.Point(74, 171);
            this.btnPan2.Name = "btnPan2";
            this.btnPan2.Size = new System.Drawing.Size(94, 29);
            this.btnPan2.TabIndex = 1;
            this.btnPan2.Text = "Blue";
            this.btnPan2.UseVisualStyleBackColor = true;
            this.btnPan2.Click += new System.EventHandler(this.btnPan2_Click);
            // 
            // btnPan1
            // 
            this.btnPan1.Location = new System.Drawing.Point(74, 92);
            this.btnPan1.Name = "btnPan1";
            this.btnPan1.Size = new System.Drawing.Size(94, 29);
            this.btnPan1.TabIndex = 0;
            this.btnPan1.Text = "Red";
            this.btnPan1.UseVisualStyleBackColor = true;
            this.btnPan1.Click += new System.EventHandler(this.btnPan1_Click);
            // 
            // panCenter
            // 
            this.panCenter.Controls.Add(this.flowLayoutPanel1);
            this.panCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCenter.Location = new System.Drawing.Point(250, 0);
            this.panCenter.Name = "panCenter";
            this.panCenter.Size = new System.Drawing.Size(550, 450);
            this.panCenter.TabIndex = 1;
            this.panCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panCenter_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 224);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 226);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // PanelsAndDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panCenter);
            this.Controls.Add(this.panMenu);
            this.Name = "PanelsAndDock";
            this.Text = "PanelsAndDock";
            this.Load += new System.EventHandler(this.PanelsAndDock_Load);
            this.panMenu.ResumeLayout(false);
            this.panCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panMenu;
        private Button btnPan3;
        private Button btnPan2;
        private Button btnPan1;
        private Panel panCenter;
        private Button btnPan4;
        private Panel panIndicator;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}