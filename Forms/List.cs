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
using Kurs.Forms;

namespace Kurs.Forms
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCR add = new AddCR();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCR edit = new EditCR();
            edit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCR del = new DeleteCR();
            del.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArchivCR arch = new ArchivCR();
            arch.Show();
        }
    }
}
