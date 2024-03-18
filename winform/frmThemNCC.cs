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
    public partial class frmThemNCC : Form
    {
        private bool ketqua;

        public bool KetQua
        {
            get { return ketqua; }
            set { ketqua = value; }
        }

        public frmThemNCC()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-EB3G68E\\SQLEXPRESS;" +
                            " Initial Catalog=QLBH;" +
                            "Integrated Security = True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void frmThemNCC_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            try
            {
                if (conn == null)
                    conn = new SqlConnection(strConn);
                adapter = new SqlDataAdapter("Select * from NHACUNGCAP", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                ds = new DataSet();
                adapter.Fill(ds, "NHACUNGCAP");



            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                DataRow row = ds.Tables["NHACUNGCAP"].NewRow();
                row["MANCC"] = txtMaNCC.Text;
                row["TENNCC"] = txtTenNCC.Text;
                row["DIACHI"] = txtDiaChiNCC.Text;
                row["SDT"] = txtSdtNCC.Text;

                ds.Tables["NHACUNGCAP"].Rows.Add(row);

                int kq = adapter.Update(ds.Tables["NHACUNGCAP"]);
                if (kq > 0)
                {
                    KetQua = true;

                    this.Close();
                }
            }
            catch (Exception a)
            {
                
                throw a;
            }
        }
    }
}
