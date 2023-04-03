namespace frmMain
{
    partial class Bill_TT
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
            this.nbrSl = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblTenMonAn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSl)).BeginInit();
            this.SuspendLayout();
            // 
            // nbrSl
            // 
            this.nbrSl.BackColor = System.Drawing.Color.Transparent;
            this.nbrSl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbrSl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nbrSl.Location = new System.Drawing.Point(331, 11);
            this.nbrSl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbrSl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbrSl.Name = "nbrSl";
            this.nbrSl.Size = new System.Drawing.Size(89, 48);
            this.nbrSl.TabIndex = 7;
            this.nbrSl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(659, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(348, 70);
            this.lblThanhTien.TabIndex = 5;
            this.lblThanhTien.Text = "50000";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenMonAn
            // 
            this.lblTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMonAn.Location = new System.Drawing.Point(3, 11);
            this.lblTenMonAn.Name = "lblTenMonAn";
            this.lblTenMonAn.Size = new System.Drawing.Size(270, 48);
            this.lblTenMonAn.TabIndex = 6;
            this.lblTenMonAn.Text = "a";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 70);
            this.label1.TabIndex = 8;
            this.label1.Text = "50000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbrSl);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblTenMonAn);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1007, 70);
            ((System.ComponentModel.ISupportInitialize)(this.nbrSl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2NumericUpDown nbrSl;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.Label label1;
    }
}
