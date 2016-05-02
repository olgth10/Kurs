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
    public partial class FindARCH : Form
    {
        public FindARCH()
        {
            InitializeComponent();
        }
        public List<Models.Criminal> fn;
        private void button1_Click(object sender, EventArgs e)
        {
            Kurs.Models.Criminal cr = new Models.Criminal(name.Text, surname.Text, nickname.Text, double.Parse(heigth.Value.ToString()), toolStripComboBox1.Text, toolStripComboBox2.Text, signs.Text, toolStripComboBox3.Text, dateTimePicker1.Value, toolStripComboBox4.Text, toolStripComboBox5.Text, toolStripComboBox6.Text, toolStripComboBox7.Text, lastdeal.Text);
            Lists crl = new Lists();
            fn = crl.Findarch(cr);
            DialogResult = DialogResult.OK;
        }

        private void FindARCH_Load(object sender, EventArgs e)
        {
            Lists crl = new Lists();
            toolStripComboBox1.Items.Add(crl.ls[0].hair);
            toolStripComboBox2.Items.Add(crl.ls[0].eyes);
            toolStripComboBox3.Items.Add(crl.ls[0].nationality);
            toolStripComboBox4.Items.Add(crl.ls[0].pob);
            toolStripComboBox5.Items.Add(crl.ls[0].lastlocation);
            toolStripComboBox6.Items.Add(crl.ls[0].languages);
            toolStripComboBox7.Items.Add(crl.ls[0].professions);
            toolStripComboBox1.Items.Add(crl.arch[0].hair);
            toolStripComboBox2.Items.Add(crl.arch[0].eyes);
            toolStripComboBox3.Items.Add(crl.arch[0].nationality);
            toolStripComboBox4.Items.Add(crl.arch[0].pob);
            toolStripComboBox5.Items.Add(crl.arch[0].lastlocation);
            toolStripComboBox6.Items.Add(crl.arch[0].languages);
            toolStripComboBox7.Items.Add(crl.arch[0].professions);
            for (int i = 1; i < crl.arch.Count; i++)
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
            }
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
    }
}
