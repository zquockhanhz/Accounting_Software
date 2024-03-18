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
using System.Drawing.Drawing2D;

namespace winform
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-EB3G68E\\SQLEXPRESS;" +
                            " Initial Catalog=QLBH;" +
                            "Integrated Security = True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void fnCapNhat()
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(strConn);

                adapter = new SqlDataAdapter("Select * from NHANVIEN", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                ds = new DataSet();
                adapter.Fill(ds, "NHANVIEN");

                dataGridViewHH.DataSource = ds.Tables["NHANVIEN"];
                conn.Close();
            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
                
            }
            conn.Close();

        }

        private void dataGridViewHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1||vt >dataGridViewHH.RowCount) return;
            DataRow row = ds.Tables["NHANVIEN"].Rows[vt];
        }

        int vt = -1;
        private void btnFormXoaNCC_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để xóa");
                return;
            }
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn xóa Nhân viên này không ???",
                    "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                try
                {
                    DataRow row = ds.Tables["NHANVIEN"].Rows[vt];
                    row.Delete();

                    int kq = adapter.Update(ds.Tables["NHANVIEN"]);
                    if (kq > 0)
                    {
                        fnCapNhat();
                        MessageBox.Show("Đã xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại");
                    
                }
                conn.Close();
                
                
            }
        }

        private void btnFormThemNCC_Click(object sender, EventArgs e)
        {
            
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            frmThemNV frmThemHH = new frmThemNV();
            frmThemHH.ShowDialog();
            if (frmThemHH.KetQua)
            {
                MessageBox.Show("Thêm thành công");
                fnCapNhat();
            }
            
            frmThemHH = null;
        }

        private void btnFormSuaNCC_Click(object sender, EventArgs e)
        {
            if (vt==-1)
            {
                vt = 0;
            }
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            frmSuaNV frmSuaHH = new frmSuaNV(vt);
            frmSuaHH.ShowDialog();
            if (frmSuaHH.KetQua)
            {
                MessageBox.Show("Cập nhật thành công");
                fnCapNhat();
            }
            
            frmSuaHH = null;
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {

            CenterToScreen();
            try
            {
                if (conn == null)
                    conn = new SqlConnection(strConn);

                adapter = new SqlDataAdapter("Select * from NHANVIEN", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                ds = new DataSet();
                adapter.Fill(ds, "NHANVIEN");

                dataGridViewHH.DataSource = ds.Tables["NHANVIEN"];
            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
            conn.Close();
        }

        private void btnTimKiemHH_Click(object sender, EventArgs e)
        {
            ds.Tables["NHANVIEN"].DefaultView.RowFilter = " MANV Like'*" + txtTimKiemHH.Text + "*' " +
                "or TENNV Like'*" + txtTimKiemHH.Text + "*' " +
                "OR DIACHI Like'*" + txtTimKiemHH.Text + "*' " +
                "OR EMAIL Like'*" + txtTimKiemHH.Text + "*' ";
            dataGridViewHH.DataSource = ds.Tables["NHANVIEN"];
            TimKiem tk = new TimKiem(ds, "NhanVien");
            tk.ShowDialog();
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void txtTimKiemHH_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["NHANVIEN"].DefaultView.RowFilter = " MANV Like'*" + txtTimKiemHH.Text + "*' " +
                "or TENNV Like'*" + txtTimKiemHH.Text + "*' " +
                "OR DIACHI Like'*" + txtTimKiemHH.Text + "*' " +
                "OR EMAIL Like'*" + txtTimKiemHH.Text + "*' ";
            dataGridViewHH.DataSource = ds.Tables["NHANVIEN"];

            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void btnFormThemHH_MouseHover(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.LimeGreen)
            {
                ((Button)sender).BackColor = Color.Lime;
            }
            if (((Button)sender).BackColor == Color.Yellow)
            {
                ((Button)sender).BackColor = Color.LightYellow;
            }
            if (((Button)sender).BackColor == Color.Red)
            {
                ((Button)sender).BackColor = Color.OrangeRed;
            }
        }

        private void btnFormThemHH_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Lime)
            {
                ((Button)sender).BackColor = Color.LimeGreen;
            }
            if (((Button)sender).BackColor == Color.LightYellow)
            {
                ((Button)sender).BackColor = Color.Yellow;
            }
            if (((Button)sender).BackColor == Color.OrangeRed)
            {
                ((Button)sender).BackColor = Color.Red;
            }
        }
        

        private void UseHorizontalLinearGradients(object sender, PaintEventArgs e)
        {
            Graphics mgraphic = e.Graphics;
            Pen pen = new Pen(Color.Red, 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.Red, Color.White, LinearGradientMode.BackwardDiagonal);
            mgraphic.FillRectangle(lgb, area);
            mgraphic.DrawRectangle(pen, area);
        }

        private void frmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            this.Owner.Show();
        }
    }
}
