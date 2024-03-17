namespace Do_an_co_so_2
{
    partial class frm_BanHang
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
            groupBox3 = new GroupBox();
            button2 = new Button();
            buttonTaiBan = new Button();
            groupBox4 = new GroupBox();
            cbxChuyenBan = new ComboBox();
            label1 = new Label();
            txtTongHoaDon = new TextBox();
            buttonChuyenBan = new Button();
            buttonThanhToan = new Button();
            groupBox5 = new GroupBox();
            nudGiamGia = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            btnThemMon = new Button();
            cbMonAn = new ComboBox();
            cbDanhMucMonAn = new ComboBox();
            txtHienThiTenBan = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lsvHoaDon = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label2 = new Label();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGiamGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(buttonTaiBan);
            groupBox3.Location = new Point(11, 25);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(377, 130);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hình thức";
            // 
            // button2
            // 
            button2.Location = new Point(200, 32);
            button2.Name = "button2";
            button2.Size = new Size(171, 79);
            button2.TabIndex = 1;
            button2.Text = "Đem về";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonTaiBan
            // 
            buttonTaiBan.Location = new Point(6, 32);
            buttonTaiBan.Name = "buttonTaiBan";
            buttonTaiBan.Size = new Size(171, 79);
            buttonTaiBan.TabIndex = 0;
            buttonTaiBan.Text = "Tại Bàn";
            buttonTaiBan.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(cbxChuyenBan);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(txtTongHoaDon);
            groupBox4.Controls.Add(buttonChuyenBan);
            groupBox4.Controls.Add(buttonThanhToan);
            groupBox4.Location = new Point(416, 564);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(697, 125);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Điều khiển";
            // 
            // cbxChuyenBan
            // 
            cbxChuyenBan.FormattingEnabled = true;
            cbxChuyenBan.Location = new Point(6, 78);
            cbxChuyenBan.Name = "cbxChuyenBan";
            cbxChuyenBan.Size = new Size(151, 33);
            cbxChuyenBan.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 32);
            label1.Name = "label1";
            label1.Size = new Size(143, 26);
            label1.TabIndex = 6;
            label1.Text = "Tổng hóa đơn";
            // 
            // txtTongHoaDon
            // 
            txtTongHoaDon.Location = new Point(360, 78);
            txtTongHoaDon.Name = "txtTongHoaDon";
            txtTongHoaDon.Size = new Size(160, 33);
            txtTongHoaDon.TabIndex = 5;
            txtTongHoaDon.TextChanged += txtTongHoaDon_TextChanged;
            // 
            // buttonChuyenBan
            // 
            buttonChuyenBan.Location = new Point(174, 32);
            buttonChuyenBan.Name = "buttonChuyenBan";
            buttonChuyenBan.Size = new Size(171, 79);
            buttonChuyenBan.TabIndex = 3;
            buttonChuyenBan.Text = "Chuyển bàn";
            buttonChuyenBan.UseVisualStyleBackColor = true;
            buttonChuyenBan.Click += buttonChuyenBan_Click;
            // 
            // buttonThanhToan
            // 
            buttonThanhToan.Location = new Point(526, 32);
            buttonThanhToan.Name = "buttonThanhToan";
            buttonThanhToan.Size = new Size(171, 79);
            buttonThanhToan.TabIndex = 2;
            buttonThanhToan.Text = "Thanh toán";
            buttonThanhToan.UseVisualStyleBackColor = true;
            buttonThanhToan.Click += buttonThanhToan_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(nudGiamGia);
            groupBox5.Controls.Add(numericUpDown1);
            groupBox5.Controls.Add(btnThemMon);
            groupBox5.Controls.Add(cbMonAn);
            groupBox5.Controls.Add(cbDanhMucMonAn);
            groupBox5.Location = new Point(1119, 30);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(350, 659);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Đặt món";
            // 
            // nudGiamGia
            // 
            nudGiamGia.Location = new Point(6, 197);
            nudGiamGia.Name = "nudGiamGia";
            nudGiamGia.Size = new Size(150, 33);
            nudGiamGia.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(183, 112);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 33);
            numericUpDown1.TabIndex = 8;
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(6, 112);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(171, 79);
            btnThemMon.TabIndex = 7;
            btnThemMon.Text = "Thêm món";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // cbMonAn
            // 
            cbMonAn.FormattingEnabled = true;
            cbMonAn.Location = new Point(6, 73);
            cbMonAn.Name = "cbMonAn";
            cbMonAn.Size = new Size(338, 33);
            cbMonAn.TabIndex = 1;
            cbMonAn.SelectedIndexChanged += cbMonAn_SelectedIndexChanged;
            // 
            // cbDanhMucMonAn
            // 
            cbDanhMucMonAn.FormattingEnabled = true;
            cbDanhMucMonAn.Location = new Point(6, 32);
            cbDanhMucMonAn.Name = "cbDanhMucMonAn";
            cbDanhMucMonAn.Size = new Size(338, 33);
            cbDanhMucMonAn.TabIndex = 0;
            cbDanhMucMonAn.SelectedIndexChanged += cbDanhMucMonAn_SelectedIndexChanged;
            // 
            // txtHienThiTenBan
            // 
            txtHienThiTenBan.Location = new Point(400, 30);
            txtHienThiTenBan.Name = "txtHienThiTenBan";
            txtHienThiTenBan.Size = new Size(713, 33);
            txtHienThiTenBan.TabIndex = 6;
            txtHienThiTenBan.TextAlign = HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(11, 161);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(399, 528);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lsvHoaDon
            // 
            lsvHoaDon.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvHoaDon.GridLines = true;
            lsvHoaDon.Location = new Point(416, 69);
            lsvHoaDon.Name = "lsvHoaDon";
            lsvHoaDon.Size = new Size(697, 489);
            lsvHoaDon.TabIndex = 7;
            lsvHoaDon.UseCompatibleStateImageBehavior = false;
            lsvHoaDon.View = View.Details;
            lsvHoaDon.SelectedIndexChanged += lsvHoaDon_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ten mon";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "so luong";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Don gia";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thanh tien";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(103, 26);
            label2.TabIndex = 11;
            label2.Text = "Chọn bàn";
            // 
            // frm_BanHang
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 713);
            Controls.Add(lsvHoaDon);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtHienThiTenBan);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frm_BanHang";
            Text = "Màn hình quản lý bán cafe";
            Load += FormMain_Load;
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudGiamGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox3;
        private Button button2;
        private Button buttonTaiBan;
        private GroupBox groupBox4;
        private Button buttonChuyenBan;
        private Button buttonThanhToan;
        private GroupBox groupBox5;
        private ComboBox cbDanhMucMonAn;
        private TextBox txtHienThiTenBan;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView lsvHoaDon;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private TextBox txtTongHoaDon;
        private ComboBox cbMonAn;
        private Button btnThemMon;
        private NumericUpDown numericUpDown1;
        private NumericUpDown nudGiamGia;
        private ComboBox cbxChuyenBan;
        private Label label2;
    }
}