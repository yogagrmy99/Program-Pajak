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

    public partial class PPN : Form
    {
        Stack sit = new Stack();
        Stack sht = new Stack();
        string item1;
        string total1;
        float total2;

        public PPN()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
              
        }

        private void formppn_Load(object sender, EventArgs e)
        {
            
        }
        
        public void hitungppn()
        {
            try
            {

                foreach (string total1 in sht)
                {
                    total2 += ((Single.Parse(total1) / 10));
                    
                }
                
            }
            catch
            {
                sit.Clear();
                sht.Clear();
                MessageBox.Show("Inputan salah. Daftar Barang Dihapus. Silakan Mulai dari awal");
                cleartext();
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (item.Text == "" || total.Text == " " || total.Text == "  " || total.Text == "  ")
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
                while (sht.Count != 0 && sit.Count!=0)
                    
                    {
                        detail.Text += sit.Peek() + " ";
                        detail.Text += "Rp" + sht.Peek();
                        sit.Pop();
                        sht.Pop();
                        detail.Text += Environment.NewLine;
                    }
                si.Text = "Total Item : 0";
            }
            catch
            {
                MessageBox.Show("Selesai");
            }
            if (total2 != 0)
            {
                detail.Text += Environment.NewLine + "Pajak yang harus dibayarkan : Rp" + total2;
            }
            total2 = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cleartext();
            if (sht.Count != 0)
            {
                fungsitbl();
            }
            else
            {
                detail.Text = "Item anda Kosong";
            }

        }
        public void cleartext()
        {
            detail.Text = "";
            item.Text = "";
            total.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            sit.Clear();
            sht.Clear();
            total2 = 0;
            si.Text = "Total Item : 0";
            cleartext();        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void detail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
