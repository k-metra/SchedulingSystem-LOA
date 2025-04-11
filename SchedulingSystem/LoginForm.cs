using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSystem
{
    public partial class LoginForm : Form
    {
        BackgroundForm backgroundForm;
        public LoginForm(BackgroundForm bgForm)
        {
            InitializeComponent();
            this.backgroundForm = bgForm;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            showPassBtn.ImageIndex = showPassBtn.ImageIndex == 0 ? 1 : 0;
            passBox.UseSystemPasswordChar = (showPassBtn.ImageIndex == 0);
        }

        public void input_KeyPress(object sender, KeyEventArgs e)
        {
            
        }

        public void logInClicked()
        {
            string user = userBox.Text;
            string pass = passBox.Text;

            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass)) { alertText.Visible = true; return; }
            Database.Account account = new Database.Account(user, pass);

            account.Login();

            if (!(account.loggedIn))
            {
                alertText.Visible = true; return;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            string user = userBox.Text;
            string pass = passBox.Text;

            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass)) { alertText.Visible = true; return; }
            Database.Account account = new Database.Account(user, pass);

            account.Login();

            if (!(account.loggedIn))
            {
                alertText.Visible = true; return;
            }

            MainControlForm ctrlForm = new MainControlForm(this);
            ctrlForm.Show(this);
            this.Hide();
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                logInClicked();
                MessageBox.Show("test");
                e.Handled = true;
            }
              
        }
    }
}
