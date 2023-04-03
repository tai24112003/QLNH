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
    public partial class uFood_ : UserControl
    {
        public uFood_()
        {
            InitializeComponent();
        }



        private void uFood__Click(object sender, EventArgs e)
        {
            if (check.Visible == true)
            {
                check.Visible = false;
            }
            else
                check.Visible = true;
        }
        public string TenMon
        {
            get { return lblTenMon.Text; }
            set { lblTenMon.Text = value; }
        }
        public string GiaMon
        {
            get { return lblGia.Text; }
            set { lblGia.Text = value; }
        }

        

    }
}
