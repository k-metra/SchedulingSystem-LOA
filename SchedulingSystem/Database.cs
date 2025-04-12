using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystem
{
    internal class Database
    {
        private static MySqlConnection connection;
        private static MySqlCommand command;
        private static MySqlDataAdapter adapter;
        private static readonly DataTable dataTable = new DataTable();
        private static string? query;

        private static Account? currentAcc;


        public static MySqlConnection? Connection { get { return connection; } }
        public static void Connect()
        {
            if (connection == null)
            {
                connection = new MySqlConnection("server=127.0.0.1;database=SchedulingDB;user=root;pwd=;");
            }

            connection.Open();
        }

        public static void Disconnect()
        {
            if (connection != null) connection.Close();
        }

        public static string Query { get; set; }

        public static MySqlCommand setCommand()
        {
            command = new MySqlCommand();
            

            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            command.CommandText = Query;

            return command;
        }

        public static void createNewSchedule(
            string subjName, string subjCode, string specialization,
            string room, string teacher, string section, string grade, DateTime date)
        {
            Query =
                "INSERT INTO schedules (subjName, subjCode, specialization, room, teacher, section, gradeLevel, `date`) VALUES (@subjName, @subjCode, @specialization, @room, @teacher, @section, @grade, @dt)";
            MySqlCommand cmd = setCommand();
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@subjName", subjName);
            cmd.Parameters.AddWithValue("@subjCode", subjCode);
            cmd.Parameters.AddWithValue("@specialization", specialization);
            cmd.Parameters.AddWithValue("@room", room);
            cmd.Parameters.AddWithValue("@teacher", teacher);
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.Parameters.AddWithValue("@dt", date);
            cmd.Parameters.AddWithValue("@section", section);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected < 1)
            {
                MessageBox.Show("Something went wrong with creating the schedule.", "Error");
            } else
            {
                MessageBox.Show("Created new schedule.");
            }
        }

        public static DataTable resolveToDataTable()
        {
            MySqlCommand cmd = setCommand();
            adapter = new MySqlDataAdapter(cmd);

            dataTable.Clear();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public static DataTable resolveToDataTable(MySqlCommand cmd)
        {
            adapter = new MySqlDataAdapter(cmd);

            dataTable.Clear();
            adapter.Fill(dataTable);

            return dataTable;
        } 

        public static void addParameter(string param, string value)
        {
            command.Parameters.AddWithValue(param, value);
        }

        public static Account? currentAccount
        {
            get { return currentAcc;  } set { currentAcc = value; }
        }

        public static ClearanceLevel parseEnum(String str)
        {
            return (ClearanceLevel) Enum.Parse(typeof(ClearanceLevel), str);
        }

        public static int parseEnum(ClearanceLevel level)
        {
            return (int) level;
        }

        public static void createNewAccount(String username, string password, string fullName, ClearanceLevel level)
        {
            Query = "INSERT INTO accounts (username, `password`, full_name, clearance_level) VALUES (@user, @pass, @fn, @level) ";
            MySqlCommand cmd = setCommand();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@fn", fullName);
            cmd.Parameters.AddWithValue("@level", level.ToString());

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected < 1)
            {
                MessageBox.Show("Something went wrong trying to create the account.");
            }
        }


        public class Account
        {
            private string accountId;

            public string AccountId { get { return accountId;  } set {  accountId = value; } }
            public string fullName { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public ClearanceLevel clearanceLevel { get; set; } = ClearanceLevel.GUEST;
            public Boolean loggedIn { get; set; } = false;


            public Account(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

            public Account? Login()
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username or password is null or empty!");
                    return this;
                }

                Query = "SELECT * FROM accounts WHERE binary `username` = @user AND binary `password` = @pass";
                MySqlCommand cmd = setCommand();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@user", this.username);
                cmd.Parameters.AddWithValue("@pass", this.password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    loggedIn = true;
                    this.AccountId = reader["account_id"].ToString();
                    this.fullName = reader["full_name"].ToString();
                    this.clearanceLevel = parseEnum(reader["clearance_level"].ToString());
                    currentAccount = this;
                }

                reader.Close();
                return this;
            }

            public void Logout()
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to logout?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr.Equals(DialogResult.Yes)) {
                    loggedIn = false;
                    currentAccount = null;
                }
            }

            public void Save()
            {
                Query = "UPDATE accounts SET username = @user, `password` = @pass, full_name = @fn WHERE account_id = @id";
                MySqlCommand cmd = setCommand();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@fn", fullName);
                cmd.Parameters.AddWithValue("@id", AccountId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected < 1) MessageBox.Show("Something went wrong trying to save the information."); return;

                MessageBox.Show("Successfully saved.");
            }
        }
    }
}
