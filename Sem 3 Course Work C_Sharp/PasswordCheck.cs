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
    public partial class PasswordCheck : Form
    {
        private string book_password;

        private string key = "IBR4EVER";

        public PasswordCheck()
        {
            InitializeComponent();
        }
        public PasswordCheck(string _pswrd )
        {
            InitializeComponent();
            Viginer_95 Decrypt = new ();
            Decrypt.Set_Message(_pswrd);
            Decrypt.Set_Key(key);
            book_password = Decrypt.Decrypt();
        }

        private void PasswordCheckButton_Click(object sender, EventArgs e)
        {
            string incerted_password = PasswordCheckBox.Text.ToString();
            if (incerted_password == book_password) { 
                
                Close();
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
