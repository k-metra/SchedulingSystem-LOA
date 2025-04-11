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
    }
}
