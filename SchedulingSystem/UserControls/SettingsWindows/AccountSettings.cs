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
    }
}
