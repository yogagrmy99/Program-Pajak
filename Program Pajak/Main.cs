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

            
            user.Text ="Selamat Datang, "+Login.idl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
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
            formppn formppn = new formppn();
            this.Hide();
            formppn.Show();
        }
    }
}
