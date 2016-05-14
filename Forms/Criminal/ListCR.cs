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
using Kurs.Models;
using Kurs.Forms.Archive;

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
            }                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Lists ls = new Lists();
                EditCR edit = new EditCR(listBox1.SelectedItem.ToString());

                if (edit.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                    listBox1.Items.Add(ls.ls[ls.ls.Count - 1].ToString());
                }
            }
            else
            {
                MessageBox.Show("Выберите преступника для редактирования!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DeleteCR del = new DeleteCR(listBox1.SelectedItem.ToString());
                if (del.ShowDialog() == DialogResult.Yes)
                {
                    
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Выберите преступника для удаления!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ArchivCR arch = new ArchivCR(listBox1.SelectedItem.ToString());
                if (arch.ShowDialog() == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Выберите преступника для переноса в архив!");
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

        private void button6_Click(object sender, EventArgs e)
        {
            FindCR fcr = new FindCR();
            Lists crl = new Lists();
            
            if (fcr.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < fcr.fn.Count; i++)
                {
                    listBox1.Items.Add(fcr.fn[i].ToString());                    
                }
                button8.Visible = true;
            }            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListARCH la = new ListARCH();
            Hide();
            if (la.ShowDialog() == DialogResult.OK)
            {
                Show();
                listBox1.Items.Clear();
                Lists crl = new Lists();
                for (int i = 0; i < crl.ls.Count; i++)
                {
                    listBox1.Items.Add(crl.ls[i].ToString());
                }
            }
            else
            {
                Show();
                listBox1.Items.Clear();
                Lists crl = new Lists();
                for (int i = 0; i < crl.ls.Count; i++)
                {
                    listBox1.Items.Add(crl.ls[i].ToString());
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lists crl = new Lists();
            listBox1.Items.Clear();
            for (int i = 0; i < crl.ls.Count; i++)
            {
                listBox1.Items.Add(crl.ls[i].ToString());
            }
            button8.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Lists l = new Lists();
            foreach (Band b in l.lb)
            {
                if (b.name=="")
                {
                    listBox1.Items.Add("Без банды:");
                }
                else
                {
                    listBox1.Items.Add("Название банды: " + b.name);
                }                
                foreach (Models.Criminal cr in b.ls)
                {
                    listBox1.Items.Add(cr.ToString());
                }
            }
            button8.Visible = true;
        }
    }
}