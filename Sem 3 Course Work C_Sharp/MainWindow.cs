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

        static Book restored_book = new Book();

        static int chapter_index = 0;

        
        private void ChangeChapter()
        {
            int i;
            BookLabel.Text = restored_book.BookTitle;

            for (i = 0; restored_book.Chapters[i].ChapterId != chapter_index; i++) { 
                if (i >= restored_book.Chapters.Count()) { 
                    i = -1; 
                    chapter_index = -1; 
                }
            }

            ChapterText.Text = restored_book.Chapters[i].ChapterText;
            ChoiceOptions.Items.Clear();

            string[] temp_array = restored_book.Chapters[i].ChapterVariants.Keys.ToArray();

            ChoiceOptions.Items.AddRange(temp_array);
            ChoiceOptions.SelectedIndex = 0;
        }

        private void OpenBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenBookDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = OpenBookDialog.FileName;
            // читаем файл в строку
            //string fileText = System.IO.File.ReadAllText(filename);
            StreamReader FileReader = new StreamReader(filename);
            restored_book = JsonSerializer.Deserialize<Book>(FileReader.ReadLine());
            FileReader.Close();

            ChangeChapter();
            
            //ChapterText.Text = fileText;
            MessageBox.Show("Книга успешно открыта!");
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string? selectedVariant = ChoiceOptions.SelectedItem.ToString();

            if (selectedVariant == null)
            {
                MessageBox.Show($"Вы ничего не выбрали. Пожалуйста, выберите вариант дальнейшего развития событий.");
            }

            else
            {

                if (chapter_index != -1)
                    chapter_index = restored_book.Chapters[chapter_index].ChapterVariants[selectedVariant];
                else Application.Exit();

                //MessageBox.Show($"Выбран вариант с индексом {ChoiceOptions.SelectedIndex}!\nЭтот вариант - \"{selectedVariant}\"");

                ChangeChapter();
            }
            
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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ChoiceOptions.SelectedIndex = 0;
        }

        private void OpenBookEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookEditor form = new BookEditor();

            //PasswordCheck form = new ();

            form.ShowDialog();
        }
    }
}