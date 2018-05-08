using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
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
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //this.Hide();
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Login")
                    Application.OpenForms[i].Close();
            }
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
