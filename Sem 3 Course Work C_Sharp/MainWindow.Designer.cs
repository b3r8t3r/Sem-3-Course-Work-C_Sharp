namespace Sem_3_Course_Work_C_Sharp
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ChoiceOptions = new System.Windows.Forms.ComboBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.BookLabel = new System.Windows.Forms.Label();
            this.ChapterText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ChoiceOptions
            // 
            this.ChoiceOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceOptions.Font = new System.Drawing.Font("Cascadia Code Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceOptions.FormattingEnabled = true;
            this.ChoiceOptions.Items.AddRange(new object[] {
            "asd",
            "asdfg",
            "asdfghj"});
            this.ChoiceOptions.Location = new System.Drawing.Point(8, 668);
            this.ChoiceOptions.Name = "ChoiceOptions";
            this.ChoiceOptions.Size = new System.Drawing.Size(866, 30);
            this.ChoiceOptions.TabIndex = 2;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AcceptButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptButton.Location = new System.Drawing.Point(880, 668);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(118, 30);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "button1";
            this.AcceptButton.UseVisualStyleBackColor = false;
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookLabel.Location = new System.Drawing.Point(438, 18);
            this.BookLabel.Margin = new System.Windows.Forms.Padding(10);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Padding = new System.Windows.Forms.Padding(10);
            this.BookLabel.Size = new System.Drawing.Size(140, 64);
            this.BookLabel.TabIndex = 4;
            this.BookLabel.Text = "BookLabel";
            this.BookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChapterText
            // 
            this.ChapterText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChapterText.BackColor = System.Drawing.Color.White;
            this.ChapterText.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChapterText.Location = new System.Drawing.Point(8, 91);
            this.ChapterText.Name = "ChapterText";
            this.ChapterText.ReadOnly = true;
            this.ChapterText.Size = new System.Drawing.Size(990, 571);
            this.ChapterText.TabIndex = 5;
            this.ChapterText.Text = resources.GetString("ChapterText.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.ChapterText);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ChoiceOptions);
            this.MaximumSize = new System.Drawing.Size(2540, 1600);
            this.MinimumSize = new System.Drawing.Size(640, 0);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Book Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox ChoiceOptions;
        private Button AcceptButton;
        private Label BookLabel;
        private RichTextBox ChapterText;
    }
}