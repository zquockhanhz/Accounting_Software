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
    public partial class frmSuaNV : Form
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


        public frmSuaNV()
        {
            InitializeComponent();
        }


        public frmSuaNV(int vt)
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

                adapter = new SqlDataAdapter("Select * from NHANVIEN", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                ds = new DataSet();
                adapter.Fill(ds, "NHANVIEN");
                DataRow row = ds.Tables["NHANVIEN"].Rows[vts];
                txtMaHH.Text=row["MANV"].ToString();
                txtTenHH.Text = row["TENNV"].ToString();
                dateNgaySinh.Text = row["NGAYSINH"].ToString();
                txtMaNCC.Text = row["DIACHI"].ToString();
                txtSoLuongHH.Text = row["SDT"].ToString();
                txtDonGiaHH.Text = row["EMAIL"].ToString();
                


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
                DataRow row = ds.Tables["NHANVIEN"].Rows[vts];
                txtMaHH.Text = row["MANV"].ToString();
                row.BeginEdit();

                row["MANV"] = txtMaHH.Text;
                row["TENNV"] = txtTenHH.Text;
                row["NGAYSINH"] = dateNgaySinh.Text;
                row["DIACHI"] = txtMaNCC.Text;
                row["SDT"] = txtSoLuongHH.Text;
                row["EMAIL"] = txtDonGiaHH.Text;
                

                row.EndEdit();

                int kq = adapter.Update(ds.Tables["NHANVIEN"]);
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
