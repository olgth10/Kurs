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

namespace Kurs.Forms.Archive
{
    public partial class ChangeInARCH : Form
    {
        private string data;
        public ChangeInARCH(string s)
        {
            InitializeComponent();
            data = s;
            Lists crl = new Lists();
            int a = crl.FindIndexArch(data);
            if (a != -1)
            {
                name.Text = crl.arch[a].name;
                surname.Text = crl.arch[a].surname;
                nickname.Text = crl.arch[a].nickname;
                heigth.Value = decimal.Parse(crl.arch[a].heigth.ToString());
                toolStripComboBox1.Text = crl.arch[a].hair;
                toolStripComboBox2.Text = crl.arch[a].eyes;
                signs.Text = crl.arch[a].signs;
                toolStripComboBox3.Text = crl.arch[a].nationality;
                dateTimePicker1.Value = crl.arch[a].dob;
                toolStripComboBox4.Text = crl.arch[a].pob;
                toolStripComboBox5.Text = crl.arch[a].lastlocation;
                toolStripComboBox6.Text = crl.arch[a].languages;
                toolStripComboBox7.Text = crl.arch[a].professions;
                lastdeal.Text = crl.arch[a].lastdeal;
                toolStripComboBox8.Text = crl.arch[a].band;
            }            
        }

        private void ChangeInARCH_Load(object sender, EventArgs e)
        {
            Lists crl = new Lists();

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lists crl = new Lists();
            int el= crl.FindIndexArch(data);
            crl.arch.Remove(crl.arch[el]);
            crl.arch[el].DeleteArch();            
            Kurs.Models.Criminal cr = new Models.Criminal(name.Text, surname.Text, nickname.Text, double.Parse(heigth.Value.ToString()), toolStripComboBox1.Text, toolStripComboBox2.Text, signs.Text, toolStripComboBox3.Text, dateTimePicker1.Value, toolStripComboBox4.Text, toolStripComboBox5.Text, toolStripComboBox6.Text, toolStripComboBox7.Text, lastdeal.Text,toolStripComboBox8.Text);
            cr.Add();
            cr.ToArchive();
            crl.arch.Add(cr);
            DialogResult = DialogResult.OK;
        }
    }
}
