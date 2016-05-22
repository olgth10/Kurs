using System;
using System.Windows.Forms;
using Kurs.Models;

namespace Kurs.Forms.Actual
{
    public partial class AddCR : Form
    {
        public AddCR()
        {
            InitializeComponent();

            Lists lists = new Lists();

            for (int i = 0; i < lists.ArchiveList.Count; i++)
            {
                if (toolStripComboBox1.Items.IndexOf(lists.ArchiveList[i].hair) == -1)
                {
                    toolStripComboBox1.Items.Add(lists.ArchiveList[i].hair);
                }
                if (toolStripComboBox2.Items.IndexOf(lists.ArchiveList[i].eyes) == -1)
                {
                    toolStripComboBox2.Items.Add(lists.ArchiveList[i].eyes);
                }
                if (toolStripComboBox3.Items.IndexOf(lists.ArchiveList[i].nationality) == -1)
                {
                    toolStripComboBox3.Items.Add(lists.ArchiveList[i].nationality);
                }
                if (toolStripComboBox4.Items.IndexOf(lists.ArchiveList[i].pob) == -1)
                {
                    toolStripComboBox4.Items.Add(lists.ArchiveList[i].pob);
                }
                if (toolStripComboBox5.Items.IndexOf(lists.ArchiveList[i].lastlocation) == -1)
                {
                    toolStripComboBox5.Items.Add(lists.ArchiveList[i].lastlocation);
                }
                if (toolStripComboBox6.Items.IndexOf(lists.ArchiveList[i].languages) == -1)
                {
                    toolStripComboBox6.Items.Add(lists.ArchiveList[i].languages);
                }
                if (toolStripComboBox7.Items.IndexOf(lists.ArchiveList[i].professions) == -1)
                {
                    toolStripComboBox7.Items.Add(lists.ArchiveList[i].professions);
                }
                if (toolStripComboBox8.Items.IndexOf(lists.ArchiveList[i].band) == -1)
                {
                    toolStripComboBox8.Items.Add(lists.ArchiveList[i].band);
                }
            }

            for (int i = 0; i < lists.CriminalList.Count; i++)
            {
                if (toolStripComboBox1.Items.IndexOf(lists.CriminalList[i].hair) == -1)
                {
                    toolStripComboBox1.Items.Add(lists.CriminalList[i].hair);
                }
                if (toolStripComboBox2.Items.IndexOf(lists.CriminalList[i].eyes) == -1)
                {
                    toolStripComboBox2.Items.Add(lists.CriminalList[i].eyes);
                }
                if (toolStripComboBox3.Items.IndexOf(lists.CriminalList[i].nationality) == -1)
                {
                    toolStripComboBox3.Items.Add(lists.CriminalList[i].nationality);
                }
                if (toolStripComboBox4.Items.IndexOf(lists.CriminalList[i].pob) == -1)
                {
                    toolStripComboBox4.Items.Add(lists.CriminalList[i].pob);
                }
                if (toolStripComboBox5.Items.IndexOf(lists.CriminalList[i].lastlocation) == -1)
                {
                    toolStripComboBox5.Items.Add(lists.CriminalList[i].lastlocation);
                }
                if (toolStripComboBox6.Items.IndexOf(lists.CriminalList[i].languages) == -1)
                {
                    toolStripComboBox6.Items.Add(lists.CriminalList[i].languages);
                }
                if (toolStripComboBox7.Items.IndexOf(lists.CriminalList[i].professions) == -1)
                {
                    toolStripComboBox7.Items.Add(lists.CriminalList[i].professions);
                }
                if (toolStripComboBox8.Items.IndexOf(lists.CriminalList[i].band) == -1)
                {
                    toolStripComboBox8.Items.Add(lists.CriminalList[i].band);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" && surname.Text == "" && nickname.Text == "")
            {
                MessageBox.Show("Для добавления преступника требуется указать хотя имя или фамилию или кличку!");
            }
            else
            {
                Criminal cr = new Criminal(name.Text, surname.Text, nickname.Text, double.Parse(heigth.Value.ToString()), toolStripComboBox1.Text, toolStripComboBox2.Text, signs.Text, toolStripComboBox3.Text, dateTimePicker1.Value, toolStripComboBox4.Text, toolStripComboBox5.Text, toolStripComboBox6.Text, toolStripComboBox7.Text, lastdeal.Text, toolStripComboBox8.Text);
                cr.Add();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddCR_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Для добавления преступника требуется указать хотя имя или фамилию или кличку.");
        }
    }
}
