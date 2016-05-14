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

        private void ListARCH_Load(object sender, EventArgs e)
        {
            Lists ls = new Lists();
            foreach (Models.Criminal cr in ls.arch)
            {
                listBox1.Items.Add(cr.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Lists ls = new Lists();
                ChangeInARCH edit = new ChangeInARCH(listBox1.SelectedItem.ToString());

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

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }        

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ToListCR tlcr = new ToListCR(listBox1.SelectedItem.ToString());
                if (tlcr.ShowDialog() == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Выберите преступника для переноса из архива!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Lists l = new Lists();
            foreach (Band b in l.lbarch)
            {
                if (b.name == "")
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

        private void button6_Click(object sender, EventArgs e)
        {
            FindARCH fcr = new FindARCH();
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

        private void button8_Click(object sender, EventArgs e)
        {
            Lists crl = new Lists();
            listBox1.Items.Clear();
            for (int i = 0; i < crl.arch.Count; i++)
            {
                listBox1.Items.Add(crl.arch[i].ToString());
            }
            button8.Visible = false;
        }        
    }
}
