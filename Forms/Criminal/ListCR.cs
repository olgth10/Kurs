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
            if (add.ShowDialog()==DialogResult.OK)
            {
                Lists crl = new Lists();
                    listBox1.Items.Add(crl.ls[crl.ls.Count-1].ToString());
                add.Close();
            }
                      
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Lists crl = new Lists();
            for (int i = 0; i < crl.ls.Count; i++)
            {
                listBox1.Items.Add(crl.ls[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCR edit = new EditCR(listBox1.SelectedIndex);
            if (listBox1.SelectedIndex != -1)
            {
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    Lists crl = new Lists();
                    listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                    listBox1.Items.Add(crl.ls[crl.ls.Count - 1].ToString());
                    edit.Close();
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCR del = new DeleteCR(listBox1.SelectedIndex);
            if (listBox1.SelectedIndex != -1)
            {
                if (del.ShowDialog() == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else
                {
                    del.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберите преступника для удаления!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArchivCR arch = new ArchivCR();
            if (arch.ShowDialog() == DialogResult.Yes)
            {

            }
        }

        private void ListCR_Load(object sender, EventArgs e)
        {
            Lists crl = new Lists();
            for (int i = 0; i < crl.ls.Count; i++)
            {
                listBox1.Items.Add(crl.ls[i].ToString());
            }
            
        }
    }
}