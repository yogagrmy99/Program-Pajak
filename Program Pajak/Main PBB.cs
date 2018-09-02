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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static float lempar;
        public float jtt;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public static float lt, ht, lb, hb, jt, jb, njopd, njop, njkp, pbb;
        public void Mpbb()
        {
            try
            {
                lt = Convert.ToSingle(ilt.Text);
                ht = Convert.ToSingle(iht.Text);
                lb = Convert.ToSingle(ilb.Text);
                hb = Convert.ToSingle(ihb.Text);
                jt = lt * ht;
                jb = lb * hb;
                njopd = jt + jb;
                if (njopd >= 24000000)
                {
                    njop = njopd - 12000000;
                }
                else
                {
                    njop = njopd;
                }
                njkp = 0.2f * njop;
                pbb = 0.005f * njkp;
                hasilt.Text = pbb.ToString("c");
            }
            catch
            {
                MessageBox.Show("Data tidak boleh kosong.");
            }

        }


        private void ilt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ilt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ilt.Text = ilt.Text.Remove(ilt.Text.Length - 1);
            }
        }

        private void iht_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(iht.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                iht.Text = iht.Text.Remove(iht.Text.Length - 1);
            }
        }

        private void ilb_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ilb.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ilb.Text = ilb.Text.Remove(ilb.Text.Length - 1);
            }
        }

        private void ihb_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ihb.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ihb.Text = ihb.Text.Remove(ihb.Text.Length - 1);
            }
        }

        private void ilt_KeyPress(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lempar = pbb;
            pbbhitung ph = new pbbhitung();
            ph.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            //m.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void hasil_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnrst_Click(object sender, EventArgs e)
        {
            ilt.Text = "";
            ilb.Text = "";
            iht.Text = "";
            ihb.Text = "";
            hasilt.Text = "";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Mpbb();
        }

        private void hasilt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}