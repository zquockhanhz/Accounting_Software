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
    public partial class frmChiTietHD : Form
    {
        public frmChiTietHD()
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

        void LoadCT()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from CHITIETHOADON";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewCT.DataSource = table;
        }

        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            connection = new SqlConnection(str);
            connection.Open();
            LoadCT();
        }

        private void dataGridViewCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.ReadOnly = true;
            int i;
            i = dataGridViewCT.CurrentRow.Index;
            txtMaHD.Text = dataGridViewCT.Rows[i].Cells[0].Value.ToString();
            txtMaHH.Text = dataGridViewCT.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = dataGridViewCT.Rows[i].Cells[2].Value.ToString();
            txtSoLuong.Text = dataGridViewCT.Rows[i].Cells[3].Value.ToString();
            txtThanhTien.Text = dataGridViewCT.Rows[i].Cells[4].Value.ToString();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command = connection.CreateCommand();
            command.CommandText = "insert into CHITIETHOADON values('" + txtMaHD.Text + "', '" + txtMaHH.Text + "', '" + txtSoLuong.Text + "')";
            if (txtMaHD.Text == "" || txtMaHH.Text == "" || txtSoLuong.Text == "")
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
                LoadCT();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from CHITIETHOADON where MAHD= '"+ txtMaHD.Text + "'";
                int res = command.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Đã xóa thành công");
                    LoadCT();
                }
                else
                {
                    MessageBox.Show(txtMaHD.Text);
                }
                
            }
            catch (Exception a)
            {

                throw a;
            }
            
      
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command = connection.CreateCommand();
            command.CommandText = "update CHITIETHOADON set MAHH= '"+txtMaHH.Text+"', SOLUONG='"+txtSoLuong.Text+"' where MAHD = '"+txtMaHD.Text+"'";
            int res = command.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LoadCT();
            }

            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaHH.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
        }

        private void frmChiTietHD_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            
        }
    }
}
