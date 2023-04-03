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
    public partial class frmMain_QL : Form
    {
        bool sliderExpand=false;
        public frmMain_QL()
        {
            InitializeComponent();
        }

        private void sildebarTimer_Tick(object sender, EventArgs e)
        {
            if (sliderExpand)
            {
                panelOption.Width -= 10;
                if (panelOption.Width == panelOption.MinimumSize.Width)
                {
                    sliderExpand = false;
                    sildebarTimer.Stop();
                }
            }
            else
            {
                panelOption.Width += 10;
                if (panelOption.Width == panelOption.MaximumSize.Width)
                {
                    sliderExpand = true;
                    sildebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sildebarTimer.Start();
        }
        private void frmMain_QL_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            frm_danhmuc_khachhang a = new frm_danhmuc_khachhang();
            a.MdiParent = this;
            a.Show();
        }
        
    }
}
