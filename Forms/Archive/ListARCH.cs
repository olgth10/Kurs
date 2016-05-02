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
using Kurs.Forms.Criminal;

namespace Kurs.Forms.Archive
{
    public partial class ListARCH : Form
    {
        public ListARCH()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListCR lcr = new ListCR();
            lcr.Show();
            this.Close();
        }
    }
}
