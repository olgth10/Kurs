using System;
using System.Windows.Forms;
using Kurs.Models;
using Kurs.Forms.Archive;

namespace Kurs.Forms.Actual
{
    public partial class ListCR : Form
    {
        public ListCR()
        {
            InitializeComponent();
        }

        private void ListCR_Load(object sender, EventArgs e)
        {
            Lists lists = new Lists();
            for (int i = 0; i < lists.CriminalList.Count; i++)
            {
                listBox1.Items.Add(lists.CriminalList[i].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCR add = new AddCR();
            if (add.ShowDialog() == DialogResult.OK)
            {
                Lists lists = new Lists();
                listBox1.Items.Add(lists.CriminalList[lists.CriminalList.Count - 1].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Lists CriminalList = new Lists();
                EditCR edit = new EditCR(listBox1.SelectedItem.ToString());

                if (edit.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                    listBox1.Items.Add(CriminalList.CriminalList[CriminalList.CriminalList.Count - 1].ToString());
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
            FindCR fcr = new FindCR();
            Lists lists = new Lists();

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

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Lists l = new Lists();
            foreach (Band b in l.BandsList)
            {
                if (b.name == "")
                {
                    listBox1.Items.Add("Без банды:");
                }
                else
                {
                    listBox1.Items.Add("Название банды: " + b.name);
                }
                foreach (Criminal cr in b.CriminalList)
                {
                    listBox1.Items.Add(cr.ToString());
                }
            }
            button8.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ArchiveCR ArchiveList = new ArchiveCR(listBox1.SelectedItem.ToString());
                if (ArchiveList.ShowDialog() == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Выберите преступника для переноса в архив!");
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
                Lists lists = new Lists();
                for (int i = 0; i < lists.CriminalList.Count; i++)
                {
                    listBox1.Items.Add(lists.CriminalList[i].ToString());
                }
            }
            else
            {
                Show();
                listBox1.Items.Clear();
                Lists lists = new Lists();
                for (int i = 0; i < lists.CriminalList.Count; i++)
                {
                    listBox1.Items.Add(lists.CriminalList[i].ToString());
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lists lists = new Lists();
            listBox1.Items.Clear();
            for (int i = 0; i < lists.CriminalList.Count; i++)
            {
                listBox1.Items.Add(lists.CriminalList[i].ToString());
            }
            button8.Visible = false;
        }        

        private void ListCR_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Здесь Вы можете добавлять, редактировать, удалять и искать преступников, просматривать список банд, а также просматривать архив преступников. Все эти действия осуществляются нажатием кнопок на данной форме. Дополнительную информацию и помощь вы можете получить на формах действий с преступниками");
        }
    }
}
