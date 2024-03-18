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
    public partial class TimKiem : Form
    {
        private DataSet danhsach;

        public DataSet DS
        {
            get { return danhsach; }
            set { danhsach = value; }
        }


        public TimKiem()
        {
            InitializeComponent();
        }

        public TimKiem(DataSet ds, string sender)
        {
            DS = ds;
            InitializeComponent();
            if (sender=="KhachHang")
            {
                dataGridView1.DataSource = DS.Tables["KHACHHANG"];
            }
            else if (sender == "HangHoa")
            {
                dataGridView1.DataSource = DS.Tables["HANGHOA"];
            }
            else if (sender == "NhanVien")
            {
                dataGridView1.DataSource = DS.Tables["NHANVIEN"];
            }
            else if (sender == "NhaCungCap")
            {
                dataGridView1.DataSource = DS.Tables["NHACUNGCAP"];
            }
            else
            {
                this.Close();
            }
            CenterToScreen();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimKiem_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
