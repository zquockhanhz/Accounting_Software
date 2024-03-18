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
    public partial class frmSuaNCC : Form
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


        public frmSuaNCC()
        {
            InitializeComponent();
        }


        public frmSuaNCC(int vt)
        {
            InitializeComponent();
            vts = vt;
        }

        private void frmSuaNCC_Load(object sender, EventArgs e)
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
                DataRow row = ds.Tables["NHACUNGCAP"].Rows[vts];
                txtMaNCC.Text = row["MANCC"].ToString();
                txtTenNCC.Text = row["TENNCC"].ToString();
                txtDiaChiNCC.Text = row["DIACHI"].ToString();
                txtSdtNCC.Text = row["SDT"].ToString();


            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
            conn.Close();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = ds.Tables["NHACUNGCAP"].Rows[vts];
                txtMaNCC.Text = row["MANCC"].ToString();
                row.BeginEdit();

                row["MANCC"] = txtMaNCC.Text;
                row["TENNCC"] = txtTenNCC.Text;
                row["DIACHI"] = txtDiaChiNCC.Text;
                row["SDT"] = txtSdtNCC.Text;

                row.EndEdit();

                int kq = adapter.Update(ds.Tables["NHACUNGCAP"]);
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
