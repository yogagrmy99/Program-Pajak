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
    public partial class pbbhitung : Form
    {
   
        //double lt, ht, lb, hb, jtt,jt, jb, njopd, njop, njkp, pbb;

        public pbbhitung()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
            
            //Console.WriteLine(hht.Text = "Rp2");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double jt = (float)Convert.ToDouble(Form1.jt);
            double jb = (float)Convert.ToDouble(Form1.jb);
            double njopd = (float)Convert.ToDouble(Form1.njopd);
            double njop = (float)Convert.ToDouble(Form1.njop);
            double njkp = (float)Convert.ToDouble(Form1.njkp);
            hht.Text = "";
            hht.Text += "Detail Perhitungan" + Environment.NewLine + Environment.NewLine + "Luas Tanah Anda         : " + Form1.lt + "m" + Environment.NewLine + "Nilai Jual Tanah : Rp" + Form1.ht + Environment.NewLine + "Luas Bangunan Anda : " + Form1.lb + "m" + Environment.NewLine + "Nilai Jual Bangunan Anda : Rp" + jb + Environment.NewLine + Environment.NewLine + "Harga Jual Tanah : Rp" + jt + Environment.NewLine + "Harga Jual Bangunan : Rp" + jb + Environment.NewLine + "NJOP dasar adalah : Rp" + njop + Environment.NewLine + "NJOP PBB adalah : Rp" + njop + Environment.NewLine + "NJKP adalah : Rp" + njkp+Environment.NewLine +"PBB Adalah : Rp"+Form1.pbb ;
        }

        private void pbbhitung_Load(object sender, EventArgs e)
        {

        }
    }
}
