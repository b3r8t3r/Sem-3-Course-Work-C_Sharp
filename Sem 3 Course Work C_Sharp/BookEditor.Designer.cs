namespace Sem_3_Course_Work_C_Sharp
{
    partial class BookEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookEditorStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.IntercativeBookPropperties = new System.Windows.Forms.TabControl();
            this.BookProppertiesPage = new System.Windows.Forms.TabPage();
            this.Password = new System.Windows.Forms.TextBox();
            this.PasswordSetupLabel = new System.Windows.Forms.Label();
            this.PasswordSetBox = new System.Windows.Forms.TextBox();
            this.BookPropperties_SaveChangesButton = new System.Windows.Forms.Button();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.BookAuthorEditor = new System.Windows.Forms.TextBox();
            this.BookLabel = new System.Windows.Forms.Label();
            this.BookLabelEditor = new System.Windows.Forms.TextBox();
            this.ChapterProppertiesPage = new System.Windows.Forms.TabPage();
            this.VariantNumberCounter = new System.Windows.Forms.NumericUpDown();
            this.ChapterPropperties_SaveChangesButton = new System.Windows.Forms.Button();
            this.VariantCountLabel = new System.Windows.Forms.Label();
            this.DictionaryLabel = new System.Windows.Forms.Label();
            this.ChapterIDLabel = new System.Windows.Forms.Label();
            this.AllowEditChapterID = new System.Windows.Forms.Button();
            this.ChapterIDEdit = new System.Windows.Forms.NumericUpDown();
            this.ChapterTextProppertiesTab = new System.Windows.Forms.TabPage();
            this.SaveChapterText = new System.Windows.Forms.Button();
            this.ChaperTextEditorLabel = new System.Windows.Forms.Label();
            this.ChapterText = new System.Windows.Forms.RichTextBox();
            this.VariantsEditorPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grid_VariantNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_VariantText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_NextChapterId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VariantsOfStoryDevelopmentLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BookEditorStrip.SuspendLayout();
            this.IntercativeBookPropperties.SuspendLayout();
            this.BookProppertiesPage.SuspendLayout();
            this.ChapterProppertiesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariantNumberCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChapterIDEdit)).BeginInit();
            this.ChapterTextProppertiesTab.SuspendLayout();
            this.VariantsEditorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BookEditorStrip
            // 
            this.BookEditorStrip.BackColor = System.Drawing.Color.BurlyWood;
            this.BookEditorStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BookEditorStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.главыToolStripMenuItem});
            this.BookEditorStrip.Location = new System.Drawing.Point(0, 0);
            this.BookEditorStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.BookEditorStrip.Name = "BookEditorStrip";
            this.BookEditorStrip.Size = new System.Drawing.Size(1006, 28);
            this.BookEditorStrip.TabIndex = 0;
            this.BookEditorStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveBookToolStripMenuItem,
            this.открытьКнигуToolStripMenuItem,
            this.CreateNewBookToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveBookToolStripMenuItem
            // 
            this.SaveBookToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.SaveBookToolStripMenuItem.Name = "SaveBookToolStripMenuItem";
            this.SaveBookToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.SaveBookToolStripMenuItem.Text = "Сохранить книгу";
            // 
            // открытьКнигуToolStripMenuItem
            // 
            this.открытьКнигуToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.открытьКнигуToolStripMenuItem.Name = "открытьКнигуToolStripMenuItem";
            this.открытьКнигуToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.открытьКнигуToolStripMenuItem.Text = "Открыть книгу";
            this.открытьКнигуToolStripMenuItem.Click += new System.EventHandler(this.открытьКнигуToolStripMenuItem_Click);
            // 
            // CreateNewBookToolStripMenuItem
            // 
            this.CreateNewBookToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.CreateNewBookToolStripMenuItem.Name = "CreateNewBookToolStripMenuItem";
            this.CreateNewBookToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.CreateNewBookToolStripMenuItem.Text = "Создать новую книгу";
            // 
            // главыToolStripMenuItem
            // 
            this.главыToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.главыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.переключитьсяToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.главыToolStripMenuItem.Name = "главыToolStripMenuItem";
            this.главыToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.главыToolStripMenuItem.Text = "Главы";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // переключитьсяToolStripMenuItem
            // 
            this.переключитьсяToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.переключитьсяToolStripMenuItem.Name = "переключитьсяToolStripMenuItem";
            this.переключитьсяToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.переключитьсяToolStripMenuItem.Text = "Переключиться";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // IntercativeBookPropperties
            // 
            this.IntercativeBookPropperties.Controls.Add(this.BookProppertiesPage);
            this.IntercativeBookPropperties.Controls.Add(this.ChapterProppertiesPage);
            this.IntercativeBookPropperties.Controls.Add(this.ChapterTextProppertiesTab);
            this.IntercativeBookPropperties.Controls.Add(this.VariantsEditorPage);
            this.IntercativeBookPropperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntercativeBookPropperties.Location = new System.Drawing.Point(0, 28);
            this.IntercativeBookPropperties.Multiline = true;
            this.IntercativeBookPropperties.Name = "IntercativeBookPropperties";
            this.IntercativeBookPropperties.SelectedIndex = 0;
            this.IntercativeBookPropperties.Size = new System.Drawing.Size(1006, 693);
            this.IntercativeBookPropperties.TabIndex = 1;
            // 
            // BookProppertiesPage
            // 
            this.BookProppertiesPage.BackColor = System.Drawing.Color.PapayaWhip;
            this.BookProppertiesPage.Controls.Add(this.Password);
            this.BookProppertiesPage.Controls.Add(this.PasswordSetupLabel);
            this.BookProppertiesPage.Controls.Add(this.PasswordSetBox);
            this.BookProppertiesPage.Controls.Add(this.BookPropperties_SaveChangesButton);
            this.BookProppertiesPage.Controls.Add(this.AuthorLabel);
            this.BookProppertiesPage.Controls.Add(this.BookAuthorEditor);
            this.BookProppertiesPage.Controls.Add(this.BookLabel);
            this.BookProppertiesPage.Controls.Add(this.BookLabelEditor);
            this.BookProppertiesPage.Location = new System.Drawing.Point(4, 29);
            this.BookProppertiesPage.Name = "BookProppertiesPage";
            this.BookProppertiesPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookProppertiesPage.Size = new System.Drawing.Size(998, 660);
            this.BookProppertiesPage.TabIndex = 0;
            this.BookProppertiesPage.Text = "Настройки книги";
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(163, 465);
            this.Password.MaxLength = 200;
            this.Password.Name = "Password";
            this.Password.PlaceholderText = "Подтверждение пароля";
            this.Password.Size = new System.Drawing.Size(661, 43);
            this.Password.TabIndex = 14;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordSetupLabel
            // 
            this.PasswordSetupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordSetupLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PasswordSetupLabel.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordSetupLabel.Location = new System.Drawing.Point(52, 349);
            this.PasswordSetupLabel.Margin = new System.Windows.Forms.Padding(10);
            this.PasswordSetupLabel.Name = "PasswordSetupLabel";
            this.PasswordSetupLabel.Padding = new System.Windows.Forms.Padding(10);
            this.PasswordSetupLabel.Size = new System.Drawing.Size(916, 54);
            this.PasswordSetupLabel.TabIndex = 13;
            this.PasswordSetupLabel.Text = "Установка пароля для книги";
            this.PasswordSetupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordSetBox
            // 
            this.PasswordSetBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordSetBox.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordSetBox.Location = new System.Drawing.Point(163, 416);
            this.PasswordSetBox.MaxLength = 200;
            this.PasswordSetBox.Name = "PasswordSetBox";
            this.PasswordSetBox.PlaceholderText = "Пароль";
            this.PasswordSetBox.Size = new System.Drawing.Size(661, 43);
            this.PasswordSetBox.TabIndex = 12;
            this.PasswordSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BookPropperties_SaveChangesButton
            // 
            this.BookPropperties_SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookPropperties_SaveChangesButton.Location = new System.Drawing.Point(801, 611);
            this.BookPropperties_SaveChangesButton.Name = "BookPropperties_SaveChangesButton";
            this.BookPropperties_SaveChangesButton.Size = new System.Drawing.Size(189, 41);
            this.BookPropperties_SaveChangesButton.TabIndex = 11;
            this.BookPropperties_SaveChangesButton.Text = "Сохранить изменения";
            this.BookPropperties_SaveChangesButton.UseVisualStyleBackColor = true;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AuthorLabel.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorLabel.Location = new System.Drawing.Point(43, 179);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(10);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Padding = new System.Windows.Forms.Padding(10);
            this.AuthorLabel.Size = new System.Drawing.Size(925, 64);
            this.AuthorLabel.TabIndex = 10;
            this.AuthorLabel.Text = "Автор книги";
            this.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookAuthorEditor
            // 
            this.BookAuthorEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookAuthorEditor.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookAuthorEditor.Location = new System.Drawing.Point(163, 256);
            this.BookAuthorEditor.MaxLength = 200;
            this.BookAuthorEditor.Name = "BookAuthorEditor";
            this.BookAuthorEditor.PlaceholderText = "Фамилия Имя/Ник";
            this.BookAuthorEditor.Size = new System.Drawing.Size(661, 43);
            this.BookAuthorEditor.TabIndex = 9;
            this.BookAuthorEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BookLabel
            // 
            this.BookLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookLabel.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookLabel.Location = new System.Drawing.Point(43, 25);
            this.BookLabel.Margin = new System.Windows.Forms.Padding(10);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Padding = new System.Windows.Forms.Padding(10);
            this.BookLabel.Size = new System.Drawing.Size(925, 64);
            this.BookLabel.TabIndex = 8;
            this.BookLabel.Text = "Название книги";
            this.BookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookLabelEditor
            // 
            this.BookLabelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookLabelEditor.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookLabelEditor.Location = new System.Drawing.Point(163, 102);
            this.BookLabelEditor.MaxLength = 200;
            this.BookLabelEditor.Name = "BookLabelEditor";
            this.BookLabelEditor.PlaceholderText = "Крутая книга";
            this.BookLabelEditor.Size = new System.Drawing.Size(661, 43);
            this.BookLabelEditor.TabIndex = 0;
            this.BookLabelEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChapterProppertiesPage
            // 
            this.ChapterProppertiesPage.BackColor = System.Drawing.Color.PapayaWhip;
            this.ChapterProppertiesPage.Controls.Add(this.VariantNumberCounter);
            this.ChapterProppertiesPage.Controls.Add(this.ChapterPropperties_SaveChangesButton);
            this.ChapterProppertiesPage.Controls.Add(this.VariantCountLabel);
            this.ChapterProppertiesPage.Controls.Add(this.DictionaryLabel);
            this.ChapterProppertiesPage.Controls.Add(this.ChapterIDLabel);
            this.ChapterProppertiesPage.Controls.Add(this.AllowEditChapterID);
            this.ChapterProppertiesPage.Controls.Add(this.ChapterIDEdit);
            this.ChapterProppertiesPage.Location = new System.Drawing.Point(4, 29);
            this.ChapterProppertiesPage.Name = "ChapterProppertiesPage";
            this.ChapterProppertiesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChapterProppertiesPage.Size = new System.Drawing.Size(998, 660);
            this.ChapterProppertiesPage.TabIndex = 1;
            this.ChapterProppertiesPage.Text = "Настройки главы";
            // 
            // VariantNumberCounter
            // 
            this.VariantNumberCounter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VariantNumberCounter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VariantNumberCounter.Location = new System.Drawing.Point(362, 403);
            this.VariantNumberCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.VariantNumberCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VariantNumberCounter.Name = "VariantNumberCounter";
            this.VariantNumberCounter.Size = new System.Drawing.Size(252, 31);
            this.VariantNumberCounter.TabIndex = 10;
            this.VariantNumberCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VariantNumberCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ChapterPropperties_SaveChangesButton
            // 
            this.ChapterPropperties_SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChapterPropperties_SaveChangesButton.Location = new System.Drawing.Point(801, 611);
            this.ChapterPropperties_SaveChangesButton.Name = "ChapterPropperties_SaveChangesButton";
            this.ChapterPropperties_SaveChangesButton.Size = new System.Drawing.Size(189, 41);
            this.ChapterPropperties_SaveChangesButton.TabIndex = 9;
            this.ChapterPropperties_SaveChangesButton.Text = "Сохранить изменения";
            this.ChapterPropperties_SaveChangesButton.UseVisualStyleBackColor = true;
            // 
            // VariantCountLabel
            // 
            this.VariantCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VariantCountLabel.AutoSize = true;
            this.VariantCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VariantCountLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VariantCountLabel.Location = new System.Drawing.Point(362, 346);
            this.VariantCountLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.VariantCountLabel.Name = "VariantCountLabel";
            this.VariantCountLabel.Size = new System.Drawing.Size(252, 24);
            this.VariantCountLabel.TabIndex = 4;
            this.VariantCountLabel.Text = "Количество вариантов";
            this.VariantCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DictionaryLabel
            // 
            this.DictionaryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DictionaryLabel.AutoSize = true;
            this.DictionaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DictionaryLabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DictionaryLabel.Location = new System.Drawing.Point(128, 283);
            this.DictionaryLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.DictionaryLabel.Name = "DictionaryLabel";
            this.DictionaryLabel.Size = new System.Drawing.Size(730, 33);
            this.DictionaryLabel.TabIndex = 3;
            this.DictionaryLabel.Text = "Настройка вариантов развития событий книги";
            this.DictionaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChapterIDLabel
            // 
            this.ChapterIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChapterIDLabel.AutoSize = true;
            this.ChapterIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChapterIDLabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChapterIDLabel.Location = new System.Drawing.Point(312, 72);
            this.ChapterIDLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.ChapterIDLabel.Name = "ChapterIDLabel";
            this.ChapterIDLabel.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.ChapterIDLabel.Size = new System.Drawing.Size(348, 43);
            this.ChapterIDLabel.TabIndex = 2;
            this.ChapterIDLabel.Text = "ID текущей главы";
            this.ChapterIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllowEditChapterID
            // 
            this.AllowEditChapterID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AllowEditChapterID.Location = new System.Drawing.Point(312, 212);
            this.AllowEditChapterID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.AllowEditChapterID.Name = "AllowEditChapterID";
            this.AllowEditChapterID.Size = new System.Drawing.Size(348, 31);
            this.AllowEditChapterID.TabIndex = 1;
            this.AllowEditChapterID.Text = "Редактировать ID текущей главы";
            this.AllowEditChapterID.UseVisualStyleBackColor = true;
            this.AllowEditChapterID.Click += new System.EventHandler(this.AllowEditChapterID_Click);
            // 
            // ChapterIDEdit
            // 
            this.ChapterIDEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChapterIDEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChapterIDEdit.Location = new System.Drawing.Point(312, 148);
            this.ChapterIDEdit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.ChapterIDEdit.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ChapterIDEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ChapterIDEdit.Name = "ChapterIDEdit";
            this.ChapterIDEdit.ReadOnly = true;
            this.ChapterIDEdit.Size = new System.Drawing.Size(348, 31);
            this.ChapterIDEdit.TabIndex = 0;
            this.ChapterIDEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChapterIDEdit.Visible = false;
            // 
            // ChapterTextProppertiesTab
            // 
            this.ChapterTextProppertiesTab.BackColor = System.Drawing.Color.PapayaWhip;
            this.ChapterTextProppertiesTab.Controls.Add(this.SaveChapterText);
            this.ChapterTextProppertiesTab.Controls.Add(this.ChaperTextEditorLabel);
            this.ChapterTextProppertiesTab.Controls.Add(this.ChapterText);
            this.ChapterTextProppertiesTab.Location = new System.Drawing.Point(4, 29);
            this.ChapterTextProppertiesTab.Name = "ChapterTextProppertiesTab";
            this.ChapterTextProppertiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChapterTextProppertiesTab.Size = new System.Drawing.Size(998, 660);
            this.ChapterTextProppertiesTab.TabIndex = 2;
            this.ChapterTextProppertiesTab.Text = "Редактор текста главы";
            // 
            // SaveChapterText
            // 
            this.SaveChapterText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChapterText.Location = new System.Drawing.Point(801, 611);
            this.SaveChapterText.Name = "SaveChapterText";
            this.SaveChapterText.Size = new System.Drawing.Size(189, 41);
            this.SaveChapterText.TabIndex = 8;
            this.SaveChapterText.Text = "Сохранить текст главы";
            this.SaveChapterText.UseVisualStyleBackColor = true;
            // 
            // ChaperTextEditorLabel
            // 
            this.ChaperTextEditorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChaperTextEditorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChaperTextEditorLabel.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChaperTextEditorLabel.Location = new System.Drawing.Point(10, 10);
            this.ChaperTextEditorLabel.Margin = new System.Windows.Forms.Padding(10);
            this.ChaperTextEditorLabel.Name = "ChaperTextEditorLabel";
            this.ChaperTextEditorLabel.Padding = new System.Windows.Forms.Padding(10);
            this.ChaperTextEditorLabel.Size = new System.Drawing.Size(980, 64);
            this.ChaperTextEditorLabel.TabIndex = 7;
            this.ChaperTextEditorLabel.Text = "Редактор текста главы";
            this.ChaperTextEditorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChapterText
            // 
            this.ChapterText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChapterText.BackColor = System.Drawing.Color.White;
            this.ChapterText.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChapterText.Location = new System.Drawing.Point(10, 82);
            this.ChapterText.MaxLength = 4096;
            this.ChapterText.Name = "ChapterText";
            this.ChapterText.Size = new System.Drawing.Size(980, 523);
            this.ChapterText.TabIndex = 6;
            this.ChapterText.Text = "Пожалуйста, откройте интерактивную книгу с помощью \"Файл\" -> \"Открыть книгу\".";
            // 
            // VariantsEditorPage
            // 
            this.VariantsEditorPage.BackColor = System.Drawing.Color.PapayaWhip;
            this.VariantsEditorPage.Controls.Add(this.button1);
            this.VariantsEditorPage.Controls.Add(this.dataGridView1);
            this.VariantsEditorPage.Controls.Add(this.VariantsOfStoryDevelopmentLabel);
            this.VariantsEditorPage.Location = new System.Drawing.Point(4, 29);
            this.VariantsEditorPage.Name = "VariantsEditorPage";
            this.VariantsEditorPage.Padding = new System.Windows.Forms.Padding(3);
            this.VariantsEditorPage.Size = new System.Drawing.Size(998, 660);
            this.VariantsEditorPage.TabIndex = 3;
            this.VariantsEditorPage.Text = "Настройка вариантов развития сюжета";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(803, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grid_VariantNumber,
            this.Grid_VariantText,
            this.Grid_NextChapterId});
            this.dataGridView1.GridColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.Location = new System.Drawing.Point(28, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(942, 477);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Grid_VariantNumber
            // 
            this.Grid_VariantNumber.Frozen = true;
            this.Grid_VariantNumber.HeaderText = "Номер варианта";
            this.Grid_VariantNumber.MaxInputLength = 10;
            this.Grid_VariantNumber.MinimumWidth = 6;
            this.Grid_VariantNumber.Name = "Grid_VariantNumber";
            this.Grid_VariantNumber.ReadOnly = true;
            this.Grid_VariantNumber.Width = 142;
            // 
            // Grid_VariantText
            // 
            this.Grid_VariantText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grid_VariantText.HeaderText = "Текст варианта";
            this.Grid_VariantText.MinimumWidth = 6;
            this.Grid_VariantText.Name = "Grid_VariantText";
            // 
            // Grid_NextChapterId
            // 
            this.Grid_NextChapterId.HeaderText = "Переход на главу с выбранным ID";
            this.Grid_NextChapterId.MinimumWidth = 6;
            this.Grid_NextChapterId.Name = "Grid_NextChapterId";
            this.Grid_NextChapterId.Width = 107;
            // 
            // VariantsOfStoryDevelopmentLabel
            // 
            this.VariantsOfStoryDevelopmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantsOfStoryDevelopmentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VariantsOfStoryDevelopmentLabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VariantsOfStoryDevelopmentLabel.Location = new System.Drawing.Point(28, 27);
            this.VariantsOfStoryDevelopmentLabel.Margin = new System.Windows.Forms.Padding(5);
            this.VariantsOfStoryDevelopmentLabel.Name = "VariantsOfStoryDevelopmentLabel";
            this.VariantsOfStoryDevelopmentLabel.Padding = new System.Windows.Forms.Padding(5);
            this.VariantsOfStoryDevelopmentLabel.Size = new System.Drawing.Size(942, 43);
            this.VariantsOfStoryDevelopmentLabel.TabIndex = 12;
            this.VariantsOfStoryDevelopmentLabel.Text = "Варианты развития сюжета";
            this.VariantsOfStoryDevelopmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.IntercativeBookPropperties);
            this.Controls.Add(this.BookEditorStrip);
            this.MainMenuStrip = this.BookEditorStrip;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "BookEditor";
            this.Text = "Interactive Book Editor";
            this.Load += new System.EventHandler(this.BookEditor_Load);
            this.BookEditorStrip.ResumeLayout(false);
            this.BookEditorStrip.PerformLayout();
            this.IntercativeBookPropperties.ResumeLayout(false);
            this.BookProppertiesPage.ResumeLayout(false);
            this.BookProppertiesPage.PerformLayout();
            this.ChapterProppertiesPage.ResumeLayout(false);
            this.ChapterProppertiesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariantNumberCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChapterIDEdit)).EndInit();
            this.ChapterTextProppertiesTab.ResumeLayout(false);
            this.VariantsEditorPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip BookEditorStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьКнигуToolStripMenuItem;
        private ToolStripMenuItem SaveBookToolStripMenuItem;
        private ToolStripMenuItem главыToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem переключитьсяToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TabControl IntercativeBookPropperties;
        private TabPage BookProppertiesPage;
        private TabPage ChapterProppertiesPage;
        private TabPage ChapterTextProppertiesTab;
        private RichTextBox ChapterText;
        private Label ChaperTextEditorLabel;
        private ToolStripMenuItem CreateNewBookToolStripMenuItem;
        private Button SaveChapterText;
        private TextBox BookLabelEditor;
        private Label BookLabel;
        private Label AuthorLabel;
        private TextBox BookAuthorEditor;
        private Label DictionaryLabel;
        private Label ChapterIDLabel;
        private Button AllowEditChapterID;
        private NumericUpDown ChapterIDEdit;
        private Label VariantCountLabel;
        private Button ChapterPropperties_SaveChangesButton;
        private Button BookPropperties_SaveChangesButton;
        private NumericUpDown VariantNumberCounter;
        private TabPage VariantsEditorPage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private Label VariantsOfStoryDevelopmentLabel;
        private DataGridViewTextBoxColumn Grid_VariantNumber;
        private DataGridViewTextBoxColumn Grid_VariantText;
        private DataGridViewComboBoxColumn Grid_NextChapterId;
        private Button button1;
        private TextBox Password;
        private Label PasswordSetupLabel;
        private TextBox PasswordSetBox;
    }
}