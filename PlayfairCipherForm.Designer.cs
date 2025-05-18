namespace Playfair
{
    partial class PlayfairCipherForm
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
            this.labelKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.labelPlainText = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.labelCipherText = new System.Windows.Forms.Label();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(33, 121);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(62, 16);
            this.labelKey.TabIndex = 0;
            this.labelKey.Text = "Keyword:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(117, 118);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(320, 22);
            this.txtKey.TabIndex = 1;
            // 
            // labelPlainText
            // 
            this.labelPlainText.AutoSize = true;
            this.labelPlainText.Location = new System.Drawing.Point(33, 168);
            this.labelPlainText.Name = "labelPlainText";
            this.labelPlainText.Size = new System.Drawing.Size(60, 16);
            this.labelPlainText.TabIndex = 2;
            this.labelPlainText.Text = "Plaintext:";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(117, 165);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(320, 106);
            this.txtPlainText.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(171, 296);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 25);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // labelCipherText
            // 
            this.labelCipherText.AutoSize = true;
            this.labelCipherText.Location = new System.Drawing.Point(36, 343);
            this.labelCipherText.Name = "labelCipherText";
            this.labelCipherText.Size = new System.Drawing.Size(69, 16);
            this.labelCipherText.TabIndex = 5;
            this.labelCipherText.Text = "Ciphertext:";
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(117, 340);
            this.txtCipherText.Multiline = true;
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.ReadOnly = true;
            this.txtCipherText.Size = new System.Drawing.Size(320, 106);
            this.txtCipherText.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(57, 493);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(320, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // PlayfairCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCipherText);
            this.Controls.Add(this.labelCipherText);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.labelPlainText);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.labelKey);
            this.Name = "PlayfairCipherForm";
            this.Text = "Playfair Cipher Encryption Tool\n\n";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label labelPlainText;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label labelCipherText;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

