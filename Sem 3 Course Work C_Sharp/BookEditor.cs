using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem_3_Course_Work_C_Sharp
{
    public partial class BookEditor : Form
    {
        static Book book_editable;
        public BookEditor()
        {
            InitializeComponent();
        }

        private void AllowEditChapterID_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите изменить текущий ID главы? Это может повлиять на работоспособность книги.",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            if (result == DialogResult.Yes) ChapterIDEdit.Visible = true;
            else ChapterIDEdit.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void открытьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BookEditor_Load(object sender, EventArgs e)
        {
            Chapter begin = new Chapter();
        }
    }
}
