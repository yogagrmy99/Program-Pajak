﻿namespace Program_Pajak
{
    partial class formppn
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
            this.item = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.si = new System.Windows.Forms.Label();
            this.st = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Nama Item :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Harga Total :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(183, 77);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(100, 20);
            this.item.TabIndex = 2;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(183, 150);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // si
            // 
            this.si.AutoSize = true;
            this.si.Location = new System.Drawing.Point(543, 80);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(63, 13);
            this.si.TabIndex = 5;
            this.si.Text = "Total Item : ";
            this.si.Click += new System.EventHandler(this.si_Click);
            // 
            // st
            // 
            this.st.AutoSize = true;
            this.st.Location = new System.Drawing.Point(543, 153);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(35, 13);
            this.st.TabIndex = 6;
            this.st.Text = "label3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Kurang";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formppn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.st);
            this.Controls.Add(this.si);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formppn";
            this.Text = "formppn";
            this.Load += new System.EventHandler(this.formppn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label si;
        private System.Windows.Forms.Label st;
        public System.Windows.Forms.TextBox item;
        public System.Windows.Forms.TextBox total;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}