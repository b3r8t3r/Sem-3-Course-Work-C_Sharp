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
        public PasswordCheck()
        {
            InitializeComponent();
        }

        private void PasswordCheckButton_Click(object sender, EventArgs e)
        {
            string incerted_password = PasswordCheckBox.Text.ToString();
            
        }
    }
}
