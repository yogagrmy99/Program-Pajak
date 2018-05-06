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
        string item1;
        string total1;

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
        
        public void hitungppn()
        {
            //int sum = sht.sum();

            /*(foreach (int total in sht)
            {
                total1 += total;   
            }
            return total1; */
        }

        private void button1_Click(object sender, EventArgs e) //this is proceed button for Push stack
        {
            //if (item.Text == "" || item.Text == " ")
            if (item.Text == "" || total.Text == "")
            {
                MessageBox.Show("Tidak Boleh Kosong.");
                item.Text = "";
                total.Text = "";
                
            }
            else
            {
                item1 = Convert.ToString(item);
                total1 = Convert.ToString(total);
                sit.Push(item1);
                sht.Push(total1);
                int count1 = sit.Count;
                int count2 = sht.Count;
                si.Text = "Total Item : " + count1.ToString();
                st.Text = "Total Item : " + count2.ToString();
                //hitungppn();
                //detail.Text = total1.ToString();
            }
        }

        private void si_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                    sit.Pop();
                    sht.Pop();
                    int count1 = sit.Count;
                    int count2 = sht.Count;
                    si.Text = "Total Item : " + count1.ToString();
                    st.Text = "Harga Total : " + count2.ToString();
            }
            catch
            {
                MessageBox.Show("Item anda sudah kosong");
            }
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(total.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                total.Text = total.Text.Remove(total.Text.Length - 1);
            }
        }

        private void item_TextChanged(object sender, EventArgs e)
        {
           
            
            
        }

        private void st_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //hitungppn();
            foreach (string total in sht)
            {
                detail.Text += total.ToString();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            detail.Text = "";
        }
    }
}
