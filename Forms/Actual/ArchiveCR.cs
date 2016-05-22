using System;
using System.Windows.Forms;
using Kurs.Models;

namespace Kurs.Forms.Actual
{
    public partial class ArchiveCR : Form
    {
        private string data;

        public ArchiveCR(string s)
        {
            InitializeComponent();
            data = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Lists CriminalList = new Lists();
            CriminalList.CriminalList[CriminalList.FindIndex(data)].ToArchive();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ArchiveCR_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Форма для переноса преступника в архив. При нажатии кнопки \"Да\" преступник будет перенесён в архив и доступен по нажатию кнопки \"Просмотр архива\".");
        }
    }
}
