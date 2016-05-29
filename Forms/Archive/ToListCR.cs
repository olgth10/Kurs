using System;
using System.Windows.Forms;
using Kurs.Models;

namespace Kurs.Forms.Archive
{
    public partial class ToListCR : Form
    {
        private string data;

        public ToListCR(string s)
        {
            InitializeComponent();
            data = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Lists lists = new Lists();
            int el = lists.FindIndexArch(data);
            lists.ArchiveList.Remove(lists.ArchiveList[el]);
            lists.ArchiveList[el].FromArchive();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void ToListCR_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Форма для переноса преступника из архива. При нажатии кнопки \"Да\" преступник будет перенесён из архива и доступен по нажатию кнопки \"Просмотр всех преступников\".");
        }
    }
}
