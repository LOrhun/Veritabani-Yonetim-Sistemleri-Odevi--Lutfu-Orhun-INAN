﻿namespace VTY_Ödev_test_0._1
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifreHatali = new System.Windows.Forms.Label();
            this.kayitYapildi = new System.Windows.Forms.Label();
            this.itExists = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // sifreHatali
            // 
            this.sifreHatali.AutoSize = true;
            this.sifreHatali.ForeColor = System.Drawing.Color.Red;
            this.sifreHatali.Location = new System.Drawing.Point(85, 218);
            this.sifreHatali.Name = "sifreHatali";
            this.sifreHatali.Size = new System.Drawing.Size(79, 15);
            this.sifreHatali.TabIndex = 6;
            this.sifreHatali.Text = "Şifreniz Hatalı";
            this.sifreHatali.Visible = false;
            this.sifreHatali.Click += new System.EventHandler(this.label3_Click);
            // 
            // kayitYapildi
            // 
            this.kayitYapildi.AutoSize = true;
            this.kayitYapildi.ForeColor = System.Drawing.Color.Lime;
            this.kayitYapildi.Location = new System.Drawing.Point(93, 218);
            this.kayitYapildi.Name = "kayitYapildi";
            this.kayitYapildi.Size = new System.Drawing.Size(71, 15);
            this.kayitYapildi.TabIndex = 7;
            this.kayitYapildi.Text = "Kayıt Yapıldı";
            this.kayitYapildi.Visible = false;
            // 
            // itExists
            // 
            this.itExists.AutoSize = true;
            this.itExists.ForeColor = System.Drawing.Color.Black;
            this.itExists.Location = new System.Drawing.Point(23, 283);
            this.itExists.Name = "itExists";
            this.itExists.Size = new System.Drawing.Size(222, 15);
            this.itExists.TabIndex = 8;
            this.itExists.Text = "Girilen kullanıcı adı kayıtlarda bulunuyor!";
            this.itExists.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 329);
            this.Controls.Add(this.itExists);
            this.Controls.Add(this.kayitYapildi);
            this.Controls.Add(this.sifreHatali);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sifreHatali;
        private System.Windows.Forms.Label kayitYapildi;
        private System.Windows.Forms.Label itExists;
    }
}