namespace Do_an_co_so_2
{
    partial class frm_NhanSu
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvNhanVien = new DataGridView();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnCapNhatTaiKhoan = new Button();
            btnThemTaiKhoan = new Button();
            groupBox1 = new GroupBox();
            txtChucVu = new TextBox();
            label5 = new Label();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtHoTen = new TextBox();
            txtTimKiemTaiKhoan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(13, 13);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1456, 687);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvNhanVien);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1448, 649);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý tài khoản";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(510, 20);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(931, 622);
            dgvNhanVien.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnCapNhatTaiKhoan);
            groupBox2.Controls.Add(btnThemTaiKhoan);
            groupBox2.Location = new Point(7, 372);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 270);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(257, 128);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(240, 80);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm tài khoản";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(6, 128);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(240, 80);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa tài khoản";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhatTaiKhoan
            // 
            btnCapNhatTaiKhoan.Location = new Point(257, 32);
            btnCapNhatTaiKhoan.Name = "btnCapNhatTaiKhoan";
            btnCapNhatTaiKhoan.Size = new Size(240, 80);
            btnCapNhatTaiKhoan.TabIndex = 1;
            btnCapNhatTaiKhoan.Text = "Cập nhật tài khoản";
            btnCapNhatTaiKhoan.UseVisualStyleBackColor = true;
            btnCapNhatTaiKhoan.Click += btnCapNhatTaiKhoan_Click;
            // 
            // btnThemTaiKhoan
            // 
            btnThemTaiKhoan.Location = new Point(6, 32);
            btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            btnThemTaiKhoan.Size = new Size(240, 80);
            btnThemTaiKhoan.TabIndex = 0;
            btnThemTaiKhoan.Text = "Thêm tài khoản";
            btnThemTaiKhoan.UseVisualStyleBackColor = true;
            btnThemTaiKhoan.Click += btnThemTaiKhoan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChucVu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtTimKiemTaiKhoan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 359);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(179, 218);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(276, 33);
            txtChucVu.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 286);
            label5.Name = "label5";
            label5.Size = new Size(99, 26);
            label5.TabIndex = 8;
            label5.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(179, 283);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(276, 33);
            txtMatKhau.TabIndex = 7;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(179, 154);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(276, 33);
            txtTenDangNhap.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(179, 98);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(276, 33);
            txtHoTen.TabIndex = 5;
            // 
            // txtTimKiemTaiKhoan
            // 
            txtTimKiemTaiKhoan.Location = new Point(179, 46);
            txtTimKiemTaiKhoan.Name = "txtTimKiemTaiKhoan";
            txtTimKiemTaiKhoan.Size = new Size(276, 33);
            txtTimKiemTaiKhoan.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 221);
            label4.Name = "label4";
            label4.Size = new Size(91, 26);
            label4.TabIndex = 3;
            label4.Text = "Chức vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 157);
            label3.Name = "label3";
            label3.Size = new Size(151, 26);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 101);
            label2.Name = "label2";
            label2.Size = new Size(101, 26);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 49);
            label1.Name = "label1";
            label1.Size = new Size(68, 26);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1448, 654);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frm_NhanSu
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 713);
            Controls.Add(tabControl1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frm_NhanSu";
            Text = "frm_NhanSu";
            Load += frm_NhanSu_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnCapNhatTaiKhoan;
        private Button btnThemTaiKhoan;
        private TextBox txtChucVu;
        private Label label5;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtHoTen;
        private TextBox txtTimKiemTaiKhoan;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvNhanVien;
    }
}