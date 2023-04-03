namespace frmMain
{
    partial class Bill
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
            this.lblTenMonAn = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.nbrSl = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenMonAn
            // 
            this.lblTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMonAn.Location = new System.Drawing.Point(22, 13);
            this.lblTenMonAn.Name = "lblTenMonAn";
            this.lblTenMonAn.Size = new System.Drawing.Size(270, 48);
            this.lblTenMonAn.TabIndex = 0;
            this.lblTenMonAn.Text = "a";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(401, 13);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(227, 48);
            this.lblThanhTien.TabIndex = 0;
            this.lblThanhTien.Text = "50000";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nbrSl
            // 
            this.nbrSl.BackColor = System.Drawing.Color.Transparent;
            this.nbrSl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbrSl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nbrSl.Location = new System.Drawing.Point(298, 13);
            this.nbrSl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbrSl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbrSl.Name = "nbrSl";
            this.nbrSl.Size = new System.Drawing.Size(89, 48);
            this.nbrSl.TabIndex = 3;
            this.nbrSl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(105, 29);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(14, 16);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "1";
            this.lblGia.Visible = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.nbrSl);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblTenMonAn);
            this.Name = "Bill";
            this.Size = new System.Drawing.Size(640, 70);
            ((System.ComponentModel.ISupportInitialize)(this.nbrSl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.Label lblThanhTien;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbrSl;
        private System.Windows.Forms.Label lblGia;
    }
}
