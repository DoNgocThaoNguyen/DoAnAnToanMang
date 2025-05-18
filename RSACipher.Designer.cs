namespace Playfair
{
    partial class RSACipher
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.KichThuocKhoa = new System.Windows.Forms.Label();
            this.cbBitKhoa = new System.Windows.Forms.ComboBox();
            this.btnTaoKhoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbHienThiPublicKey = new System.Windows.Forms.TextBox();
            this.txbHienThiPrivateKey = new System.Windows.Forms.TextBox();
            this.NoiDungMaHoa = new System.Windows.Forms.Label();
            this.txbNoiDungMaHoa = new System.Windows.Forms.TextBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbKetQuaMaHoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNoiDungGiaiMa = new System.Windows.Forms.TextBox();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.txbKetQuaGiaiMa = new System.Windows.Forms.TextBox();
            this.btnLuuPrivateKey = new System.Windows.Forms.Button();
            this.btnTaiPrivateKey = new System.Windows.Forms.Button();
            this.btnTaiPublicKey = new System.Windows.Forms.Button();
            this.btnLuuPublicKey = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbHienThiPrivateKey);
            this.groupBox1.Controls.Add(this.txbHienThiPublicKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTaoKhoa);
            this.groupBox1.Controls.Add(this.cbBitKhoa);
            this.groupBox1.Controls.Add(this.KichThuocKhoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TẠO KHÓA RSA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbKetQuaMaHoa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnMaHoa);
            this.groupBox2.Controls.Add(this.txbNoiDungMaHoa);
            this.groupBox2.Controls.Add(this.NoiDungMaHoa);
            this.groupBox2.Location = new System.Drawing.Point(500, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MÃ HÓA";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuuPublicKey);
            this.groupBox3.Controls.Add(this.btnTaiPublicKey);
            this.groupBox3.Controls.Add(this.btnTaiPrivateKey);
            this.groupBox3.Controls.Add(this.btnLuuPrivateKey);
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LƯU/TẢI KHÓA RSA";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txbKetQuaGiaiMa);
            this.groupBox4.Controls.Add(this.btnGiaiMa);
            this.groupBox4.Controls.Add(this.txbNoiDungGiaiMa);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(500, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 195);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GIẢI MÃ";
            // 
            // KichThuocKhoa
            // 
            this.KichThuocKhoa.AutoSize = true;
            this.KichThuocKhoa.Location = new System.Drawing.Point(15, 35);
            this.KichThuocKhoa.Name = "KichThuocKhoa";
            this.KichThuocKhoa.Size = new System.Drawing.Size(103, 16);
            this.KichThuocKhoa.TabIndex = 0;
            this.KichThuocKhoa.Text = "Kích thước khóa:";
            // 
            // cbBitKhoa
            // 
            this.cbBitKhoa.FormattingEnabled = true;
            this.cbBitKhoa.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096"});
            this.cbBitKhoa.Location = new System.Drawing.Point(141, 32);
            this.cbBitKhoa.Name = "cbBitKhoa";
            this.cbBitKhoa.Size = new System.Drawing.Size(121, 24);
            this.cbBitKhoa.TabIndex = 1;
            // 
            // btnTaoKhoa
            // 
            this.btnTaoKhoa.Location = new System.Drawing.Point(302, 31);
            this.btnTaoKhoa.Name = "btnTaoKhoa";
            this.btnTaoKhoa.Size = new System.Drawing.Size(100, 25);
            this.btnTaoKhoa.TabIndex = 2;
            this.btnTaoKhoa.Text = "Tạo khóa";
            this.btnTaoKhoa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Public Key:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Private Key:";
            // 
            // txbHienThiPublicKey
            // 
            this.txbHienThiPublicKey.Location = new System.Drawing.Point(124, 69);
            this.txbHienThiPublicKey.Multiline = true;
            this.txbHienThiPublicKey.Name = "txbHienThiPublicKey";
            this.txbHienThiPublicKey.ReadOnly = true;
            this.txbHienThiPublicKey.Size = new System.Drawing.Size(309, 46);
            this.txbHienThiPublicKey.TabIndex = 5;
            // 
            // txbHienThiPrivateKey
            // 
            this.txbHienThiPrivateKey.Location = new System.Drawing.Point(124, 133);
            this.txbHienThiPrivateKey.Multiline = true;
            this.txbHienThiPrivateKey.Name = "txbHienThiPrivateKey";
            this.txbHienThiPrivateKey.ReadOnly = true;
            this.txbHienThiPrivateKey.Size = new System.Drawing.Size(309, 46);
            this.txbHienThiPrivateKey.TabIndex = 6;
            this.txbHienThiPrivateKey.TextChanged += new System.EventHandler(this.txbHienThiPrivateKey_TextChanged);
            // 
            // NoiDungMaHoa
            // 
            this.NoiDungMaHoa.AutoSize = true;
            this.NoiDungMaHoa.Location = new System.Drawing.Point(12, 35);
            this.NoiDungMaHoa.Name = "NoiDungMaHoa";
            this.NoiDungMaHoa.Size = new System.Drawing.Size(97, 16);
            this.NoiDungMaHoa.TabIndex = 0;
            this.NoiDungMaHoa.Text = "Nhập nội dung:";
            // 
            // txbNoiDungMaHoa
            // 
            this.txbNoiDungMaHoa.Location = new System.Drawing.Point(124, 21);
            this.txbNoiDungMaHoa.Multiline = true;
            this.txbNoiDungMaHoa.Name = "txbNoiDungMaHoa";
            this.txbNoiDungMaHoa.Size = new System.Drawing.Size(329, 61);
            this.txbNoiDungMaHoa.TabIndex = 1;
            this.txbNoiDungMaHoa.TextChanged += new System.EventHandler(this.txbNoiDungMaHoa_TextChanged);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(232, 88);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(100, 25);
            this.btnMaHoa.TabIndex = 2;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kết quả:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbKetQuaMaHoa
            // 
            this.txbKetQuaMaHoa.Location = new System.Drawing.Point(124, 121);
            this.txbKetQuaMaHoa.Multiline = true;
            this.txbKetQuaMaHoa.Name = "txbKetQuaMaHoa";
            this.txbKetQuaMaHoa.ReadOnly = true;
            this.txbKetQuaMaHoa.Size = new System.Drawing.Size(329, 61);
            this.txbKetQuaMaHoa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập nội dung:";
            // 
            // txbNoiDungGiaiMa
            // 
            this.txbNoiDungGiaiMa.Location = new System.Drawing.Point(124, 21);
            this.txbNoiDungGiaiMa.Multiline = true;
            this.txbNoiDungGiaiMa.Name = "txbNoiDungGiaiMa";
            this.txbNoiDungGiaiMa.Size = new System.Drawing.Size(329, 61);
            this.txbNoiDungGiaiMa.TabIndex = 1;
            this.txbNoiDungGiaiMa.TextChanged += new System.EventHandler(this.txbNoiDungGiaiMa_TextChanged);
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(233, 88);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(100, 25);
            this.btnGiaiMa.TabIndex = 2;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // txbKetQuaGiaiMa
            // 
            this.txbKetQuaGiaiMa.Location = new System.Drawing.Point(124, 121);
            this.txbKetQuaGiaiMa.Multiline = true;
            this.txbKetQuaGiaiMa.Name = "txbKetQuaGiaiMa";
            this.txbKetQuaGiaiMa.ReadOnly = true;
            this.txbKetQuaGiaiMa.Size = new System.Drawing.Size(329, 61);
            this.txbKetQuaGiaiMa.TabIndex = 5;
            // 
            // btnLuuPrivateKey
            // 
            this.btnLuuPrivateKey.Location = new System.Drawing.Point(254, 64);
            this.btnLuuPrivateKey.Name = "btnLuuPrivateKey";
            this.btnLuuPrivateKey.Size = new System.Drawing.Size(147, 23);
            this.btnLuuPrivateKey.TabIndex = 0;
            this.btnLuuPrivateKey.Text = "Lưu Private Key";
            this.btnLuuPrivateKey.UseVisualStyleBackColor = true;
            // 
            // btnTaiPrivateKey
            // 
            this.btnTaiPrivateKey.Location = new System.Drawing.Point(254, 107);
            this.btnTaiPrivateKey.Name = "btnTaiPrivateKey";
            this.btnTaiPrivateKey.Size = new System.Drawing.Size(147, 23);
            this.btnTaiPrivateKey.TabIndex = 1;
            this.btnTaiPrivateKey.Text = "Tải Private Key";
            this.btnTaiPrivateKey.UseVisualStyleBackColor = true;
            // 
            // btnTaiPublicKey
            // 
            this.btnTaiPublicKey.Location = new System.Drawing.Point(58, 107);
            this.btnTaiPublicKey.Name = "btnTaiPublicKey";
            this.btnTaiPublicKey.Size = new System.Drawing.Size(147, 23);
            this.btnTaiPublicKey.TabIndex = 2;
            this.btnTaiPublicKey.Text = "Tải Public Key";
            this.btnTaiPublicKey.UseVisualStyleBackColor = true;
            // 
            // btnLuuPublicKey
            // 
            this.btnLuuPublicKey.Location = new System.Drawing.Point(58, 64);
            this.btnLuuPublicKey.Name = "btnLuuPublicKey";
            this.btnLuuPublicKey.Size = new System.Drawing.Size(147, 23);
            this.btnLuuPublicKey.TabIndex = 3;
            this.btnLuuPublicKey.Text = "Lưu Public Key";
            this.btnLuuPublicKey.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kết quả:";
            // 
            // RSACipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "RSACipher";
            this.Text = "RSACipher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTaoKhoa;
        private System.Windows.Forms.ComboBox cbBitKhoa;
        private System.Windows.Forms.Label KichThuocKhoa;
        private System.Windows.Forms.TextBox txbHienThiPrivateKey;
        private System.Windows.Forms.TextBox txbHienThiPublicKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNoiDungMaHoa;
        private System.Windows.Forms.Label NoiDungMaHoa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbKetQuaMaHoa;
        private System.Windows.Forms.TextBox txbNoiDungGiaiMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuuPublicKey;
        private System.Windows.Forms.Button btnTaiPublicKey;
        private System.Windows.Forms.Button btnTaiPrivateKey;
        private System.Windows.Forms.Button btnLuuPrivateKey;
        private System.Windows.Forms.TextBox txbKetQuaGiaiMa;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Label label5;
    }
}