namespace Qlks
{
    partial class timkh
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
            this.bt_tk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_ct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_tk
            // 
            this.bt_tk.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_tk.Location = new System.Drawing.Point(661, 66);
            this.bt_tk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(127, 39);
            this.bt_tk.TabIndex = 0;
            this.bt_tk.Text = "Tìm Kiếm";
            this.bt_tk.UseVisualStyleBackColor = false;
            this.bt_tk.Click += new System.EventHandler(this.bt_tk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập";
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(311, 75);
            this.txt_tk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(321, 22);
            this.txt_tk.TabIndex = 2;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.Tenkh,
            this.Socm,
            this.Namsinh,
            this.Ngaydp,
            this.Ngaytp});
            this.dg.Location = new System.Drawing.Point(-3, 122);
            this.dg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.Size = new System.Drawing.Size(1045, 254);
            this.dg.TabIndex = 3;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            this.dg.Click += new System.EventHandler(this.dg_Click);
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "MaPhong";
            this.Maphong.HeaderText = "Mã Phòng";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            this.Maphong.Width = 125;
            // 
            // Tenkh
            // 
            this.Tenkh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenkh.DataPropertyName = "TenKh";
            this.Tenkh.HeaderText = "Tên Khách Hàng";
            this.Tenkh.MinimumWidth = 6;
            this.Tenkh.Name = "Tenkh";
            // 
            // Socm
            // 
            this.Socm.DataPropertyName = "SoCm";
            this.Socm.HeaderText = "Số Cmnd";
            this.Socm.MinimumWidth = 6;
            this.Socm.Name = "Socm";
            this.Socm.Width = 125;
            // 
            // Namsinh
            // 
            this.Namsinh.DataPropertyName = "NamSinh";
            this.Namsinh.HeaderText = "Năm Sinh";
            this.Namsinh.MinimumWidth = 6;
            this.Namsinh.Name = "Namsinh";
            this.Namsinh.Width = 125;
            // 
            // Ngaydp
            // 
            this.Ngaydp.DataPropertyName = "NgayDp";
            this.Ngaydp.HeaderText = "Ngày Đặt Phòng";
            this.Ngaydp.MinimumWidth = 6;
            this.Ngaydp.Name = "Ngaydp";
            this.Ngaydp.Width = 125;
            // 
            // Ngaytp
            // 
            this.Ngaytp.DataPropertyName = "NgayTp";
            this.Ngaytp.HeaderText = "Ngày Trả Phòng";
            this.Ngaytp.MinimumWidth = 6;
            this.Ngaytp.Name = "Ngaytp";
            this.Ngaytp.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(341, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm Kiếm Khách Đặt Phòng";
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_xoa.Location = new System.Drawing.Point(796, 66);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(100, 39);
            this.bt_xoa.TabIndex = 0;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(88, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "(Họ Tên, Năm sinh, Sô cmnd..)";
            // 
            // bt_ct
            // 
//            this.bt_ct.BackColor = System.Drawing.Color.DarkCyan;
//            this.bt_ct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.bt_ct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.bt_ct.Location = new System.Drawing.Point(904, 66);
//            this.bt_ct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.bt_ct.Name = "bt_ct";
//            this.bt_ct.Size = new System.Drawing.Size(100, 39);
//            this.bt_ct.TabIndex = 0;
//            this.bt_ct.Text = "Chi Tiết";
//            this.bt_ct.UseVisualStyleBackColor = false;
//            this.bt_ct.Click += new System.EventHandler(this.bt_ct_Click);
            // 
            // timkh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 361);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ct);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_tk);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1054, 408);
            this.MinimumSize = new System.Drawing.Size(1054, 408);
            this.Name = "timkh";
            this.Text = "timkh";
            this.Load += new System.EventHandler(this.timkh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_ct;
    }
}