namespace winform
{
    partial class frmNhanVien
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
            this.txtTimKiemHH = new System.Windows.Forms.TextBox();
            this.dataGridViewHH = new System.Windows.Forms.DataGridView();
            this.btnFormXoaHH = new System.Windows.Forms.Button();
            this.btnFormSuaHH = new System.Windows.Forms.Button();
            this.btnFormThemHH = new System.Windows.Forms.Button();
            this.btnTimKiemHH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiemHH
            // 
            this.txtTimKiemHH.Location = new System.Drawing.Point(214, 39);
            this.txtTimKiemHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemHH.Name = "txtTimKiemHH";
            this.txtTimKiemHH.Size = new System.Drawing.Size(565, 22);
            this.txtTimKiemHH.TabIndex = 27;
            this.txtTimKiemHH.TextChanged += new System.EventHandler(this.txtTimKiemHH_TextChanged);
            // 
            // dataGridViewHH
            // 
            this.dataGridViewHH.AllowUserToAddRows = false;
            this.dataGridViewHH.AllowUserToDeleteRows = false;
            this.dataGridViewHH.AllowUserToResizeRows = false;
            this.dataGridViewHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHH.Location = new System.Drawing.Point(56, 93);
            this.dataGridViewHH.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHH.Name = "dataGridViewHH";
            this.dataGridViewHH.Size = new System.Drawing.Size(852, 305);
            this.dataGridViewHH.TabIndex = 26;
            this.dataGridViewHH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHH_CellClick);
            // 
            // btnFormXoaHH
            // 
            this.btnFormXoaHH.BackColor = System.Drawing.Color.Red;
            this.btnFormXoaHH.FlatAppearance.BorderSize = 0;
            this.btnFormXoaHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormXoaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormXoaHH.Location = new System.Drawing.Point(756, 406);
            this.btnFormXoaHH.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormXoaHH.Name = "btnFormXoaHH";
            this.btnFormXoaHH.Size = new System.Drawing.Size(152, 62);
            this.btnFormXoaHH.TabIndex = 25;
            this.btnFormXoaHH.Text = "Xóa NV";
            this.btnFormXoaHH.UseVisualStyleBackColor = false;
            this.btnFormXoaHH.Click += new System.EventHandler(this.btnFormXoaNCC_Click);
            this.btnFormXoaHH.MouseLeave += new System.EventHandler(this.btnFormThemHH_MouseLeave);
            this.btnFormXoaHH.MouseHover += new System.EventHandler(this.btnFormThemHH_MouseHover);
            // 
            // btnFormSuaHH
            // 
            this.btnFormSuaHH.BackColor = System.Drawing.Color.Yellow;
            this.btnFormSuaHH.FlatAppearance.BorderSize = 0;
            this.btnFormSuaHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormSuaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormSuaHH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFormSuaHH.Location = new System.Drawing.Point(400, 406);
            this.btnFormSuaHH.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormSuaHH.Name = "btnFormSuaHH";
            this.btnFormSuaHH.Size = new System.Drawing.Size(152, 62);
            this.btnFormSuaHH.TabIndex = 24;
            this.btnFormSuaHH.Text = "Sửa NV";
            this.btnFormSuaHH.UseVisualStyleBackColor = false;
            this.btnFormSuaHH.Click += new System.EventHandler(this.btnFormSuaNCC_Click);
            this.btnFormSuaHH.MouseLeave += new System.EventHandler(this.btnFormThemHH_MouseLeave);
            this.btnFormSuaHH.MouseHover += new System.EventHandler(this.btnFormThemHH_MouseHover);
            // 
            // btnFormThemHH
            // 
            this.btnFormThemHH.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFormThemHH.FlatAppearance.BorderSize = 0;
            this.btnFormThemHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormThemHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormThemHH.Location = new System.Drawing.Point(56, 406);
            this.btnFormThemHH.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormThemHH.Name = "btnFormThemHH";
            this.btnFormThemHH.Size = new System.Drawing.Size(152, 62);
            this.btnFormThemHH.TabIndex = 23;
            this.btnFormThemHH.Text = "Thêm NV";
            this.btnFormThemHH.UseVisualStyleBackColor = false;
            this.btnFormThemHH.Click += new System.EventHandler(this.btnFormThemNCC_Click);
            this.btnFormThemHH.MouseLeave += new System.EventHandler(this.btnFormThemHH_MouseLeave);
            this.btnFormThemHH.MouseHover += new System.EventHandler(this.btnFormThemHH_MouseHover);
            // 
            // btnTimKiemHH
            // 
            this.btnTimKiemHH.Location = new System.Drawing.Point(787, 35);
            this.btnTimKiemHH.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemHH.Name = "btnTimKiemHH";
            this.btnTimKiemHH.Size = new System.Drawing.Size(121, 31);
            this.btnTimKiemHH.TabIndex = 22;
            this.btnTimKiemHH.Text = "Tìm Kiếm:";
            this.btnTimKiemHH.UseVisualStyleBackColor = true;
            this.btnTimKiemHH.Click += new System.EventHandler(this.btnTimKiemHH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nhân viên";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(983, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiemHH);
            this.Controls.Add(this.dataGridViewHH);
            this.Controls.Add(this.btnFormXoaHH);
            this.Controls.Add(this.btnFormSuaHH);
            this.Controls.Add(this.btnFormThemHH);
            this.Controls.Add(this.btnTimKiemHH);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNhanVien_FormClosed);
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UseHorizontalLinearGradients);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiemHH;
        private System.Windows.Forms.DataGridView dataGridViewHH;
        private System.Windows.Forms.Button btnFormXoaHH;
        private System.Windows.Forms.Button btnFormSuaHH;
        private System.Windows.Forms.Button btnFormThemHH;
        private System.Windows.Forms.Button btnTimKiemHH;
        private System.Windows.Forms.Label label1;
    }
}