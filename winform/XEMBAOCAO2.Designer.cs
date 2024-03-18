namespace winform
{
    partial class XEMBAOCAO2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DATASET2 = new winform.DATASET2();
            this.TINHTRANGBANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DATASET2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TINHTRANGBANHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TINHTRANGBANHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "winform.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1051, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // DATASET2
            // 
            this.DATASET2.DataSetName = "DATASET2";
            this.DATASET2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TINHTRANGBANHANGBindingSource
            // 
            this.TINHTRANGBANHANGBindingSource.DataMember = "TINHTRANGBANHANG";
            this.TINHTRANGBANHANGBindingSource.DataSource = this.DATASET2;
            // 
            // XEMBAOCAO2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 540);
            this.Controls.Add(this.reportViewer1);
            this.Name = "XEMBAOCAO2";
            this.Text = "XEMBAOCAO2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XEMBAOCAO2_FormClosed);
            this.Load += new System.EventHandler(this.XEMBAOCAO2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATASET2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TINHTRANGBANHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TINHTRANGBANHANGBindingSource;
        private DATASET2 DATASET2;
    }
}