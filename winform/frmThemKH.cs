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
using System.Globalization;

namespace winform
{
    public partial class frmThemKH : Form
    {
        private bool ketqua;

        public bool KetQua
        {
            get { return ketqua; }
            set { ketqua = value; }
        }

        public frmThemKH()
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
                adapter = new SqlDataAdapter("Select * from KHACHHANG", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                ds = new DataSet();
                adapter.Fill(ds, "KHACHHANG");



            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }

        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {


            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                DataRow row = ds.Tables["KHACHHANG"].NewRow();
                row["MAKH"] = txtMaKH.Text;
                row["TENKH"] = txtTenKH.Text;
                row["NGAYSINH"] = dateNgaySinh.Text;
                row["DIACHI"] = txtDiachi.Text;
                row["SDT"] = txtSdt.Text;
                row["EMAIL"] = txtEmail.Text;

                ds.Tables["KHACHHANG"].Rows.Add(row);

                int kq = adapter.Update(ds.Tables["KHACHHANG"]);
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
