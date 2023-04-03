namespace frmMain
{
    partial class uFood_
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblGia = new System.Windows.Forms.Label();
            this.check = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblTenMon);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 89);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(135, 46);
            this.guna2ShadowPanel1.TabIndex = 5;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.BackColor = System.Drawing.Color.Transparent;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.ForeColor = System.Drawing.Color.White;
            this.lblTenMon.Location = new System.Drawing.Point(7, 13);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(86, 18);
            this.lblTenMon.TabIndex = 1;
            this.lblTenMon.Text = "Cơm gà rán";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.lblGia);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(4, 16);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(111, 34);
            this.guna2CustomGradientPanel1.TabIndex = 4;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.BackColor = System.Drawing.Color.Transparent;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.White;
            this.lblGia.Location = new System.Drawing.Point(8, 6);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(59, 20);
            this.lblGia.TabIndex = 0;
            this.lblGia.Text = "50000";
            // 
            // check
            // 
            this.check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.check.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.check.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.check.Image = global::frmMain.Properties.Resources.check_box;
            this.check.ImageOffset = new System.Drawing.Point(0, 0);
            this.check.ImageRotate = 0F;
            this.check.ImageSize = new System.Drawing.Size(40, 40);
            this.check.Location = new System.Drawing.Point(129, 117);
            this.check.Name = "check";
            this.check.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.check.Size = new System.Drawing.Size(37, 33);
            this.check.TabIndex = 6;
            this.check.Visible = false;
            // 
            // uFood_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmMain.Properties.Resources.com_dui_ga_bb3e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.check);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "uFood_";
            this.Size = new System.Drawing.Size(164, 150);
            this.Click += new System.EventHandler(this.uFood__Click);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenMon;
        private Guna.UI2.WinForms.Guna2ImageButton check;
    }
}
