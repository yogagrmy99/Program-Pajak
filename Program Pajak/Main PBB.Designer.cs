using System;

namespace Program_Pajak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnprs = new System.Windows.Forms.Button();
            this.btnrst = new System.Windows.Forms.Button();
            this.ilt = new System.Windows.Forms.TextBox();
            this.iht = new System.Windows.Forms.TextBox();
            this.ilb = new System.Windows.Forms.TextBox();
            this.ihb = new System.Windows.Forms.TextBox();
            this.hasil = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hasilt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menghitung PBB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Harga Tanah";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masukkan Luas Tanah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Masukkan Luas Bangunan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Masukkan Harga Bangunan";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnprs
            // 
            this.btnprs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprs.Location = new System.Drawing.Point(262, 300);
            this.btnprs.Name = "btnprs";
            this.btnprs.Size = new System.Drawing.Size(75, 23);
            this.btnprs.TabIndex = 5;
            this.btnprs.Text = "Hitung";
            this.btnprs.UseVisualStyleBackColor = true;
            this.btnprs.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrst
            // 
            this.btnrst.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrst.Location = new System.Drawing.Point(102, 300);
            this.btnrst.Name = "btnrst";
            this.btnrst.Size = new System.Drawing.Size(75, 23);
            this.btnrst.TabIndex = 6;
            this.btnrst.Text = "Reset";
            this.btnrst.UseVisualStyleBackColor = true;
            this.btnrst.Click += new System.EventHandler(this.btnrst_Click);
            // 
            // ilt
            // 
            this.ilt.Location = new System.Drawing.Point(237, 115);
            this.ilt.Name = "ilt";
            this.ilt.Size = new System.Drawing.Size(100, 20);
            this.ilt.TabIndex = 7;
            this.ilt.TextChanged += new System.EventHandler(this.ilt_TextChanged);
            // 
            // iht
            // 
            this.iht.Location = new System.Drawing.Point(237, 161);
            this.iht.Name = "iht";
            this.iht.Size = new System.Drawing.Size(100, 20);
            this.iht.TabIndex = 8;
            this.iht.TextChanged += new System.EventHandler(this.iht_TextChanged);
            // 
            // ilb
            // 
            this.ilb.Location = new System.Drawing.Point(237, 200);
            this.ilb.Name = "ilb";
            this.ilb.Size = new System.Drawing.Size(100, 20);
            this.ilb.TabIndex = 9;
            this.ilb.TextChanged += new System.EventHandler(this.ilb_TextChanged);
            // 
            // ihb
            // 
            this.ihb.Location = new System.Drawing.Point(237, 245);
            this.ihb.Name = "ihb";
            this.ihb.Size = new System.Drawing.Size(100, 20);
            this.ihb.TabIndex = 10;
            this.ihb.TextChanged += new System.EventHandler(this.ihb_TextChanged);
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil.Location = new System.Drawing.Point(407, 182);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(245, 17);
            this.hasil.TabIndex = 11;
            this.hasil.Text = "Jumlah PBB yang harus dibayarkan : ";
            this.hasil.Click += new System.EventHandler(this.hasil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // hasilt
            // 
            this.hasilt.Location = new System.Drawing.Point(658, 182);
            this.hasilt.Name = "hasilt";
            this.hasilt.Size = new System.Drawing.Size(100, 20);
            this.hasilt.TabIndex = 13;
            this.hasilt.TextChanged += new System.EventHandler(this.hasilt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Copyleft SEE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "All Wrong Reseved  2018";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "m";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(343, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "m";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Rp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Rp";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Detail Perhitungan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Kembali";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-484, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 105);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Program_Pajak.Properties.Resources.Cc_public_domain_mark_white_svg;
            this.pictureBox1.Location = new System.Drawing.Point(22, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hasilt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.ihb);
            this.Controls.Add(this.ilb);
            this.Controls.Add(this.iht);
            this.Controls.Add(this.ilt);
            this.Controls.Add(this.btnrst);
            this.Controls.Add(this.btnprs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Program Menghitung Pajak";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnprs;
        private System.Windows.Forms.Button btnrst;
        private System.Windows.Forms.TextBox ilt;
        private System.Windows.Forms.TextBox iht;
        private System.Windows.Forms.TextBox ilb;
        private System.Windows.Forms.TextBox ihb;
        private System.Windows.Forms.Label hasil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox hasilt;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

