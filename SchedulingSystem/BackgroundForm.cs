namespace SchedulingSystem
{
    public partial class BackgroundForm : Form
    {
        public BackgroundForm()
        {
            InitializeComponent();
        }

        public void BackgroundForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.Show(this);

            Database.Connect();
        }

        public void exitBtn_Click(object sender, EventArgs e)
        {
            Database.Disconnect();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
