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
    public partial class AddCR : Form
    {
        public AddCR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.Criminal cr = new Models.Criminal(name.Text, surname.Text, nickname.Text, double.Parse(heigth.Value.ToString()), toolStripComboBox1.Text, toolStripComboBox2.Text, signs.Text, toolStripComboBox3.Text, dateTimePicker1.Value,toolStripComboBox4.Text,toolStripComboBox5.Text, toolStripComboBox6.Text, toolStripComboBox7.Text, lastdeal.Text);
            cr.Add();
            Lists crl = new Lists();
            crl.ls.Add(cr);
            this.DialogResult = DialogResult.OK;
        }
        private void AddCR_Load(object sender, EventArgs e)
        {
            Lists crl = new Lists();
            toolStripComboBox1.Items.Add(crl.ls[0].hair);
            toolStripComboBox2.Items.Add(crl.ls[0].eyes);
            toolStripComboBox3.Items.Add(crl.ls[0].nationality);
            toolStripComboBox4.Items.Add(crl.ls[0].pob);
            toolStripComboBox5.Items.Add(crl.ls[0].lastlocation);
            toolStripComboBox6.Items.Add(crl.ls[0].languages);
            toolStripComboBox7.Items.Add(crl.ls[0].professions);

            for (int i = 1; i < crl.ls.Count; i++)
            {
                if (toolStripComboBox1.Items.IndexOf(crl.ls[i].hair) == -1)
                {
                    toolStripComboBox1.Items.Add(crl.ls[i].hair);
                }
                if (toolStripComboBox2.Items.IndexOf(crl.ls[i].eyes) == -1)
                {
                    toolStripComboBox2.Items.Add(crl.ls[i].eyes);
                }
                if (toolStripComboBox3.Items.IndexOf(crl.ls[i].nationality) == -1)
                {
                    toolStripComboBox3.Items.Add(crl.ls[i].nationality);
                }
                if (toolStripComboBox4.Items.IndexOf(crl.ls[i].pob) == -1)
                {
                    toolStripComboBox4.Items.Add(crl.ls[i].pob);
                }
                if (toolStripComboBox5.Items.IndexOf(crl.ls[i].lastlocation) == -1)
                {
                    toolStripComboBox5.Items.Add(crl.ls[i].lastlocation);
                }
                if (toolStripComboBox6.Items.IndexOf(crl.ls[i].languages) == -1)
                {
                    toolStripComboBox6.Items.Add(crl.ls[i].languages);
                }
                if (toolStripComboBox7.Items.IndexOf(crl.ls[i].professions) == -1)
                {
                    toolStripComboBox7.Items.Add(crl.ls[i].professions);
                }
            }            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void heigth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void menu2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lastdeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void signs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void menu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu6_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu7_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
