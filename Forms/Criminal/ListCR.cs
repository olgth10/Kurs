using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Forms.Criminal;
using Kurs.Forms.Bands;
using Kurs.Models;

namespace Kurs.Forms.Criminal
{
    public partial class ListCR : Form
    {
        public ListCR()
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
            if (edit.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(edit.DialogResult);
                edit.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCR del = new DeleteCR();
            if (del.ShowDialog() == DialogResult.Yes)
            {
                listBox1.Items.Add(del.DialogResult);
                del.Close();
            }
            else
            {
                listBox1.Items.Add(del.DialogResult);
                del.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArchivCR arch = new ArchivCR();
            arch.Show();
        }
    }
}
