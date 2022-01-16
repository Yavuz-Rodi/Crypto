using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Yavuz_Rodi_crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        cryptonet rs = new cryptonet();
        
        private void btn_crypternet_Click(object sender, EventArgs e)
        {
            string chiffrement = string.Empty;
            var mess = textBox1.Text;
            if (mess != string.Empty)
            {
                chiffrement = rs.Crypter(mess);
                textBox2.Text = chiffrement;
            }
        }

        private void btn_decrypternet_Click(object sender, EventArgs e)
        {
            string chiffrement = string.Empty;
            var mess = textBox2.Text;
            if (mess != string.Empty)
            {
                chiffrement = rs.Decrypter(mess);
                textBox3.Text = chiffrement;
            }
        }

        private void btn_crypterperso_Click(object sender, EventArgs e)
        {
            string Crypter = string.Empty;
            string kkey = textBox4.Text;
            string Mess = textBox5.Text;
            cryptopers vig = new cryptopers(kkey);
            if (kkey != string.Empty && Mess != string.Empty)
            {
                Crypter = vig.Crypter(Mess);
                textBox6.Text = Crypter;
            }

        }

        private void btn_decrypterperso_Click(object sender, EventArgs e)
        {
            string DeCrypter = string.Empty;
            string kkey = textBox4.Text;
            string Mess = textBox6.Text;
            cryptopers vig = new cryptopers(kkey);
            if (kkey != string.Empty && Mess != string.Empty)
            {
                DeCrypter = vig.Decrypter(Mess);
                textBox7.Text = DeCrypter;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}