﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Models;

namespace Kurs.Forms.Archive
{
    public partial class ToListCR : Form
    {
        private int el;

        public ToListCR(int a)
        {
            InitializeComponent();
            el = a;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Lists crl = new Lists();
            crl.arch.Remove(crl.arch[el]);
            crl.arch[el].FromArchive();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}