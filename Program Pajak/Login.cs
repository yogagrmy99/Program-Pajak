﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Pajak
{
    public partial class Login : Form
    {
        public static string idl;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text=="Yoga" && pw.Text=="generic123" || id.Text == "yoga1" && pw.Text == "1" || id.Text=="admin" &&pw.Text=="admin")
                {
                MessageBox.Show("Berhasil Masuk.");
                Main main = new Main();
                    idl = id.Text;
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cek Kembali ID atau Passowrd anda");
                pw.Text = "";
            }
        }

        private void pw_TextChanged(object sender, EventArgs e)
        {
            pw.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            C hello = new C();
            hello.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
