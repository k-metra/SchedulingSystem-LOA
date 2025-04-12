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

namespace SchedulingSystem.UserControls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            SchedulesList.Items.Clear();

            Database.Query = "SELECT * FROM schedules";
            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(Database.setCommand());
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["subjCode"].ToString();
                item.SubItems.Add(row["subjName"].ToString());
                item.SubItems.Add(row["specialization"].ToString());
                item.SubItems.Add(row["gradeLevel"].ToString());
                item.SubItems.Add(row["room"].ToString());
                item.SubItems.Add(row["teacher"].ToString());
                item.SubItems.Add(row["section"].ToString());
                item.SubItems.Add(row["date"].ToString());

                SchedulesList.Items.Add(item);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NewSchedule newSched = new NewSchedule(this);
            newSched.ShowDialog(this);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this schedule?");

            if (dr.Equals(DialogResult.No)) return;


            ListViewItem item = SchedulesList.SelectedItems[0];

            Database.Query = "DELETE FROM schedules WHERE subjName = @name AND subjCode = @code";
            MySqlCommand cmd = Database.setCommand();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", item.SubItems[1].Text);
            cmd.Parameters.AddWithValue("@code", item.Text);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected < 1)
            {
                MessageBox.Show("Something went wrong trying to delete the schedule.");
            }
            else
            {
                MessageBox.Show("Deleted schedule.");
            }

            refresh();
            SchedulesList.SelectedItems.Clear();
        }

        public void Logout()
        {

        }

        private void SchedulesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            modifyBtn.Enabled = (SchedulesList.SelectedItems.Count > 0);
            deleteBtn.Enabled = (SchedulesList.SelectedItems.Count > 0);
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = SchedulesList.SelectedItems[0];
            NewSchedule scheduleControl = new NewSchedule(this);
            scheduleControl.setTitle("MODIFY SCHEDULE");
            scheduleControl.updateInformation(
                selectedItem.SubItems[1].Text,
                selectedItem.SubItems[0].Text,
                selectedItem.SubItems[2].Text,
                selectedItem.SubItems[3].Text,
                selectedItem.SubItems[4].Text,
                selectedItem.SubItems[5].Text,
                selectedItem.SubItems[6].Text,
                DateTime.Parse(selectedItem.SubItems[7].Text)
                );
            scheduleControl.ShowDialog(this);
        }

        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchBox.Text)) { refresh(); return; }

            string searchQuery = searchBox.Text;
            string sortQuery = (!String.IsNullOrEmpty(sortBox.Text)) ? sortBox.Text : "NONE";


            // convert query to readable parameter for MySQL
            switch (sortQuery)
            {
                case "SUBJECT NAME":
                    sortQuery = "subjName";
                    break;
                case "SUBJECT CODE":
                    sortQuery = "subjCode";
                    break;
                case "GRADE LEVEL":
                    sortQuery = "gradeLevel";
                    break;
                default:
                    // Keep it as-is, but make it lowercase
                    sortQuery = sortQuery.ToLower();
                    break;
            }

            string newQuery;

            if (sortQuery.Equals("none"))
            {
                newQuery = "SELECT * FROM schedules WHERE @value in (schedule_id, subjName, subjCode, specialization, gradeLevel, room, teacher, section)";
            } else
            {
                newQuery = $"SELECT * FROM schedules WHERE {sortQuery} = @value";
            }

            Database.Query = newQuery;
            MySqlCommand cmd = new MySqlCommand(Database.Query, Database.Connection);
            cmd.Parameters.AddWithValue("@value", searchQuery);
            DataTable dt = Database.resolveToDataTable(cmd);

            SchedulesList.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["subjCode"].ToString();

                item.SubItems.Add(dr["subjName"].ToString());
                item.SubItems.Add(dr["specialization"].ToString());
                item.SubItems.Add(dr["gradeLevel"].ToString());
                item.SubItems.Add(dr["room"].ToString());
                item.SubItems.Add(dr["teacher"].ToString());
                item.SubItems.Add(dr["section"].ToString());
                item.SubItems.Add(dr["date"].ToString());
                SchedulesList.Items.Add(item);
            }
        }
    }



}
