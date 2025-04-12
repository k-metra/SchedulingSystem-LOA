namespace SchedulingSystem.UserControls
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SchedulesList = new ListView();
            subjCode = new ColumnHeader();
            subjName = new ColumnHeader();
            specialization = new ColumnHeader();
            gradeLevel = new ColumnHeader();
            room = new ColumnHeader();
            teacher = new ColumnHeader();
            section = new ColumnHeader();
            date = new ColumnHeader();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            modifyBtn = new Guna.UI2.WinForms.Guna2Button();
            deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            sortBox = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            SuspendLayout();
            // 
            // SchedulesList
            // 
            SchedulesList.Columns.AddRange(new ColumnHeader[] { subjCode, subjName, specialization, gradeLevel, room, teacher, section, date });
            SchedulesList.FullRowSelect = true;
            SchedulesList.Location = new Point(3, 3);
            SchedulesList.MultiSelect = false;
            SchedulesList.Name = "SchedulesList";
            SchedulesList.Size = new Size(526, 266);
            SchedulesList.TabIndex = 0;
            SchedulesList.UseCompatibleStateImageBehavior = false;
            SchedulesList.View = View.Details;
            SchedulesList.SelectedIndexChanged += SchedulesList_SelectedIndexChanged;
            // 
            // subjCode
            // 
            subjCode.Text = "Subject Code";
            subjCode.Width = 120;
            // 
            // subjName
            // 
            subjName.Text = "Subject Name";
            subjName.Width = 240;
            // 
            // specialization
            // 
            specialization.Text = "Specialization";
            specialization.Width = 100;
            // 
            // gradeLevel
            // 
            gradeLevel.Text = "Gr. Level";
            // 
            // room
            // 
            room.Text = "Room";
            // 
            // teacher
            // 
            teacher.Text = "Teacher";
            teacher.Width = 110;
            // 
            // section
            // 
            section.Text = "Section";
            section.Width = 90;
            // 
            // date
            // 
            date.Text = "Date & Time";
            date.Width = 120;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(535, 3);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(170, 54);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "CREATE";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // modifyBtn
            // 
            modifyBtn.CustomizableEdges = customizableEdges3;
            modifyBtn.DisabledState.BorderColor = Color.DarkGray;
            modifyBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            modifyBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            modifyBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            modifyBtn.Enabled = false;
            modifyBtn.FillColor = Color.White;
            modifyBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modifyBtn.ForeColor = Color.Black;
            modifyBtn.Location = new Point(535, 63);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            modifyBtn.Size = new Size(170, 54);
            modifyBtn.TabIndex = 2;
            modifyBtn.Text = "MODIFY";
            modifyBtn.Click += modifyBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.CustomizableEdges = customizableEdges5;
            deleteBtn.DisabledState.BorderColor = Color.DarkGray;
            deleteBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            deleteBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deleteBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deleteBtn.Enabled = false;
            deleteBtn.FillColor = Color.White;
            deleteBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.Black;
            deleteBtn.Location = new Point(535, 123);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            deleteBtn.Size = new Size(170, 54);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "DELETE";
            deleteBtn.Click += guna2Button3_Click;
            // 
            // guna2Button4
            // 
            guna2Button4.CustomizableEdges = customizableEdges7;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.White;
            guna2Button4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button4.ForeColor = Color.Black;
            guna2Button4.Location = new Point(535, 183);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button4.Size = new Size(170, 54);
            guna2Button4.TabIndex = 4;
            guna2Button4.Text = "REFRESH";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // searchBox
            // 
            searchBox.CustomizableEdges = customizableEdges9;
            searchBox.DefaultText = "";
            searchBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBox.Font = new Font("Segoe UI", 9F);
            searchBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBox.Location = new Point(13, 275);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "";
            searchBox.SelectedText = "";
            searchBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            searchBox.Size = new Size(200, 36);
            searchBox.TabIndex = 5;
            // 
            // sortBox
            // 
            sortBox.BackColor = Color.Transparent;
            sortBox.CustomizableEdges = customizableEdges11;
            sortBox.DrawMode = DrawMode.OwnerDrawFixed;
            sortBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortBox.FocusedColor = Color.FromArgb(94, 148, 255);
            sortBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            sortBox.Font = new Font("Segoe UI", 10F);
            sortBox.ForeColor = Color.FromArgb(68, 88, 112);
            sortBox.ItemHeight = 30;
            sortBox.Items.AddRange(new object[] { "NONE", "SUBJECT CODE", "SUBJECT NAME", "SPECIALIZATION", "GRADE LEVEL", "SECTION", "ROOM", "TEACHER" });
            sortBox.Location = new Point(219, 275);
            sortBox.Name = "sortBox";
            sortBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            sortBox.Size = new Size(165, 36);
            sortBox.TabIndex = 6;
            sortBox.SelectedIndexChanged += sortBox_SelectedIndexChanged;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.BackgroundImage = Properties.Resources.search_line;
            guna2ImageButton1.BackgroundImageLayout = ImageLayout.Center;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(0, 0);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(0, 0);
            guna2ImageButton1.Location = new Point(390, 275);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges13;
            guna2ImageButton1.Size = new Size(36, 36);
            guna2ImageButton1.TabIndex = 7;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(guna2ImageButton1);
            Controls.Add(sortBox);
            Controls.Add(searchBox);
            Controls.Add(guna2Button4);
            Controls.Add(deleteBtn);
            Controls.Add(modifyBtn);
            Controls.Add(guna2Button1);
            Controls.Add(SchedulesList);
            Name = "Home";
            Size = new Size(708, 335);
            ResumeLayout(false);
        }

        #endregion

        private ListView SchedulesList;
        private ColumnHeader subjCode;
        private ColumnHeader subjName;
        private ColumnHeader specialization;
        private ColumnHeader gradeLevel;
        private ColumnHeader room;
        private ColumnHeader teacher;
        private ColumnHeader section;
        private ColumnHeader date;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button modifyBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2ComboBox sortBox;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}
