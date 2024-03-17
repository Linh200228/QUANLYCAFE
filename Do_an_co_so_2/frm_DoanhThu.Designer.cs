namespace Do_an_co_so_2
{
    partial class frm_DoanhThu
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
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnThongKe = new Button();
            label1 = new Label();
            label2 = new Label();
            dgvDoanhThu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(121, 40);
            dtpTuNgay.Margin = new Padding(4);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(373, 33);
            dtpTuNgay.TabIndex = 0;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(121, 125);
            dtpDenNgay.Margin = new Padding(4);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(373, 33);
            dtpDenNgay.TabIndex = 1;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(13, 182);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(178, 76);
            btnThongKe.TabIndex = 2;
            btnThongKe.Text = "Xem";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 46);
            label1.Name = "label1";
            label1.Size = new Size(88, 26);
            label1.TabIndex = 3;
            label1.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 131);
            label2.Name = "label2";
            label2.Size = new Size(101, 26);
            label2.TabIndex = 4;
            label2.Text = "Đến ngày";
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location = new Point(501, 40);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.RowTemplate.Height = 29;
            dgvDoanhThu.Size = new Size(969, 661);
            dgvDoanhThu.TabIndex = 5;
            // 
            // frm_DoanhThu
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 713);
            Controls.Add(dgvDoanhThu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThongKe);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frm_DoanhThu";
            Text = "Doanh thu";
            Load += frm_DoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnThongKe;
        private Label label1;
        private Label label2;
        private DataGridView dgvDoanhThu;
    }
}