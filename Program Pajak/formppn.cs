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
        int total2;

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
            
            foreach (string total1 in sht)
            {
                total2 += ((Int32.Parse(total1)/10));
                //total2 += total2 / 10;
                
            }
            //detail.Text = total2.ToString();
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
                item1 = item.Text.ToString();
                total1 = total.Text.ToString();
                sit.Push(item1);
                sht.Push(total1);
                int count1 = sit.Count;
                int count2 = sht.Count;
                si.Text = "Total Item : " + count1.ToString();
                //st.Text = "Total Item : " + count2.ToString();
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
                    //st.Text = "Harga Total : " + count2.ToString();
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
        private void fungsitbl()
        {
            hitungppn();
            try
            {
                
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek()+" ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();
                sit.Pop();
                sht.Pop();
                detail.Text += Environment.NewLine;
                detail.Text += sit.Peek() + " ";
                detail.Text += "Rp" + sht.Peek();


            }
            catch
            {
                MessageBox.Show("Selesai");
            }
            detail.Text += Environment.NewLine+"Pajak yang harus dibayarkan : Rp" + total2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //hitungppn();
            /*foreach (string item1 in sit)
            {
                detail.Text += item1;
                detail.Text += "   ";
                foreach (string total1 in sht)
                {
                    detail.Text += total1;
                    sht.Pop();
                }
                detail.Text += Environment.NewLine;
                sit.Pop(); */

            fungsitbl();
            si.Text="";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            detail.Text = "";
        }
    }
}
