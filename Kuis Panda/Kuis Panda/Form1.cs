using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Kuis_Panda
{
    public partial class FormQuizPanda : Form
    {
        public FormQuizPanda()
        {
            InitializeComponent();
        }

        private void FormQuizPanda_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxKalimat;
            textBoxKalimat.Focus();
            
        }

        private void textBoxKalimat_TextChanged(object sender, EventArgs e)
        {
            string Kalimat = Console.ReadLine();
        }

        private void textBoxHuruf1_TextChanged(object sender, EventArgs e)
        {
            string huruf1 = Console.ReadLine();
        }

        private void textBoxUbah_TextChanged(object sender, EventArgs e)
        {
            string huruf2 = Console.ReadLine();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            string Kalimat = textBoxKalimat.Text;
            char Huruf = Convert.ToChar(textBoxHuruf1.Text);
            char Huruf1 = Convert.ToChar(textBoxHuruf1.Text);
            char[] Panda = Kalimat.ToCharArray();
            char Ubah = Convert.ToChar(textBoxUbah.Text);
            int Hitung = 0;
            string Hasil = "";

            while (Huruf1 != Ubah)
            {
                if (Huruf1 > 'z')
                {
                    Huruf1 = 'a';
                }
                else
                {
                    Huruf1++;
                    Hitung++;
                }
            }
            for (int i = 0; i < Panda.Length; i++)
            {
                for (int j = 0; j < Hitung; j++)
                {
                    if (Panda[i] == ' ')
                    {
                        Panda[i] = ' ';
                    }
                    else if (Panda[i] == 'z')
                    {
                        Panda[i] = 'a';
                    }
                    else if (Panda[i] == 'Z')
                    {
                        Panda[i] = 'A';
                    }
                    else
                    {
                        Panda[i]++;
                    }
                }
                Hasil = Hasil + Panda[i];                
            }
            string Hasil1 = Hasil.ToUpper(new CultureInfo("en-US", false));
            labelHasill.Text = Hasil1;
            this.ActiveControl = textBoxKalimat;
            textBoxKalimat.Focus();
        }

        private void labelHasill_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKalimat_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = textBoxHuruf1;
                textBoxHuruf1.Focus();
            }
        }

        private void textBoxUbah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = buttonKonversi;
                buttonKonversi.Focus();
            }
        }

        private void buttonKonversi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonKonversi_Click(sender, e);
            }
        }

        private void textBoxHuruf1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = textBoxUbah;
                textBoxUbah.Focus();
            }
        }

        private void textBoxKalimat_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
