﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            txtbPlainText.Text = "";
            txtbKey.Text = "";
            txtbCipherText.Text = "";
            txtbResult.Text = "";
        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            Vigenere a = new Vigenere(txtbKey.Text);
            a.plainText = txtbPlainText.Text;
            a.MaHoaVigenere();
            txtbResult.Text = a.cipherText;
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            Vigenere a = new Vigenere(txtbKey.Text);
            a.cipherText = txtbCipherText.Text;
            a.GiaiMaVigenere();
            txtbResult.Text = a.plainText;
        }
    }
}
