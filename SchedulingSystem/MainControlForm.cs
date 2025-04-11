using SchedulingSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSystem
{
    public partial class MainControlForm : Form
    {
        LoginForm loginForm;
        public MainControlForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            if (Database.parseEnum(Database.currentAccount.clearanceLevel) > 1) userMgtBtn.Enabled = true;
            addControl(new Home());
        }

        private void addControl(UserControl ctrl)
        {
            ctrl.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(ctrl);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Home homeTab = new Home();
            addControl(homeTab);
        }

        private void userMgtBtn_Click(object sender, EventArgs e)
        {
            addControl(new UserManagement());
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            addControl(new Settings(this));
        }

        public void Logout()
        {
            loginForm.Show();
            this.Close();
        }
    }
}
