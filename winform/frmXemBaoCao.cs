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
    public partial class frmXemBaoCao : Form
    {
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
("Data Source=DESKTOP-EB3G68E\\SQLEXPRESS;" +
                            " Initial Catalog=QLBH;" +
                            "Integrated Security = True");
            SqlDataAdapter adapter =
               new SqlDataAdapter("select KHACHHANG.MAKH,KHACHHANG.TENKH,TIENCANTRA.SOTIENCANTRA,SUM(PHIEUTHU.Sotientra)AS SOTIENTRA ,(SOTIENCANTRA-SUM(PHIEUTHU.Sotientra)) as CONGNO from KHACHHANG INNER JOIN  (SELECT KHACHHANG.MAKH, SUM(TONGTIENHOADON) AS SOTIENCANTRA FROM KHACHHANG RIGHT JOIN HOADON ON HOADON.MAKH=KHACHHANG.MAKH  INNER JOIN  (SELECT MAHD,SUM((CHITIETHOADON.SOLUONG*HANGHOA.DONGIA))  AS TONGTIENHOADON FROM CHITIETHOADON INNER JOIN HANGHOA ON CHITIETHOADON.MAHH=HANGHOA.MAHH GROUP BY MAHD)  AS TABLESUMMONEY ON TABLESUMMONEY.MAHD=HOADON.MAHD GROUP BY KHACHHANG.MAKH) AS TIENCANTRA ON TIENCANTRA.MAKH=KHACHHANG.MAKH RIGHT JOIN PHIEUTHU ON KHACHHANG.MAKH=PHIEUTHU.MAKH GROUP BY KHACHHANG.MAKH,KHACHHANG.TENKH,SOTIENCANTRA", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "SanPham");

            this.reportViewer1.LocalReport.ReportEmbeddedResource =
                "winform.Report1.rdlc";

            ReportDataSource rds = new ReportDataSource();

            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(rds);
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            this.reportViewer1.RefreshReport();
        }

        private void frmXemBaoCao_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Owner.Show();
        }
    }
}
