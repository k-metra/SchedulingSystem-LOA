using MySql.Data.MySqlClient;
using SchedulingSystem.UserControls.AccountControls;
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
    public partial class UserManagement : UserControl
    {
        public UserManagement()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            Database.Query = "SELECT * FROM accounts";
            DataTable dt = Database.resolveToDataTable();

            AccountsList.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["account_id"].ToString();
                item.SubItems.Add(dr["username"].ToString());
                item.SubItems.Add("Modify to show");
                item.SubItems.Add(dr["full_name"].ToString());
                item.SubItems.Add(dr["clearance_level"].ToString());
                item.SubItems.Add(dr["password"].ToString());

                AccountsList.Items.Add(item);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void AccountsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            modifyBtn.Enabled = (AccountsList.SelectedItems.Count > 0);
            deleteBtn.Enabled = (AccountsList.SelectedItems.Count > 0);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = AccountsList.SelectedItems[0];

            string account_id = selectedItem.SubItems[0].Text;
            ClearanceLevel level = (ClearanceLevel)Enum.Parse(typeof(ClearanceLevel), selectedItem.SubItems[4].Text);

            if (Database.currentAccount.clearanceLevel <= level)
            {
                MessageBox.Show("User is on equal or greater administrative levels.");
                return;
            }

            Database.Query = "DELETE FROM accounts WHERE account_id = @id";
            MySqlCommand cmd = Database.setCommand();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", account_id);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected < 1)
            {
                MessageBox.Show("There was a problem deleting the account.");

            }
            else
            {
                MessageBox.Show("Deleted account");
            }

            refresh();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            NewAccount accountPanel = new NewAccount(this);
            accountPanel.ShowDialog(this);
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = AccountsList.SelectedItems[0];

            String account_id = selectedItem.SubItems[0].Text;
            String username = selectedItem.SubItems[1].Text;
            string password = selectedItem.SubItems[5].Text;
            string fullName = selectedItem.SubItems[3].Text;
            string level = selectedItem.SubItems[4].Text;

            NewAccount accountPanel = new NewAccount(this);
            accountPanel.setTitle("MODIFY ACCOUNT");
            accountPanel.setId(account_id);

            accountPanel.updateInformation(username, password, fullName, level);
            accountPanel.ShowDialog(this);
        }
    }
}
