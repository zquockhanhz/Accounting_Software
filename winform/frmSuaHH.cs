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
    public partial class frmSuaHH : Form
    {
        private bool ketqua;

        
        public bool KetQua
        {
            get { return ketqua; }
            set { ketqua = value; }
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-EB3G68E\\SQLEXPRESS;" +
                            " Initial Catalog=QLBH;" +
                            "Integrated Security = True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        int vts;


        public frmSuaHH()
        {
            InitializeComponent();
        }


        public frmSuaHH(int vt)
        {
            InitializeComponent();
            vts = vt;
        }


        private void frmSuaHH_Load(object sender, EventArgs e)
        {

            CenterToScreen();
            try
            {
                if (conn == null)
                    conn = new SqlConnection(strConn);

                adapter = new SqlDataAdapter("Select * from HANGHOA", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                ds = new DataSet();
                adapter.Fill(ds, "HANGHOA");
                DataRow row = ds.Tables["HANGHOA"].Rows[vts];
                txtMaHH.Text= row["MAHH"].ToString();
                txtTenHH.Text = row["TENHH"].ToString();
                txtLoaiHH.Text = row["LOAIHH"].ToString();
                txtMaNCC.Text = row["MANCC"].ToString();
                txtDonGiaHH.Text = row["DONGIA"].ToString();
                txtSoLuongHH.Text = row["SOLUONG"].ToString();
                txtDvtHH.Text = row["DONVITINH"].ToString();
                

            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
            conn.Close();

            
        }



        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = ds.Tables["HANGHOA"].Rows[vts];
                txtMaHH.Text = row["MAHH"].ToString();
                row.BeginEdit();

                row["MAHH"] = txtMaHH.Text;
                row["TENHH"] = txtTenHH.Text;
                row["LOAIHH"] = txtLoaiHH.Text;
                row["MANCC"] = txtMaNCC.Text;
                row["SOLUONG"] = txtSoLuongHH.Text;
                row["DONGIA"] = txtDonGiaHH.Text;
                row["DONVITINH"] = txtDvtHH.Text;

                row.EndEdit();

                int kq = adapter.Update(ds.Tables["HANGHOA"]);
                if (kq > 0)
                {
                    KetQua = true;
                    conn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo");

            }
            conn.Close();
        }
    }
}
