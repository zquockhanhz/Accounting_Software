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
    public partial class frmThemNV : Form
    {
        private bool ketqua;

        public bool KetQua
        {
            get { return ketqua; }
            set { ketqua = value; }
        }
        
        public frmThemNV()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-EB3G68E\\SQLEXPRESS;" +
                            " Initial Catalog=QLBH;" +
                            "Integrated Security = True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void frmThemHH_Load(object sender, EventArgs e)
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

                

            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
            
        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            

            if (conn != null&& conn.State== ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                DataRow row = ds.Tables["NHANVIEN"].NewRow();
                row["MANV"] = txtMaHH.Text;
                row["TENNV"] = txtTenHH.Text;
                row["NGAYSINH"] = dateNgaySinh.Text;
                row["DIACHI"] = txtMaNCC.Text;
                row["SDT"] = txtSoLuongHH.Text;
                row["EMAIL"] = txtDonGiaHH.Text;

                ds.Tables["NHANVIEN"].Rows.Add(row);

                int kq = adapter.Update(ds.Tables["NHANVIEN"]);
                if (kq > 0)
                {
                    KetQua = true;
                    
                    this.Close();
                }
            }
            catch (Exception a)
            {
                conn.Close();
                MessageBox.Show(a.ToString());
            }
            
            
        }
    }
}
