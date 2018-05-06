using System;
using System.Collections;
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

    public partial class formppn : Form
    {
        Stack sit = new Stack();
        Stack sht = new Stack();

        public formppn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
              
        }

        private void formppn_Load(object sender, EventArgs e)//kinda confused, placing stack in which function
        {
            
        }

        private void button1_Click(object sender, EventArgs e) //this is proceed button for Push stack
        {
            sit.Push(item);
            int count1 = sit.Count;
            int count2 = sht.Count;
            si.Text = "Total Item : " + count1.ToString();
            
        }

        private void si_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sit.Pop();
                int count1 = sit.Count;
                si.Text = "Total Item : " + count1.ToString();
            }
            catch
            {
                MessageBox.Show("Item anda sudah kosong");
            }
        }
    }
}
