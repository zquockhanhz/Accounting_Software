using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace winform
{
    
    public partial class frmDangNhap : Form
    {
        private string tk = "admin";
        private string mk = "123456";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if (txtTaiKhoan.Text==tk &&txtMatKhau.Text == mk)
                {
                    MessageBox.Show("Thành Công");
                    Form3 trangchu = new Form3();
                    trangchu.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thất Bại");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Kết Nối");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
