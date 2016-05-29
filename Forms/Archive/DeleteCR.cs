using System;
using System.Windows.Forms;
using Kurs.Models;

namespace Kurs.Forms.Archive
{
    public partial class DeleteCR : Form
    {
        private string data;
        public DeleteCR(string s)
        {
            InitializeComponent();
            data = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Lists lists = new Lists();
            int el = lists.FindIndexArch(data);
            lists.ArchiveList.Remove(lists.ArchiveList[el]);
            lists.ArchiveList[el].DeleteArch();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void DeleteCR_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Форма для удаления преступника. При нажатии кнопки преступник со всеми данными о нём будет удалён.");
        }
    }
}
