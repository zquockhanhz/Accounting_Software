namespace winform
{
    partial class frmKhachHang
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
            this.txtTimKiemKH = new System.Windows.Forms.TextBox();
            this.dataGridViewHH = new System.Windows.Forms.DataGridView();
            this.btnFormXoaKH = new System.Windows.Forms.Button();
            this.btnFormSuaKH = new System.Windows.Forms.Button();
            this.btnFormThemKH = new System.Windows.Forms.Button();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.Location = new System.Drawing.Point(214, 39);
            this.txtTimKiemKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.Size = new System.Drawing.Size(565, 22);
            this.txtTimKiemKH.TabIndex = 27;
            this.txtTimKiemKH.TextChanged += new System.EventHandler(this.txtTimKiemKH_TextChanged);
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
            this.dataGridViewHH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHH_CellContentClick);
            // 
            // btnFormXoaKH
            // 
            this.btnFormXoaKH.BackColor = System.Drawing.Color.Red;
            this.btnFormXoaKH.FlatAppearance.BorderSize = 0;
            this.btnFormXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormXoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormXoaKH.Location = new System.Drawing.Point(756, 406);
            this.btnFormXoaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormXoaKH.Name = "btnFormXoaKH";
            this.btnFormXoaKH.Size = new System.Drawing.Size(152, 62);
            this.btnFormXoaKH.TabIndex = 25;
            this.btnFormXoaKH.Text = "Xóa KH";
            this.btnFormXoaKH.UseVisualStyleBackColor = false;
            this.btnFormXoaKH.Click += new System.EventHandler(this.btnFormXoaNCC_Click);
            this.btnFormXoaKH.MouseLeave += new System.EventHandler(this.btnFormThemHH_MouseLeave);
            this.btnFormXoaKH.MouseHover += new System.EventHandler(this.btnFormThemHH_MouseHover);
            // 
            // btnFormSuaKH
            // 
            this.btnFormSuaKH.BackColor = System.Drawing.Color.Yellow;
            this.btnFormSuaKH.FlatAppearance.BorderSize = 0;
            this.btnFormSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormSuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormSuaKH.Location = new System.Drawing.Point(400, 406);
            this.btnFormSuaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormSuaKH.Name = "btnFormSuaKH";
            this.btnFormSuaKH.Size = new System.Drawing.Size(152, 62);
            this.btnFormSuaKH.TabIndex = 24;
            this.btnFormSuaKH.Text = "Sửa KH";
            this.btnFormSuaKH.UseVisualStyleBackColor = false;
            this.btnFormSuaKH.Click += new System.EventHandler(this.btnFormSuaNCC_Click);
            this.btnFormSuaKH.MouseLeave += new System.EventHandler(this.btnFormThemHH_MouseLeave);
            this.btnFormSuaKH.MouseHover += new System.EventHandler(this.btnFormThemHH_MouseHover);
            // 
            // btnFormThemKH
            // 
            this.btnFormThemKH.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFormThemKH.FlatAppearance.BorderSize = 0;
            this.btnFormThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormThemKH.Location = new System.Drawing.Point(56, 406);
            this.btnFormThemKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormThemKH.Name = "btnFormThemKH";
            this.btnFormThemKH.Size = new System.Drawing.Size(152, 62);
            this.btnFormThemKH.TabIndex = 23;
            this.btnFormThemKH.Text = "Thêm KH";
            this.btnFormThemKH.UseVisualStyleBackColor = false;
            this.btnFormThemKH.Click += new System.EventHandler(this.btnFormThemNCC_Click);
            this.btnFormThemKH.MouseLeave += new System.EventHandler(this.btnFormThemHH_MouseLeave);
            this.btnFormThemKH.MouseHover += new System.EventHandler(this.btnFormThemHH_MouseHover);
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Location = new System.Drawing.Point(787, 35);
            this.btnTimKiemKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(121, 31);
            this.btnTimKiemKH.TabIndex = 22;
            this.btnTimKiemKH.Text = "Tìm Kiếm:";
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Khách hàng";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiemKH);
            this.Controls.Add(this.dataGridViewHH);
            this.Controls.Add(this.btnFormXoaKH);
            this.Controls.Add(this.btnFormSuaKH);
            this.Controls.Add(this.btnFormThemKH);
            this.Controls.Add(this.btnTimKiemKH);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachHang";
            this.Text = "Khách Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKhachHang_FormClosed);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UseHorizontalLinearGradients);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiemKH;
        private System.Windows.Forms.DataGridView dataGridViewHH;
        private System.Windows.Forms.Button btnFormXoaKH;
        private System.Windows.Forms.Button btnFormSuaKH;
        private System.Windows.Forms.Button btnFormThemKH;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.Label label1;
    }
}