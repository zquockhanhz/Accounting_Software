namespace winform
{
    partial class frmNhaCungCap
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
            this.txtTimKiemNCC = new System.Windows.Forms.TextBox();
            this.dataGridViewNCC = new System.Windows.Forms.DataGridView();
            this.btnFormXoaNCC = new System.Windows.Forms.Button();
            this.btnFormSuaNCC = new System.Windows.Forms.Button();
            this.btnFormThemNCC = new System.Windows.Forms.Button();
            this.btnTimKiemNCC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiemNCC
            // 
            this.txtTimKiemNCC.Location = new System.Drawing.Point(213, 39);
            this.txtTimKiemNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemNCC.Name = "txtTimKiemNCC";
            this.txtTimKiemNCC.Size = new System.Drawing.Size(565, 22);
            this.txtTimKiemNCC.TabIndex = 0;
            this.txtTimKiemNCC.TextChanged += new System.EventHandler(this.txtTimKiemNCC_TextChanged);
            // 
            // dataGridViewNCC
            // 
            this.dataGridViewNCC.AllowUserToAddRows = false;
            this.dataGridViewNCC.AllowUserToDeleteRows = false;
            this.dataGridViewNCC.AllowUserToResizeRows = false;
            this.dataGridViewNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNCC.Location = new System.Drawing.Point(56, 94);
            this.dataGridViewNCC.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNCC.Name = "dataGridViewNCC";
            this.dataGridViewNCC.Size = new System.Drawing.Size(852, 305);
            this.dataGridViewNCC.TabIndex = 5;
            this.dataGridViewNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNCC_CellClick);
            // 
            // btnFormXoaNCC
            // 
            this.btnFormXoaNCC.BackColor = System.Drawing.Color.Red;
            this.btnFormXoaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormXoaNCC.Location = new System.Drawing.Point(756, 406);
            this.btnFormXoaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormXoaNCC.Name = "btnFormXoaNCC";
            this.btnFormXoaNCC.Size = new System.Drawing.Size(152, 62);
            this.btnFormXoaNCC.TabIndex = 4;
            this.btnFormXoaNCC.Text = "Xóa NCC";
            this.btnFormXoaNCC.UseVisualStyleBackColor = false;
            this.btnFormXoaNCC.Click += new System.EventHandler(this.btnFormXoaNCC_Click);
            this.btnFormXoaNCC.MouseLeave += new System.EventHandler(this.btnFormThemHH_MouseLeave);
            this.btnFormXoaNCC.MouseHover += new System.EventHandler(this.btnFormThemHH_MouseHover);
            // 
            // btnFormSuaNCC
            // 
            this.btnFormSuaNCC.BackColor = System.Drawing.Color.Yellow;
            this.btnFormSuaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormSuaNCC.Location = new System.Drawing.Point(400, 406);
            this.btnFormSuaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormSuaNCC.Name = "btnFormSuaNCC";
            this.btnFormSuaNCC.Size = new System.Drawing.Size(152, 62);
            this.btnFormSuaNCC.TabIndex = 3;
            this.btnFormSuaNCC.Text = "Sửa NCC";
            this.btnFormSuaNCC.UseVisualStyleBackColor = false;
            this.btnFormSuaNCC.Click += new System.EventHandler(this.btnFormSuaNCC_Click);
            this.btnFormSuaNCC.MouseLeave += new System.EventHandler(this.btnFormThemHH_MouseLeave);
            this.btnFormSuaNCC.MouseHover += new System.EventHandler(this.btnFormThemHH_MouseHover);
            // 
            // btnFormThemNCC
            // 
            this.btnFormThemNCC.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFormThemNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormThemNCC.Location = new System.Drawing.Point(56, 406);
            this.btnFormThemNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormThemNCC.Name = "btnFormThemNCC";
            this.btnFormThemNCC.Size = new System.Drawing.Size(152, 62);
            this.btnFormThemNCC.TabIndex = 2;
            this.btnFormThemNCC.Text = "Thêm NCC";
            this.btnFormThemNCC.UseVisualStyleBackColor = false;
            this.btnFormThemNCC.Click += new System.EventHandler(this.btnFormThemNCC_Click);
            this.btnFormThemNCC.MouseLeave += new System.EventHandler(this.btnFormThemHH_MouseLeave);
            this.btnFormThemNCC.MouseHover += new System.EventHandler(this.btnFormThemHH_MouseHover);
            // 
            // btnTimKiemNCC
            // 
            this.btnTimKiemNCC.Location = new System.Drawing.Point(787, 34);
            this.btnTimKiemNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemNCC.Name = "btnTimKiemNCC";
            this.btnTimKiemNCC.Size = new System.Drawing.Size(121, 31);
            this.btnTimKiemNCC.TabIndex = 1;
            this.btnTimKiemNCC.Text = "Tìm Kiếm:";
            this.btnTimKiemNCC.UseVisualStyleBackColor = true;
            this.btnTimKiemNCC.Click += new System.EventHandler(this.btnTimKiemNCC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhà cung cấp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiemNCC);
            this.Controls.Add(this.dataGridViewNCC);
            this.Controls.Add(this.btnFormXoaNCC);
            this.Controls.Add(this.btnFormSuaNCC);
            this.Controls.Add(this.btnFormThemNCC);
            this.Controls.Add(this.btnTimKiemNCC);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhaCungCap";
            this.Text = "Nhà Cung Cấp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNhaCungCap_FormClosed);
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UseHorizontalLinearGradients);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiemNCC;
        private System.Windows.Forms.DataGridView dataGridViewNCC;
        private System.Windows.Forms.Button btnFormXoaNCC;
        private System.Windows.Forms.Button btnFormSuaNCC;
        private System.Windows.Forms.Button btnFormThemNCC;
        private System.Windows.Forms.Button btnTimKiemNCC;
        private System.Windows.Forms.Label label1;
    }
}