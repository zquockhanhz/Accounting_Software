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

namespace winform
{
    public partial class frmQuanLyHD : Form
    {
        public frmQuanLyHD()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-EB3G68E\\SQLEXPRESS;" +
                            " Initial Catalog=QLBH;" +
                            "Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadHD()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HOADON";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewHD.DataSource = table;
        }

        //Hien thi du lieu
        private void QuanLyHD_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            connection = new SqlConnection(str);
            connection.Open();
            LoadHD();
        }

        //Chuyen sang trang chi tiet
        private void btnChiTietHD_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmChiTietHD frmThemHD = new frmChiTietHD();
            frmThemHD.ShowDialog();
            frmThemHD = null;
            this.Show();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HOADON where MAHD= '"+txtMaHD.Text+"'";
            int res = command.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Đã xóa thành công");
                LoadHD();
            }

            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HOADON values('" + txtMaHD.Text + "', '" + txtMaKH.Text + "', '" + txtMaNV.Text + "', '" + dtpNgayLapHD.Text + "')";
            if (txtMaHD.Text == "" || txtMaKH.Text == "" || txtMaNV.Text == "" || dtpNgayLapHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            int res = command.ExecuteNonQuery();
            if (res < 0)
            {
                MessageBox.Show("Thêm thất bại");
            }
            else
            {
                MessageBox.Show("Thêm thành công");
                LoadHD();
            }
        }

        private void dataGridViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMaHD.ReadOnly = true;
            int hd;
            hd = dataGridViewHD.CurrentRow.Index;
            txtMaHD.Text = dataGridViewHD.Rows[hd].Cells[0].Value.ToString();
            txtMaKH.Text = dataGridViewHD.Rows[hd].Cells[1].Value.ToString();
            txtMaNV.Text = dataGridViewHD.Rows[hd].Cells[2].Value.ToString();
            dtpNgayLapHD.Text = dataGridViewHD.Rows[hd].Cells[3].Value.ToString();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HOADON set MAKH= '"+txtMaKH.Text+"', MANV='"+txtMaNV.Text +"', NGAYLAP='"+dtpNgayLapHD.Text +"' where MAHD = '"+txtMaHD.Text+"'";
            int res = command.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LoadHD();
            }

            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            txtMaNV.Text = "";
            dtpNgayLapHD.Text = "";
            
        }

        private void frmQuanLyHD_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            this.Owner.Show();
        }
    }
}
