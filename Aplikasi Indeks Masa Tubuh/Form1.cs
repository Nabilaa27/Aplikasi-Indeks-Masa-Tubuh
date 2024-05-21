using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Indeks_Masa_Tubuh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCek_Click(object sender, EventArgs e)
        {
            double tinggi, berat, imt;
            string nama = txNama.Text;
            string ket1, ket2, ket3;
            ket1 = ("Berat Badan Anda Ideal");
            ket2 = ("Kekurangan Berat Badan");
            ket3 = ("Kelebihan Berat Badan");
            tinggi = Convert.ToDouble(txTinggi.Text) / 100;
            berat = Convert.ToDouble(txBerat.Text);
            imt = berat / (tinggi * tinggi);


            if (imt >= 18 && imt <= 21)
            {
                txHasil.SelectedText = (nama + " indeks masa tubuh anda " + imt + ket1);
            }
            else if (imt < 18.5)
            {
                txHasil.SelectedText = (nama + " indeks masa tubuh anda " + imt + ket2);
            }
            else
            {
                txHasil.SelectedText = (nama + " indeks masa tubuh anda " + imt + ket3);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txNama.Text = "";
            txTinggi.Text = "";
            txHasil.Text = "";
            txBerat.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
