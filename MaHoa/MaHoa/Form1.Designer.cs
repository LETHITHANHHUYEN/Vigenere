﻿
namespace MaHoa
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btEncrypt = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbPlainText = new System.Windows.Forms.TextBox();
            this.txtbKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbCipherText = new System.Windows.Forms.TextBox();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "VĂN BẢN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TỪ KHÓA:";
            // 
            // btEncrypt
            // 
            this.btEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncrypt.Location = new System.Drawing.Point(44, 221);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(115, 23);
            this.btEncrypt.TabIndex = 2;
            this.btEncrypt.Text = "MÃ HÓA";
            this.btEncrypt.UseVisualStyleBackColor = true;
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(563, 382);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(91, 23);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "THOÁT";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(366, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "VIGENERE";
            // 
            // txtbPlainText
            // 
            this.txtbPlainText.Location = new System.Drawing.Point(98, 104);
            this.txtbPlainText.Name = "txtbPlainText";
            this.txtbPlainText.Size = new System.Drawing.Size(356, 22);
            this.txtbPlainText.TabIndex = 5;
            // 
            // txtbKey
            // 
            this.txtbKey.Location = new System.Drawing.Point(585, 124);
            this.txtbKey.Name = "txtbKey";
            this.txtbKey.Size = new System.Drawing.Size(203, 22);
            this.txtbKey.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "BẢN MÃ:";
            // 
            // txtbCipherText
            // 
            this.txtbCipherText.Location = new System.Drawing.Point(98, 151);
            this.txtbCipherText.Name = "txtbCipherText";
            this.txtbCipherText.Size = new System.Drawing.Size(356, 22);
            this.txtbCipherText.TabIndex = 9;
            // 
            // btDecrypt
            // 
            this.btDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecrypt.Location = new System.Drawing.Point(44, 306);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(115, 23);
            this.btDecrypt.TabIndex = 10;
            this.btDecrypt.Text = "GIẢI MÃ";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(270, 382);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "XÓA";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtbResult
            // 
            this.txtbResult.Location = new System.Drawing.Point(208, 221);
            this.txtbResult.Multiline = true;
            this.txtbResult.Name = "txtbResult";
            this.txtbResult.ReadOnly = true;
            this.txtbResult.Size = new System.Drawing.Size(512, 108);
            this.txtbResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbResult);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btDecrypt);
            this.Controls.Add(this.txtbCipherText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbKey);
            this.Controls.Add(this.txtbPlainText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vigenere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPlainText;
        private System.Windows.Forms.TextBox txtbKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbCipherText;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtbResult;
    }
}

