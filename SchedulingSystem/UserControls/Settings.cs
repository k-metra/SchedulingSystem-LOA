using SchedulingSystem.UserControls.SettingsWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSystem.UserControls
{
    public partial class Settings : UserControl
    {
        MainControlForm mainForm;
        public Settings(MainControlForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            addControl(new AccountSettings());
        }

        private void addControl(Control control)
        {
            settingsPanel.Controls.Clear();
            settingsPanel.Controls.Add(control);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Database.Account currentAcc = Database.currentAccount;

            currentAcc.Logout();

            if (currentAcc.loggedIn == false)
            {

            }
            mainForm.Logout();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addControl(new AccountSettings());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            addControl(new About());
        }
    }
}
