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
    public partial class NewSchedule : Form
    {
        Home home;
        private string oldSubjCode;
        public NewSchedule(Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        public void setTitle(String str)
        {
            this.Title.Text = str;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            String subjName = subjNameBox.Text;
            String subjCode = subjCodeBox.Text;
            String specialization = specializationBox.Text;
            String gradeLevel = gradeBox.Text;
            String room = roomBox.Text;
            String teacher = teacherBox.Text;
            String section = sectionBox.Text;
            DateTime date = dateTimePicker.Value;

            if (Title.Text == "MODIFY SCHEDULE")
            {
                Database.Query = "UPDATE schedules SET subjName = @name, subjCode = @code, specialization = @spec, room = @room, teacher = @teacher, section = @section, gradeLevel = @grade, date = @dt WHERE subjCode = @oldCode";
                MySqlCommand cmd = Database.setCommand();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", subjName);
                cmd.Parameters.AddWithValue("@code", subjCode);
                cmd.Parameters.AddWithValue("@spec", specialization);
                cmd.Parameters.AddWithValue("@room", room);
                cmd.Parameters.AddWithValue("@teacher", teacher);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@dt", date);
                cmd.Parameters.AddWithValue("@grade", gradeLevel);
                cmd.Parameters.AddWithValue("@oldCode", oldSubjCode);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected < 1)
                {
                    MessageBox.Show("Something went wrong.");
                } else
                {
                    MessageBox.Show("Modified schedule.");
                }
            }
            else
            {
                Database.createNewSchedule(subjName, subjCode,
                specialization, room, teacher, section, gradeLevel, date);
                
            }


            home.refresh();
            this.Close();

        }

        public void updateInformation(string subjName, string subjCode, string specialization, string gradeLevel, string room, string teacher, string section, DateTime date)
        {
            subjNameBox.Text = subjName;
            subjCodeBox.Text = subjCode;
            specializationBox.Text = specialization;
            gradeBox.Text = gradeLevel;
            roomBox.Text = room;
            teacherBox.Text = teacher;
            sectionBox.Text = section;
            dateTimePicker.Value = date;

            oldSubjCode = subjCode;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
