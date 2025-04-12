using SchedulingSystem.UserControls.SettingsWindows.AccountWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSystem.UserControls.SettingsWindows
{
    public partial class AccountSettings : UserControl
    {
        public AccountSettings()
        {
            InitializeComponent();
            userBox.Text = Database.currentAccount.username;
            passBox.Text = Database.currentAccount.password;
            fullName.Text = Database.currentAccount.fullName;
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePassWindow = new ChangePassword(this);
            changePassWindow.ShowDialog(this);
        }

        public void toggleSaveBtn(Boolean boolean)
        {
            this.saveBtn.Enabled = boolean;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userBox.Text) || String.IsNullOrEmpty(fullName.Text))
            {
                MessageBox.Show("Please make sure all information is filled in!");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to overwrite your current information with the provided details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) return;
            Database.currentAccount.username = userBox.Text;
            Database.currentAccount.fullName = fullName.Text;

            Database.currentAccount.Save();
            toggleSaveBtn(false);
        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {
            toggleSaveBtn(true);
        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {
            toggleSaveBtn(true);
        }
    }
}
