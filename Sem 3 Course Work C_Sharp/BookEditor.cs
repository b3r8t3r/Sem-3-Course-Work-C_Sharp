using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem_3_Course_Work_C_Sharp
{
    public partial class BookEditor : Form
    {
        public static Book book_editable;
        public BookEditor()
        {
            InitializeComponent();
        }

        public void Book_New()
        {
            Chapter begin = new () { ChapterId = 0, ChapterText = "Some text for begining.", ChapterVariants = new Dictionary <string, int> { { "Let's go to the end, variant 1", -1 }, { "Let's go to the end, variant 2", -1 }, { "Let's go to the end, variant 3", -1 } } };
            Chapter end = new () { ChapterId = -1, ChapterText="End of the book", ChapterVariants = new Dictionary <string, int> { {"End of the book", -1 } } };

            Chapter[] chapters = new [] { begin, end };

            book_editable = new Book { BookAuthor = "Cool Author", BookTitle = "Cool Book", Password = "1111", Chapters = chapters };
            
        }

        public void GetBookData()
        {
            //  Заполнение BookProppertiesPage
            BookLabelEditor.Text = book_editable.BookTitle;
            BookAuthorEditor.Text = book_editable.BookAuthor;
            PasswordSetBox.Text = book_editable.Password;
            PasswordChecking.Text = book_editable.Password;

            //  Заполнение ChapterProppertiesPage
            ChapterIDEdit.Value = book_editable.Chapters[0].ChapterId;
            VariantNumberCounter.Value = book_editable.Chapters[0].ChapterVariants.Count;

            //  Заполнение ChapterTextProppertiesTab
            ChapterText.Text = book_editable.Chapters[0].ChapterText;

            //  Заполнение VariantsEditorPage
            List <string> Chapters_IDs = new();
            for (int i = 0; i<book_editable.Chapters.Length; i++)
            {
                Chapters_IDs.Add(Convert.ToString(book_editable.Chapters[i].ChapterId));
            }
            Chapters_IDs.Sort();

            string[] temp_array_string = book_editable.Chapters[0].ChapterVariants.Keys.ToArray();
            int[] temp_array_int = book_editable.Chapters[0].ChapterVariants.Values.ToArray();

            for (int i = 0; i < book_editable.Chapters[0].ChapterVariants.Count; i++)
            {
                VariantsGrid.Rows.Add(1);
                
                //VariantsGrid[i, 1].Value = temp_array_string[i];
                
            }
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

        private void VariantsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OpenBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenBookDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OpenBookDialog.FileName;
            StreamReader FileReader = new StreamReader(filename);
            book_editable = JsonSerializer.Deserialize<Book>(FileReader.ReadLine());
            FileReader.Close();

            PasswordCheck form = new PasswordCheck(book_editable.Password);
            form.ShowDialog();
        }

        private void BookEditor_Load(object sender, EventArgs e)
        {
            Book_New();

        }

        private void CreateNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_New();
            GetBookData();
        }
    }
}
