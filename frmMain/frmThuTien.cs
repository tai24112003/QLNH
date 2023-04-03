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
    public partial class frmThuTien : Form
    {
        public frmThuTien()
        {
            InitializeComponent();
        }

        private void frmThuTien_Load(object sender, EventArgs e)
        {
            foreach(Control control in pnlTien.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button button)
                {
                    button.Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            string buttonText = button.Text;
            string[] arrbtn = buttonText.Split(',');
            string[] arrtxt = txtTien.Text.Split(',');
            int n=arrtxt.Length;
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong+=double.Parse(arrtxt[i])*Math.Pow(10,3*(n-i-1));
            }
            double tongtien = double.Parse(arrbtn[0]) * 1000 + tong;
            txtTien.Text = tongtien.ToString("#,##0"); // Hiển thị số tiền lên Panel
        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {
            string[] arrtxt = txtTien.Text.Split(',');
            int n = arrtxt.Length;
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += double.Parse(arrtxt[i]) * Math.Pow(10, 3 * (n - i - 1));
            }
            lblThu.Text = (int.Parse(lblSoTien.Text)-tong).ToString("#,##0");

            if (lblThu.Text.IndexOf('-') == 0)
            {
                lblThu.Text = "0";
                lblTra.Text = (tong - int.Parse(lblSoTien.Text)).ToString("#,##0");
            }

        }

    }
}
