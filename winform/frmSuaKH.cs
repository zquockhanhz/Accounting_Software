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
    public partial class frmSuaKH : Form
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


        public frmSuaKH()
        {
            InitializeComponent();
        }


        public frmSuaKH(int vt)
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

                adapter = new SqlDataAdapter("Select * from KHACHHANG", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                ds = new DataSet();
                adapter.Fill(ds, "KHACHHANG");


                DataRow row = ds.Tables["KHACHHANG"].Rows[vts];
                txtMaKH.Text = row["MAKH"].ToString();
                txtTenKH.Text = row["TENKH"].ToString();
                dateNgaySinh.Text = row["NGAYSINH"].ToString();
                txtDiachi.Text = row["DIACHI"].ToString();
                txtSdt.Text = row["SDT"].ToString();
                txtEmail.Text = row["EMAIL"].ToString();



            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
            conn.Close();


        }



        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            if (conn.State==ConnectionState.Closed)

            {
                conn.Open();
            }
            try
            {
                DataRow row = ds.Tables["KHACHHANG"].Rows[vts];
                txtMaKH.Text = row["MAKH"].ToString();
                row.BeginEdit();

                row["MAKH"] = txtMaKH.Text;
                row["TENKH"] = txtTenKH.Text;
                row["NGAYSINH"] = dateNgaySinh.Text;
                row["DIACHI"] = txtDiachi.Text;
                row["SDT"] = txtSdt.Text;
                row["EMAIL"] = txtEmail.Text;

                row.EndEdit();
                

                int kq = adapter.Update(ds.Tables["KHACHHANG"]);
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
            catch (Exception a)
            {
                throw a;

            }
            conn.Close();
        }
    }
}
