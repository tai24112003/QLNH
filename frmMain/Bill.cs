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
    public partial class Bill : UserControl
    {
        public event EventHandler SLChanged;
        public Bill()
        {
            InitializeComponent();
        }
        public string TenMonAn
        {
            get { return lblTenMonAn.Text; }
            set { lblTenMonAn.Text = value; }
        }

        public decimal SL
        {
            get { return nbrSl.Value; }
            set { nbrSl.Value = value; }
        }
        public string ThanhTien
        {
            get { return lblThanhTien.Text; }
            set { lblThanhTien.Text = value; }
        }
        public Bill(string Ten,decimal iSL,string Gia)
        {
            InitializeComponent();
            lblTenMonAn.Text=Ten;
            nbrSl.Value = iSL;
            lblThanhTien.Text=Gia;
            lblGia.Text = Gia;
            nbrSl.ValueChanged += (sender, e) =>
            {
                SL = (int)nbrSl.Value;
                ThanhTien = (SL * int.Parse(lblGia.Text)).ToString();
                lblThanhTien.Text = ThanhTien;
                OnSLChanged(EventArgs.Empty);
            };
        }
        protected virtual void OnSLChanged(EventArgs e)
        {
            SLChanged?.Invoke(this, e);
        }
       
    }
}
