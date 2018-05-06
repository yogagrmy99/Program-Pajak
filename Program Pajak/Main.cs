using System;
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
    public partial class Main : Form
    {
        Login login = new Login();
        public Main()
        {
            InitializeComponent();   

        }

        public void Main_Load(object sender, EventArgs e)
        {
            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            user.Text ="Selamat Datang, "+Login.idl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.BackColor = Color.Transparent;
            Form1 form1 = new Form1();
            //this.Hide();
            form1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PPN formppn = new PPN();
            //this.Hide();
            formppn.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
