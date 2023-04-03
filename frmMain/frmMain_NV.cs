using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class frmMain_NV : Form
    {
        public frmMain_NV()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Guna.UI2.WinForms.Guna2GradientTileButton buttontbl = new Guna.UI2.WinForms.Guna2GradientTileButton();
                buttontbl.BackgroundImage = global::frmMain.Properties.Resources.tableBook;
                buttontbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                buttontbl.Cursor = System.Windows.Forms.Cursors.Hand;
                buttontbl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                buttontbl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                buttontbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                buttontbl.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                buttontbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                buttontbl.FillColor = System.Drawing.Color.Transparent;
                buttontbl.FillColor2 = System.Drawing.Color.Transparent;
                buttontbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                buttontbl.ForeColor = System.Drawing.Color.White;
                buttontbl.Location = new System.Drawing.Point(189, 3);
                buttontbl.Name = "F1-" + i;
                buttontbl.Size = new System.Drawing.Size(145, 145);
                buttontbl.TabIndex = 1;
                buttontbl.Text = "F1-0" + i;
                buttontbl.Click += (Button_Click);
                pnlTable.Controls.Add(buttontbl);
            }

        }



        private void Button_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder=new frmOrder();
            frmOrder.ShowDialog();
        }

    }
}
