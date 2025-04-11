using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSystem.UserControls.AccountControls
{
    public partial class NewAccount : Form
    {
        UserManagement userMgt;
        String selectedId;

        public void setId(String id)
        {
            this.selectedId = id;
        }
        public NewAccount(UserManagement userMgt)
        {
            InitializeComponent();
            this.userMgt = userMgt;

            String[] clearanceLevels =
            {
                "GUEST",
                "FACULTY",
                "GUIDANCE",
                "ADMINISTRATION"
            };

            for (int i = 0; i < Database.parseEnum(Database.currentAccount.clearanceLevel); i++)
            {
                levelBox.Items.Add(clearanceLevels[i]);
            }
        }

        public void setTitle(String str)
        {
            this.Title.Text = str;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void updateInformation(string user, string pass, string fullName, string level)
        {
            userBox.Text = user;
            passBox.Text = pass;
            fullNameBox.Text = fullName;
            levelBox.SelectedIndex = levelBox.Items.IndexOf(level);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string user = userBox.Text;
            string pass = passBox.Text;
            string fullName = fullNameBox.Text;
            ClearanceLevel level = Database.parseEnum(levelBox.Text);

            if (Title.Text == "MODIFY ACCOUNT")
            {
                Database.Query = "UPDATE accounts SET username = @user, `password` = @pass, full_name = @fn, clearance_level = @level WHERE account_id = @id";
                MySqlCommand cmd = Database.setCommand();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@fn", fullName);
                cmd.Parameters.AddWithValue("@level", level.ToString());
                cmd.Parameters.AddWithValue("@id", selectedId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected < 1)
                {
                    MessageBox.Show("There was an error trying to modify the account.");

                }
                else
                {
                    MessageBox.Show("Successfully modified account.");
                }
            }
            else
            {
                Database.createNewAccount(user, pass, fullName, level);
            }

            userMgt.refresh();
            this.Close();

        }

        private void levelBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
