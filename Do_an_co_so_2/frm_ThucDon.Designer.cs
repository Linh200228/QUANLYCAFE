namespace Do_an_co_so_2
{
    partial class frm_ThucDon
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
            tabPage1 = new TabPage();
            dgvMon = new DataGridView();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            btnXoaMon = new Button();
            btnCapNhatMon = new Button();
            btnThemMon = new Button();
            groupBox1 = new GroupBox();
            txtTenMon = new TextBox();
            txtMaMon = new TextBox();
            cbxDanhMuc = new ComboBox();
            nudGia = new NumericUpDown();
            label5 = new Label();
            txtTimKiem = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            dgvDanhMuc = new DataGridView();
            groupBox3 = new GroupBox();
            button1 = new Button();
            btnXoaDanhMuc = new Button();
            btnCapNhatDanhMuc = new Button();
            btnThemDanhMuc = new Button();
            groupBox4 = new GroupBox();
            txtTenDanhMuc = new TextBox();
            txtMaDanhMuc = new TextBox();
            label9 = new Label();
            label10 = new Label();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGia).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvMon);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1448, 649);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý thực đơn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvMon
            // 
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMon.Location = new Point(516, 22);
            dgvMon.Name = "dgvMon";
            dgvMon.RowHeadersWidth = 51;
            dgvMon.RowTemplate.Height = 29;
            dgvMon.Size = new Size(925, 620);
            dgvMon.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(btnXoaMon);
            groupBox2.Controls.Add(btnCapNhatMon);
            groupBox2.Controls.Add(btnThemMon);
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
            btnTimKiem.Text = "Tìm kiếm món";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoaMon
            // 
            btnXoaMon.Location = new Point(6, 128);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(240, 80);
            btnXoaMon.TabIndex = 2;
            btnXoaMon.Text = "Xóa món";
            btnXoaMon.UseVisualStyleBackColor = true;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnCapNhatMon
            // 
            btnCapNhatMon.Location = new Point(257, 32);
            btnCapNhatMon.Name = "btnCapNhatMon";
            btnCapNhatMon.Size = new Size(240, 80);
            btnCapNhatMon.TabIndex = 1;
            btnCapNhatMon.Text = "Cập nhật món";
            btnCapNhatMon.UseVisualStyleBackColor = true;
            btnCapNhatMon.Click += btnCapNhatMon_Click;
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(6, 32);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(240, 80);
            btnThemMon.TabIndex = 0;
            btnThemMon.Text = "Thêm món";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += btnThemTaiKhoan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenMon);
            groupBox1.Controls.Add(txtMaMon);
            groupBox1.Controls.Add(cbxDanhMuc);
            groupBox1.Controls.Add(nudGia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTimKiem);
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
            // txtTenMon
            // 
            txtTenMon.Location = new Point(179, 154);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(276, 33);
            txtTenMon.TabIndex = 13;
            // 
            // txtMaMon
            // 
            txtMaMon.Location = new Point(179, 101);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(276, 33);
            txtMaMon.TabIndex = 12;
            txtMaMon.TextChanged += txtMaMon_TextChanged;
            // 
            // cbxDanhMuc
            // 
            cbxDanhMuc.FormattingEnabled = true;
            cbxDanhMuc.Location = new Point(179, 218);
            cbxDanhMuc.Name = "cbxDanhMuc";
            cbxDanhMuc.Size = new Size(276, 33);
            cbxDanhMuc.TabIndex = 11;
            // 
            // nudGia
            // 
            nudGia.Location = new Point(179, 284);
            nudGia.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudGia.Name = "nudGia";
            nudGia.Size = new Size(276, 33);
            nudGia.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 286);
            label5.Name = "label5";
            label5.Size = new Size(108, 26);
            label5.TabIndex = 8;
            label5.Text = "Giá thành:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(28, 43);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(276, 33);
            txtTimKiem.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 221);
            label4.Name = "label4";
            label4.Size = new Size(114, 26);
            label4.TabIndex = 3;
            label4.Text = "Danh mục:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 157);
            label3.Name = "label3";
            label3.Size = new Size(102, 26);
            label3.TabIndex = 2;
            label3.Text = "Tên món:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 101);
            label2.Name = "label2";
            label2.Size = new Size(42, 26);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 46);
            label1.Name = "label1";
            label1.Size = new Size(102, 26);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm";
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
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvDanhMuc);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1448, 654);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh mục món";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhMuc.Location = new Point(516, 22);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.RowTemplate.Height = 29;
            dgvDanhMuc.Size = new Size(925, 620);
            dgvDanhMuc.TabIndex = 5;
            dgvDanhMuc.CellContentClick += dgvDanhMuc_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(btnXoaDanhMuc);
            groupBox3.Controls.Add(btnCapNhatDanhMuc);
            groupBox3.Controls.Add(btnThemDanhMuc);
            groupBox3.Location = new Point(7, 372);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(503, 270);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // button1
            // 
            button1.Location = new Point(257, 128);
            button1.Name = "button1";
            button1.Size = new Size(240, 80);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm tài khoản";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnXoaDanhMuc
            // 
            btnXoaDanhMuc.Location = new Point(6, 128);
            btnXoaDanhMuc.Name = "btnXoaDanhMuc";
            btnXoaDanhMuc.Size = new Size(240, 80);
            btnXoaDanhMuc.TabIndex = 2;
            btnXoaDanhMuc.Text = "Xóa danh mục";
            btnXoaDanhMuc.UseVisualStyleBackColor = true;
            btnXoaDanhMuc.Click += btnXoaDanhMuc_Click;
            // 
            // btnCapNhatDanhMuc
            // 
            btnCapNhatDanhMuc.Location = new Point(257, 32);
            btnCapNhatDanhMuc.Name = "btnCapNhatDanhMuc";
            btnCapNhatDanhMuc.Size = new Size(240, 80);
            btnCapNhatDanhMuc.TabIndex = 1;
            btnCapNhatDanhMuc.Text = "Cập nhật danh mục";
            btnCapNhatDanhMuc.UseVisualStyleBackColor = true;
            btnCapNhatDanhMuc.Click += btnCapNhatDanhMuc_Click;
            // 
            // btnThemDanhMuc
            // 
            btnThemDanhMuc.Location = new Point(6, 32);
            btnThemDanhMuc.Name = "btnThemDanhMuc";
            btnThemDanhMuc.Size = new Size(240, 80);
            btnThemDanhMuc.TabIndex = 0;
            btnThemDanhMuc.Text = "Thêm danh mục";
            btnThemDanhMuc.UseVisualStyleBackColor = true;
            btnThemDanhMuc.Click += btnThemDanhMuc_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTenDanhMuc);
            groupBox4.Controls.Add(txtMaDanhMuc);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(7, 7);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(497, 359);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // txtTenDanhMuc
            // 
            txtTenDanhMuc.Location = new Point(179, 98);
            txtTenDanhMuc.Name = "txtTenDanhMuc";
            txtTenDanhMuc.Size = new Size(276, 33);
            txtTenDanhMuc.TabIndex = 5;
            // 
            // txtMaDanhMuc
            // 
            txtMaDanhMuc.Location = new Point(179, 46);
            txtMaDanhMuc.Name = "txtMaDanhMuc";
            txtMaDanhMuc.Size = new Size(276, 33);
            txtMaDanhMuc.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 101);
            label9.Name = "label9";
            label9.Size = new Size(146, 26);
            label9.TabIndex = 1;
            label9.Text = "Tên danh mục";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 49);
            label10.Name = "label10";
            label10.Size = new Size(42, 26);
            label10.TabIndex = 0;
            label10.Text = "ID:";
            // 
            // frm_ThucDon
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 713);
            Controls.Add(tabControl1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frm_ThucDon";
            Text = "Thực đơn";
            Load += frm_ThucDon_Load;
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGia).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TabPage tabPage1;
        private DataGridView dgvMon;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private Button btnXoaMon;
        private Button btnCapNhatMon;
        private Button btnThemMon;
        private GroupBox groupBox1;
        private TextBox txtTenMon;
        private TextBox txtMaMon;
        private ComboBox cbxDanhMuc;
        private NumericUpDown nudGia;
        private Label label5;
        private TextBox txtTimKiem;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView dgvDanhMuc;
        private GroupBox groupBox3;
        private Button button1;
        private Button btnXoaDanhMuc;
        private Button btnCapNhatDanhMuc;
        private Button btnThemDanhMuc;
        private GroupBox groupBox4;
        private TextBox txtTenDanhMuc;
        private TextBox txtMaDanhMuc;
        private Label label9;
        private Label label10;
    }
}