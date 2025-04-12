using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSystem.UserControls.SettingsWindows.AccountWindows
{
    public partial class ChangePassword : Form
    {
        AccountSettings accSettings;
        public ChangePassword(AccountSettings accSettings)
        {
            InitializeComponent();
            this.accSettings = accSettings;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string currentPass = currentPassBox.Text;
            string newPass = newPassBox.Text; string reEnter = reEnterPassBox.Text;

            if (!(currentPass == Database.currentAccount.password))
            {
                MessageBox.Show("Password is incorrect.");
                return;
            }

            if (!(newPass == reEnter))
            {
                MessageBox.Show("Passwords do not match."); return;
            }

            if (String.IsNullOrEmpty(newPass) || String.IsNullOrEmpty(reEnter))
            {
                MessageBox.Show("Password is empty.");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to change your password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr.Equals(DialogResult.Yes))
            {
                Database.currentAccount.password = newPass;
                accSettings.toggleSaveBtn(true);
                this.Close();
            }
        }
    }
}
