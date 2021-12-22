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

        public static int chapter_count;
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

            chapter_count = book_editable.Chapters.Length;

            //Блок для теста ошибки на превышение допустимого значения глав
            
            ////  Задание листа для добавления новой главы к сущестующим
            //List<Chapter> chapters_test = new List<Chapter> { };

            //chapters_test.AddRange(book_editable.Chapters);
            //for (int i = 0; i < 997; i++)
            //{

            //    chapter_count++;
            //    Chapter temporary = new () { ChapterId = chapter_count-2, ChapterText = "Some text for test chapter.", ChapterVariants = new Dictionary <string, int> { { "Let's go to the end, variant 1", -1 }, { "Let's go to the end, variant 2", -1 }, { "Let's go to the end, variant 3", -1 } } };

            //    chapters_test.Add(temporary);
            //    //  Перестановка новой главы и завершения книги
            //    var temp = chapters_test[chapter_count - 1]; chapters_test[chapter_count - 1] = chapters_test[chapter_count - 2]; chapters_test[chapter_count - 2] = temp;
            //}
            //book_editable.Chapters = chapters_test.ToArray();

            
        }

        public void ChangeChapter(int NewCurrentChapter)
        {
            //  Временные массивы, содержащие в себе тексты вариантов и ID вариантов следующих глав
            string[] temp_array_string = book_editable.Chapters[NewCurrentChapter].ChapterVariants.Keys.ToArray();
            int[] temp_array_int = book_editable.Chapters[NewCurrentChapter].ChapterVariants.Values.ToArray();

            //  Очистка таблицы вариантов выбора
            VariantsGrid.Rows.Clear();

            //  Заполнение ChapterProppertiesPage
            ChapterIDEdit.Value = book_editable.Chapters[NewCurrentChapter].ChapterId;
            VariantNumberCounter.Value = book_editable.Chapters[NewCurrentChapter].ChapterVariants.Count;

            //  Заполнение ChapterTextProppertiesTab
            ChapterText.Text = book_editable.Chapters[NewCurrentChapter].ChapterText;

            //  Заполнение VariantsGrid
            for (int i = 0; i < book_editable.Chapters[NewCurrentChapter].ChapterVariants.Count; i++)
            {
                VariantsGrid.Rows.Add(1);
            }
            for (int i = 0; i < VariantsGrid.Rows.Count; i++)
            {
                VariantsGrid[0, i].Value = i + 1;
                VariantsGrid[1, i].Value = temp_array_string[i];
                VariantsGrid[2, i].Value = temp_array_int[i];
            }
        }

        public void GetBookData()
        {
            //Количество глав в книге
            chapter_count = book_editable.Chapters.Length;

            //  Заполнение BookProppertiesPage
            BookLabelEditor.Text = book_editable.BookTitle;
            BookAuthorEditor.Text = book_editable.BookAuthor;
            PasswordSetBox.Text = book_editable.Password;
            PasswordChecking.Text = book_editable.Password;

            //  Замена содержимого формы на начальную главу
            ChangeChapter(0);
        }

        private void AllowEditChapterID_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите изменить текущий ID главы? Это может повлиять на работоспособность книги.",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1
            );
            if (result == DialogResult.Yes) ChapterIDEdit.Visible = true;
            else ChapterIDEdit.Visible = false;
        }

        private void OpenBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Запуск диалога выбора файла
            if (OpenBookDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            //  Блок чтения книги с файла
            string filename = OpenBookDialog.FileName;
            StreamReader FileReader = new StreamReader(filename);
            book_editable = JsonSerializer.Deserialize<Book>(FileReader.ReadLine());
            FileReader.Close();

            //  Вызов формы проверки пароля
            PasswordCheck form = new PasswordCheck(book_editable.Password);
            form.ShowDialog();

            //В случае, если форма пройдена, иде загрузка данных книги
            if (form.GetPasswordsEqual() == true)
            {
                GetBookData();
            }

        }

        private void BookEditor_Load(object sender, EventArgs e)
        {
            //  Задание шаблонной книги при инициализации формы
            Book_New();
        }

        private void CreateNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Задание шаблонной книги при инициализации формы
            Book_New();
            //  Загрузка данных в форму
            GetBookData();
        }

        private void AddChapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (book_editable.Chapters.Length < 1000)
            {
                chapter_count++;
                Chapter temporary = new () { ChapterId = chapter_count-2, ChapterText = "Some text for test chapter.", ChapterVariants = new Dictionary <string, int> { { "Let's go to the end, variant 1", -1 }, { "Let's go to the end, variant 2", -1 }, { "Let's go to the end, variant 3", -1 } } };
                //  Задание листа для добавления новой главы к сущестующим
                List<Chapter> chapters = new List<Chapter> { };
                chapters.AddRange(book_editable.Chapters);
                chapters.Add(temporary);
                //  Перестановка новой главы и завершения книги
                var temp = chapters[chapter_count - 1]; chapters[chapter_count - 1] = chapters[chapter_count - 2]; chapters[chapter_count - 2] = temp;
                //  Задание книге увеличенного массива глав
                book_editable.Chapters = chapters.ToArray();
            }
            else
            {
                MessageBox.Show(
                    "Слишком большое количество глав!",
                    "Ошибка добавления главы",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
        }

        private void SwitchChapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Переменная, отвечающая за главу, на которую будет сменяться содержимое формы
            int NextChapter = 0;
            //  Список ID глав, содержащихся в книге
            string[] Chapters_IDs = new string[book_editable.Chapters.Length];

            if (book_editable.Chapters.Length < 2) {
                //  В случае, если книга не открыта (либо битая), вылезает окно, что надо либо создать новую, либо открыть другую
                MessageBox.Show(
                    "Книга не была открыта или создана",
                    "Ошибка смены главы",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
            else
            {
                //  Процесс записи ID всех глав в книге в массив
                for (int i = 0; i < book_editable.Chapters.Length; i++)
                {
                    Chapters_IDs[i]=Convert.ToString(book_editable.Chapters[i].ChapterId);
                }
                //  Сортировка глав
                for (int i = 0; i < book_editable.Chapters.Length; i++)
                {
                    for (int j = 0; j < book_editable.Chapters.Length - 1; j++)
                    {
                        if (Convert.ToInt32(Chapters_IDs[j]) > Convert.ToInt32(Chapters_IDs[j + 1])) { string temp = Chapters_IDs[j]; Chapters_IDs[j] = Chapters_IDs[j + 1]; Chapters_IDs[j + 1] = temp; }
                    }
                }
                //  Запуски формы для выбора главы, на которую будет заменена текущая
                ChangeChapter form = new (Chapters_IDs);
                form.ShowDialog();

                //  Перебор ID для поиска главы, на которую будет заменена текущая
                for (int i = 0; i < book_editable.Chapters.Length; i++)
                {
                    if (form.GetNew_Id() == book_editable.Chapters[i].ChapterId) NextChapter = i;
                }
                //  Смена текущей главы на новую
                ChangeChapter(NextChapter);
            }
            
        }

        private void DeleteChapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Запуск формы удаления главы
            DeleteChapter form = new ();
            form.ShowDialog();

            
        }

    }
}
