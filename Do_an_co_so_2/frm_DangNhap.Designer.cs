namespace Do_an_co_so_2
{
    partial class frm_DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTenDangNhap = new Label();
            labelMatKhau = new Label();
            textBoxTenDangNhap = new TextBox();
            textBoxMatKhau = new TextBox();
            buttonDangNhap = new Button();
            buttonThoat = new Button();
            SuspendLayout();
            // 
            // labelTenDangNhap
            // 
            labelTenDangNhap.AutoSize = true;
            labelTenDangNhap.Location = new Point(112, 186);
            labelTenDangNhap.Margin = new Padding(4, 0, 4, 0);
            labelTenDangNhap.Name = "labelTenDangNhap";
            labelTenDangNhap.Size = new Size(163, 26);
            labelTenDangNhap.TabIndex = 0;
            labelTenDangNhap.Text = "Tên đăng nhập: ";
            // 
            // labelMatKhau
            // 
            labelMatKhau.AutoSize = true;
            labelMatKhau.Location = new Point(164, 268);
            labelMatKhau.Margin = new Padding(4, 0, 4, 0);
            labelMatKhau.Name = "labelMatKhau";
            labelMatKhau.Size = new Size(111, 26);
            labelMatKhau.TabIndex = 1;
            labelMatKhau.Text = "Mật khẩu: ";
            // 
            // textBoxTenDangNhap
            // 
            textBoxTenDangNhap.Location = new Point(282, 183);
            textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            textBoxTenDangNhap.Size = new Size(324, 33);
            textBoxTenDangNhap.TabIndex = 2;
            textBoxTenDangNhap.Text = "LINH";
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.Location = new Point(282, 265);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Size = new Size(324, 33);
            textBoxMatKhau.TabIndex = 3;
            textBoxMatKhau.Text = "123";
            // 
            // buttonDangNhap
            // 
            buttonDangNhap.Location = new Point(464, 341);
            buttonDangNhap.Name = "buttonDangNhap";
            buttonDangNhap.Size = new Size(142, 74);
            buttonDangNhap.TabIndex = 4;
            buttonDangNhap.Text = "Đăng nhập";
            buttonDangNhap.UseVisualStyleBackColor = true;
            buttonDangNhap.Click += buttonDangNhap_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(282, 341);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(142, 74);
            buttonThoat.TabIndex = 5;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // frm_DangNhap
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 641);
            Controls.Add(buttonThoat);
            Controls.Add(buttonDangNhap);
            Controls.Add(textBoxMatKhau);
            Controls.Add(textBoxTenDangNhap);
            Controls.Add(labelMatKhau);
            Controls.Add(labelTenDangNhap);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frm_DangNhap";
            Text = "ĐĂNG NHẬP";
            FormClosing += FormDangNhap_FormClosing;
            Load += FormDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTenDangNhap;
        private Label labelMatKhau;
        private TextBox textBoxTenDangNhap;
        private TextBox textBoxMatKhau;
        private Button buttonDangNhap;
        private Button buttonThoat;
    }
}