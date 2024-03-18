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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-EB3G68E\\SQLEXPRESS;" +
                            " Initial Catalog=QLBH;" +
                            "Integrated Security = True";
        private void Form1_Load(object sender, EventArgs e)
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
            command.CommandText = "Select * from PHIEUTHU";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            listView1.Columns.Add("Mã phiếu");
            listView1.Columns.Add("MaKH");
            listView1.Columns.Add("MaHD");

            while (reader.Read())
            {
                string[] row = new string[5];
                // Đọc giá trị từng cột và gán vào mảng
                row[0] = reader.GetString(0); 
                row[1] = reader.GetString(1); 
                row[2] = reader.GetString(2); 
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
            command.CommandText = "Select * from PHIEUTHU";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string[] row = new string[5];
                // Đọc giá trị từng cột và gán vào mảng
                row[0] = reader.GetString(0);
                row[1] = reader.GetString(1);
                row[2] = reader.GetString(2);
                ListViewItem item = new ListViewItem(row);

                // Thêm dòng vào ListView
                listView1.Items.Add(item);
            }

            // Đóng kết nối và giải phóng tài nguyên
            reader.Close();
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
                command.CommandText = "DELETE FROM PHIEUTHU WHERE MAPHIEU = @maPHIEU";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO PHIEUTHU (MAPHIEU, MAKH, MAHD,Sotientra) VALUES (@maphieu, @makh, @mahd,@sotientra)";
            command.Connection = conn;

            if (tbMaPhieu.Text == "" || tbMaKH.Text == "" || tbMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            command.Parameters.Add("@MAPHIEU", SqlDbType.NVarChar).Value = tbMaPhieu.Text;
            command.Parameters.Add("@MAKH", SqlDbType.NVarChar).Value = tbMaKH.Text;
            command.Parameters.Add("@MAHD", SqlDbType.NVarChar).Value = tbMaHD.Text;
            if (txtsotientra.Text=="")
            {
                command.Parameters.Add("@sotientra", SqlDbType.NVarChar).Value = "0";
            }
            else
            {
                command.Parameters.Add("@sotientra", SqlDbType.NVarChar).Value = txtsotientra.Text;
            }
            
            //try
            //{
                int ret = command.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công");
                listView1.Items.Clear();
                HienThiRow();
                conn.Close();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Thêm thất bại");
            //}

        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE PHIEUTHU SET MAKH = @MAKH, MAHD = @MAHD WHERE MAPHIEU = @MAPHIEU";
            command.Connection = conn;

            if (listView1.SelectedItems.Count > 0)
            {
                command.Parameters.Add("@MAPHIEU", SqlDbType.NVarChar).Value = tbMaPhieu.Text;
                command.Parameters.Add("@MAKH", SqlDbType.NVarChar).Value = tbMaKH.Text;
                command.Parameters.Add("@MAHD", SqlDbType.NVarChar).Value = tbMaHD.Text;

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
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn để sửa.");
                return;
            }
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem lvi = listView1.SelectedItems[0];

            tbMaPhieu.Text = lvi.SubItems[0].Text;
            tbMaKH.Text = lvi.SubItems[1].Text;
            tbMaHD.Text = lvi.SubItems[2].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
                ListViewItem selectedRow = listView1.SelectedItems[0];
                string maPHIEU = selectedRow.SubItems[0].Text;

                if (conn == null)
                    conn = new SqlConnection(strConn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = @"SELECT PHIEUTHU.MAKH, KHACHHANG.TENKH, HOADON.MAHD, HANGHOA.TENHH, HANGHOA.LOAIHH, HANGHOA.DONGIA, CHITIETHOADON.SOLUONG, HANGHOA.DONGIA * CHITIETHOADON.SOLUONG AS TONGTIEN
                            FROM PHIEUTHU
                            JOIN KHACHHANG ON PHIEUTHU.MAKH = KHACHHANG.MAKH
                            JOIN HOADON ON PHIEUTHU.MAHD = HOADON.MAHD
                            JOIN CHITIETHOADON ON HOADON.MAHD = CHITIETHOADON.MAHD
                            JOIN HANGHOA ON CHITIETHOADON.MAHH = HANGHOA.MAHH
                            WHERE PHIEUTHU.MAPHIEU = @maPHIEU";
                command.Connection = conn;
                command.Parameters.AddWithValue("@maPHIEU", maPHIEU);

                SqlDataReader reader = command.ExecuteReader();

                List<object> data = new List<object>();
                if (reader.Read())
                {
                    string[] rows = new string[5];
                    string maKH = reader.GetString(0);
                    string tenKH = reader.GetString(1);
                    string maHD = reader.GetString(2);
                    string tenHH = reader.GetString(3);
                    string loaiHH = reader.GetString(4);
                    int dongia = reader.GetInt32(5);
                    int soluong = reader.GetInt32(6);
                    int tongtien = reader.GetInt32(7);

                    data.Add(maKH);
                    data.Add(tenKH);
                    data.Add(maHD);
                    data.Add(tenHH);
                    data.Add(loaiHH);
                    data.Add(dongia);
                    data.Add(soluong);
                    data.Add(tongtien);

                    // Truyền các giá trị này vào Form4 để hiển thị
                    Form4 frmChitiet = new Form4(data.ToArray());
                    frmChitiet.ShowDialog();
                }

                reader.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn để xem.");
                return;
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            this.Owner.Show();
        }
    }
}
