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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                uFood_ Food = new uFood_();
                Food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                Food.Location = new System.Drawing.Point(3, 3);
                Food.Name = "Food"+i;
                Food.Size = new System.Drawing.Size(150, 150);
                Food.TabIndex = 0;
                Food.TenMon = "Tên món ăn"+i;
                Food.GiaMon = (10000*i).ToString();
                Food.Click += (Button_Click);
                pnlFood.Controls.Add(Food);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            uFood_ clickedButton = sender as uFood_;
            if (clickedButton == null)
            {
                return;
            }

            if (clickedButton.Tag == null || clickedButton.Tag.ToString() == "unselected")
            {
                Bill bill = new Bill(clickedButton.TenMon, 1, clickedButton.GiaMon);
                bill.SLChanged += (s, ev) => { CalculateTotalPrice(); };
                clickedButton.Tag = "selected";
                bill.Tag = "selected";
                pnlOrder.Controls.Add(bill);
            }
            else
            {
                foreach (Control control in pnlOrder.Controls)
                {
                    if (control is Bill bill && bill.Tag != null && bill.Tag.ToString() == "selected" && bill.TenMonAn == clickedButton.TenMon)
                    {
                        pnlOrder.Controls.Remove(bill);
                        clickedButton.Tag = "unselected";
                        bill.Tag = "unselected";
                        break;
                    }
                }
            }
            CalculateTotalPrice();
        }
        private void Bill_SLChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }
        private void CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (Control control in pnlOrder.Controls)
            {
                if (control is Bill bill)
                {
                    decimal price = int.Parse(bill.ThanhTien);
                    totalPrice +=price;
                }
            }
            lblTongTien.Text = totalPrice.ToString("#,##0");
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
