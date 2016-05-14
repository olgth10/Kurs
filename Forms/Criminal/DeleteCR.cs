using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Models;

namespace Kurs.Forms
{
    public partial class DeleteCR : Form
    {
        private string data;

        public DeleteCR(string s)
        {
            InitializeComponent();
            data = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Lists ls = new Lists();
            ls.ls[ls.FindIndex(data)].Delete();
            Close();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
