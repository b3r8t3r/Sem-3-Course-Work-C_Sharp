using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sem_3_Course_Work_C_Sharp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            //OpenBookDialog.Filter = "Файл интерактивной книги (*.ibr)|*.ibr|Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
        }

        private void OpenBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book restored_book = new Book();

            if (OpenBookDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = OpenBookDialog.FileName;
            // читаем файл в строку
            //string fileText = System.IO.File.ReadAllText(filename);
            StreamReader FileReader = new StreamReader(filename);
            restored_book = JsonSerializer.Deserialize<Book>(FileReader.ReadLine());
            FileReader.Close();


            BookLabel.Text = restored_book.BookTitle;
            ChapterText.Text = restored_book.Chapters[0].ChapterText;
            ChoiceOptions.Items.Clear();
            ChoiceOptions.Items.AddRange(restored_book.Chapters[0].ChapterVariants);
            //ChapterText.Text = fileText;
            // MessageBox.Show("Файл открыт");
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (ChoiceOptions.SelectedIndex == 0)
            {

            }
        }

        private void AboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramBox form = new AboutProgramBox();
            form.ShowDialog();
        }

        private void OpenFontParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта
            ChoiceOptions.Font = fontDialog.Font;
            ChapterText.Font = fontDialog.Font;
            AcceptButton.Font = fontDialog.Font;
        }

        private void SerializeBook()
        {
            
        }

        private void DeserializeBook()
        {

        }

        //private void 
    }
}