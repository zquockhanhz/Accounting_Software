using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text== "Nhân Viên")
            {
                frmNhanVien nv = new frmNhanVien();
                nv.Show(this);
                this.Hide();
            }
            else if (((Button)sender).Text == "Nhà Cung Cấp")
            {
                frmNhaCungCap nv = new frmNhaCungCap();
                nv.Show(this);
                this.Hide();
            }
            else if (((Button)sender).Text == "Hàng Hoá")
            {
                frmHangHoa nv = new frmHangHoa();
                nv.Show(this);
                this.Hide();
            }
            else if (((Button)sender).Text == "Khách Hàng")
            {
                frmKhachHang nv = new frmKhachHang();
                nv.Show(this);
                this.Hide();
            }
            else if (((Button)sender).Text == "Hoá Đơn")
            {
                frmQuanLyHD nv = new frmQuanLyHD();
                nv.Show(this);
                this.Hide();
            }
            else if (((Button)sender).Text == "Phiếu Thu")
            {
                Form1 nv = new Form1();
                nv.Show(this);
                this.Hide();
            }
            else if (((Button)sender).Text == "Phiếu Chi")
            {
                Form2 nv = new Form2();
                nv.Show(this);
                this.Hide();
            }
            else if (((Button)sender).Text == "Tình hình bán hàng")
            {
                XEMBAOCAO2 nv = new XEMBAOCAO2();
                nv.Show(this);
                this.Hide();
            }
            else if (((Button)sender).Text == "Công nợ khách hàng")
            {
                frmXemBaoCao nv = new frmXemBaoCao();
                nv.Show(this);
                this.Hide();
            }
            else
            {

            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
