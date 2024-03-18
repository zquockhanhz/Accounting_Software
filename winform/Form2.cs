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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-EB3G68E\\SQLEXPRESS;" +
                            " Initial Catalog=QLBH;" +
                            "Integrated Security = True";
        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
        }
        private void HienThiSanPham()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PHIEUCHI";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            listView1.Columns.Add("Mã phiếu");
            listView1.Columns.Add("MaNCC");
            listView1.Columns.Add("MaHH");
            listView1.Columns.Add("Số lượng");

            while (reader.Read())
            {
                string[] row = new string[5];
                // Đọc giá trị từng cột và gán vào mảng
                row[0] = reader.GetString(0);
                row[1] = reader.GetString(1);
                row[2] = reader.GetString(2);
                row[3] = reader.GetInt32(3).ToString();
                ListViewItem item = new ListViewItem(row);

                // Thêm dòng vào ListView
                listView1.Items.Add(item);
            }

            // Đóng kết nối và giải phóng tài nguyên
            reader.Close();
            conn.Close();
        }
        private void HienThiRow()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PHIEUCHI";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                string[] row = new string[5];
                // Đọc giá trị từng cột và gán vào mảng
                row[0] = reader.GetString(0);
                row[1] = reader.GetString(1);
                row[2] = reader.GetString(2);
                row[3] = reader.GetInt32(3).ToString();
                ListViewItem item = new ListViewItem(row);

                // Thêm dòng vào ListView
                listView1.Items.Add(item);
            }

            // Đóng kết nối và giải phóng tài nguyên
            reader.Close();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO PHIEUCHI (MAPHIEU, MANCC, MAHH, SOLUONG) VALUES (@maphieu, @mancc, @mahh, @soluong)";
            command.Connection = conn;

            if (tbMaPhieu.Text == "" || tbMaNCC.Text == "" || tbMaHH.Text == "" || tbSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            command.Parameters.Add("@MAPHIEU", SqlDbType.NVarChar).Value = tbMaPhieu.Text;
            command.Parameters.Add("@MANCC", SqlDbType.NVarChar).Value = tbMaNCC.Text;
            command.Parameters.Add("@MAHH", SqlDbType.NVarChar).Value = tbMaHH.Text;
            command.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = int.Parse(tbSoLuong.Text);

            
            try
            {
                int ret = command.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công");
                listView1.Items.Clear();
                HienThiRow();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listView1.SelectedItems[0];
                string maPHIEU = selectedRow.SubItems[0].Text;

                if (conn == null)
                    conn = new SqlConnection(strConn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM PHIEUCHI WHERE MAPHIEU = @maPHIEU";
                command.Connection = conn;
                command.Parameters.AddWithValue("@maPHIEU", maPHIEU);
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Đã xóa thành công");
                    listView1.Items.Clear();
                    HienThiRow();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Đã xóa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn để xoá.");
                return;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem lvi = listView1.SelectedItems[0];
            tbMaPhieu.Text = lvi.SubItems[0].Text;
            tbMaNCC.Text = lvi.SubItems[1].Text;
            tbMaHH.Text = lvi.SubItems[2].Text;
            tbSoLuong.Text = lvi.SubItems[3].Text;
        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE PHIEUCHI SET MANCC = @MANCC, MAHH = @MAHH, SOLUONG = @SOLUONG WHERE MAPHIEU = @MAPHIEU";
            command.Connection = conn;
            if (listView1.SelectedItems.Count > 0)
            {
                command.Parameters.Add("@MAPHIEU", SqlDbType.NVarChar).Value = tbMaPhieu.Text;
                command.Parameters.Add("@MANCC", SqlDbType.NVarChar).Value = tbMaNCC.Text;
                command.Parameters.Add("@MAHH", SqlDbType.NVarChar).Value = tbMaHH.Text;
                command.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = int.Parse(tbSoLuong.Text);

                try
                {
                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật thành công.");
                    listView1.Items.Clear();
                    HienThiRow();
                    conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn để sửa.");
                return;
            }
            

            
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            this.Owner.Show();
        }
    }
}
