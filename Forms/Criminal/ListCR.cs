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
                add.Close();
            }
                      
        }
        private EditCR edit;
        private void button2_Click(object sender, EventArgs e)
        {
            Lists ls = new Lists();
            if (button8.Visible)
            {
                if (listBox1.SelectedIndex != -1)
                {

                    for (int i = 0; i < ls.ls.Count; i++)
                    {
                        if (ls.ls[i].ToString() == listBox1.SelectedItem.ToString())
                        {
                           edit = new EditCR(i);
                        }
                    }
                    if (edit.ShowDialog() == DialogResult.OK)
                    {
                        listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                        listBox1.Items.Add(ls.ls[ls.ls.Count - 1].ToString());
                        edit.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Выберите преступника для редактирования!");
                }
            }
            else
            {
                edit = new EditCR(listBox1.SelectedIndex);
                if (listBox1.SelectedIndex != -1)
                {
                    if (edit.ShowDialog() == DialogResult.OK)
                    {
                        listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                        listBox1.Items.Add(ls.ls[ls.ls.Count - 1].ToString());
                        edit.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Выберите преступника для редактирования!");
                }
            }
        }
        private DeleteCR del;
        private void button3_Click(object sender, EventArgs e)
        {
            Lists ls = new Lists();
            if (button8.Visible)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    
                    for (int i = 0; i < ls.ls.Count; i++)
                    {
                        if (ls.ls[i].ToString() == listBox1.SelectedItem.ToString())
                        {
                            del = new DeleteCR(i);
                        }
                    }
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
            else
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
            
        }
        private ArchivCR arch;
        private void button4_Click(object sender, EventArgs e)
        {
            Lists ls = new Lists();
            if (listBox1.SelectedIndex != -1)
            {
                for (int i = 0; i < ls.ls.Count; i++)
                {
                    if (listBox1.SelectedItem.ToString() == ls.ls[i].ToString())
                    {
                        arch= new ArchivCR(i);
                    }
                }
                if (arch.ShowDialog() == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else
                {
                    arch.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберите преступника для переноса в архив");
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
                    button8.Visible = true;
                }
            }            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListARCH la = new ListARCH();
            la.Show();
            Hide();
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
    }
}