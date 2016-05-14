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

namespace Kurs.Forms.Criminal
{
    public partial class EditCR : Form
    {
        private string data;

        public EditCR(string s)
        {
            InitializeComponent();
            Lists crl = new Lists();

            data = s;

            for (int i = 0; i < crl.arch.Count; i++)
            {
                if (toolStripComboBox1.Items.IndexOf(crl.arch[i].hair) == -1)
                {
                    toolStripComboBox1.Items.Add(crl.arch[i].hair);
                }
                if (toolStripComboBox2.Items.IndexOf(crl.arch[i].eyes) == -1)
                {
                    toolStripComboBox2.Items.Add(crl.arch[i].eyes);
                }
                if (toolStripComboBox3.Items.IndexOf(crl.arch[i].nationality) == -1)
                {
                    toolStripComboBox3.Items.Add(crl.arch[i].nationality);
                }
                if (toolStripComboBox4.Items.IndexOf(crl.arch[i].pob) == -1)
                {
                    toolStripComboBox4.Items.Add(crl.arch[i].pob);
                }
                if (toolStripComboBox5.Items.IndexOf(crl.arch[i].lastlocation) == -1)
                {
                    toolStripComboBox5.Items.Add(crl.arch[i].lastlocation);
                }
                if (toolStripComboBox6.Items.IndexOf(crl.arch[i].languages) == -1)
                {
                    toolStripComboBox6.Items.Add(crl.arch[i].languages);
                }
                if (toolStripComboBox7.Items.IndexOf(crl.arch[i].professions) == -1)
                {
                    toolStripComboBox7.Items.Add(crl.arch[i].professions);
                }
                if (toolStripComboBox8.Items.IndexOf(crl.arch[i].band) == -1)
                {
                    toolStripComboBox8.Items.Add(crl.arch[i].band);
                }
            }
            for (int i = 0; i < crl.ls.Count; i++)
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
                if (toolStripComboBox8.Items.IndexOf(crl.ls[i].band) == -1)
                {
                    toolStripComboBox8.Items.Add(crl.ls[i].band);
                }
            }

            int a = crl.FindIndex(data);
            if (a!=-1)
            {
                name.Text = crl.ls[a].name;
                surname.Text = crl.ls[a].surname;
                nickname.Text = crl.ls[a].nickname;
                heigth.Value = decimal.Parse(crl.ls[a].heigth.ToString());
                toolStripComboBox1.Text = crl.ls[a].hair;
                toolStripComboBox2.Text = crl.ls[a].eyes;
                signs.Text = crl.ls[a].signs;
                toolStripComboBox3.Text = crl.ls[a].nationality;
                dateTimePicker1.Value = crl.ls[a].dob;
                toolStripComboBox4.Text = crl.ls[a].pob;
                toolStripComboBox5.Text = crl.ls[a].lastlocation;
                toolStripComboBox6.Text = crl.ls[a].languages;
                toolStripComboBox7.Text = crl.ls[a].professions;
                lastdeal.Text = crl.ls[a].lastdeal;
                toolStripComboBox8.Text = crl.ls[a].band;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lists crl = new Lists();
            int el = crl.FindIndex(data);
            crl.ls.Remove(crl.ls[el]);
            crl.ls[el].Delete();            
            Kurs.Models.Criminal cr = new Models.Criminal(name.Text, surname.Text, nickname.Text, double.Parse(heigth.Value.ToString()), toolStripComboBox1.Text, toolStripComboBox2.Text, signs.Text, toolStripComboBox3.Text, dateTimePicker1.Value, toolStripComboBox4.Text, toolStripComboBox5.Text, toolStripComboBox6.Text, toolStripComboBox7.Text, lastdeal.Text,toolStripComboBox8.Text);
            cr.Add();
            crl.ls.Add(cr);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}