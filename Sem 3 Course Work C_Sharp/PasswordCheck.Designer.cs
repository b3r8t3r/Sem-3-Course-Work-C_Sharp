﻿namespace Sem_3_Course_Work_C_Sharp
{
    partial class PasswordCheck
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
            this.PasswordCheckButton = new System.Windows.Forms.Button();
            this.PasswordCheckLabel = new System.Windows.Forms.Label();
            this.PasswordCheckBox = new System.Windows.Forms.TextBox();
            this.UndoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordCheckButton
            // 
            this.PasswordCheckButton.Location = new System.Drawing.Point(436, 406);
            this.PasswordCheckButton.Name = "PasswordCheckButton";
            this.PasswordCheckButton.Size = new System.Drawing.Size(150, 29);
            this.PasswordCheckButton.TabIndex = 0;
            this.PasswordCheckButton.Text = "Подтвердить";
            this.PasswordCheckButton.UseVisualStyleBackColor = true;
            this.PasswordCheckButton.Click += new System.EventHandler(this.PasswordCheckButton_Click);
            // 
            // PasswordCheckLabel
            // 
            this.PasswordCheckLabel.AutoSize = true;
            this.PasswordCheckLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PasswordCheckLabel.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordCheckLabel.Location = new System.Drawing.Point(407, 286);
            this.PasswordCheckLabel.Margin = new System.Windows.Forms.Padding(96, 0, 3, 30);
            this.PasswordCheckLabel.Name = "PasswordCheckLabel";
            this.PasswordCheckLabel.Size = new System.Drawing.Size(210, 29);
            this.PasswordCheckLabel.TabIndex = 1;
            this.PasswordCheckLabel.Text = "Введите пароль";
            // 
            // PasswordCheckBox
            // 
            this.PasswordCheckBox.Location = new System.Drawing.Point(407, 346);
            this.PasswordCheckBox.Margin = new System.Windows.Forms.Padding(125, 3, 0, 30);
            this.PasswordCheckBox.Name = "PasswordCheckBox";
            this.PasswordCheckBox.PlaceholderText = "Пароль книги";
            this.PasswordCheckBox.Size = new System.Drawing.Size(208, 27);
            this.PasswordCheckBox.TabIndex = 2;
            this.PasswordCheckBox.UseSystemPasswordChar = true;
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(436, 441);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(150, 29);
            this.UndoButton.TabIndex = 3;
            this.UndoButton.Text = "Отменить ввод";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // PasswordCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.PasswordCheckBox);
            this.Controls.Add(this.PasswordCheckLabel);
            this.Controls.Add(this.PasswordCheckButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordCheck";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PasswordCheckButton;
        private Label PasswordCheckLabel;
        private TextBox PasswordCheckBox;
        private Button UndoButton;
    }
}