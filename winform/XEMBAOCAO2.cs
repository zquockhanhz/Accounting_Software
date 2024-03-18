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
using Microsoft.Reporting.WinForms;

namespace winform
{
    public partial class XEMBAOCAO2 : Form
    {
        public XEMBAOCAO2()
        {
            InitializeComponent();
        }

        private void XEMBAOCAO2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
 ("Data Source=DESKTOP-EB3G68E\\SQLEXPRESS;" +
                             " Initial Catalog=QLBH;" +
                             "Integrated Security = True");
            SqlDataAdapter adapter =
               new SqlDataAdapter("select HANGHOA.MAHH, HANGHOA.TENHH, ISNULL(sum(CHITIETHOADON.SOLUONG),0)AS SOLUONGBAN   from HANGHOA left join CHITIETHOADON on HANGHOA.MAHH=CHITIETHOADON.MAHH group by HANGHOA.MAHH, HANGHOA.TENHH", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "SanPham");

            this.reportViewer1.LocalReport.ReportEmbeddedResource =
                "winform.Report2.rdlc";

            ReportDataSource rds = new ReportDataSource();

            rds.Name = "DATASET2";
            rds.Value = ds.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(rds);
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            this.reportViewer1.RefreshReport();

            
        }

        private void XEMBAOCAO2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Owner.Show();
        }
    }
}
