namespace SchedulingSystem.UserControls
{
    partial class UserManagement
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
            AccountsList = new ListView();
            account_id = new ColumnHeader();
            username = new ColumnHeader();
            password = new ColumnHeader();
            full_name = new ColumnHeader();
            clearance_level = new ColumnHeader();
            realPassword = new ColumnHeader();
            refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            modifyBtn = new Guna.UI2.WinForms.Guna2Button();
            createBtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // AccountsList
            // 
            AccountsList.Columns.AddRange(new ColumnHeader[] { account_id, username, password, full_name, clearance_level, realPassword });
            AccountsList.FullRowSelect = true;
            AccountsList.Location = new Point(3, 3);
            AccountsList.MultiSelect = false;
            AccountsList.Name = "AccountsList";
            AccountsList.Size = new Size(526, 266);
            AccountsList.TabIndex = 0;
            AccountsList.UseCompatibleStateImageBehavior = false;
            AccountsList.View = View.Details;
            AccountsList.SelectedIndexChanged += AccountsList_SelectedIndexChanged;
            // 
            // account_id
            // 
            account_id.Text = "ID";
            account_id.Width = 35;
            // 
            // username
            // 
            username.Text = "Username";
            username.Width = 100;
            // 
            // password
            // 
            password.Text = "Password";
            password.Width = 100;
            // 
            // full_name
            // 
            full_name.Text = "Full Name";
            full_name.Width = 150;
            // 
            // clearance_level
            // 
            clearance_level.Text = "Clearance Level";
            clearance_level.Width = 135;
            // 
            // realPassword
            // 
            realPassword.Width = 0;
            // 
            // refreshBtn
            // 
            refreshBtn.CustomizableEdges = customizableEdges1;
            refreshBtn.DisabledState.BorderColor = Color.DarkGray;
            refreshBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            refreshBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            refreshBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            refreshBtn.FillColor = Color.White;
            refreshBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refreshBtn.ForeColor = Color.Black;
            refreshBtn.Location = new Point(535, 183);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            refreshBtn.Size = new Size(170, 54);
            refreshBtn.TabIndex = 8;
            refreshBtn.Text = "REFRESH";
            refreshBtn.Click += refreshBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.CustomizableEdges = customizableEdges3;
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
            deleteBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            deleteBtn.Size = new Size(170, 54);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "DELETE";
            deleteBtn.Click += deleteBtn_Click;
            // 
            // modifyBtn
            // 
            modifyBtn.CustomizableEdges = customizableEdges5;
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
            modifyBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            modifyBtn.Size = new Size(170, 54);
            modifyBtn.TabIndex = 6;
            modifyBtn.Text = "MODIFY";
            modifyBtn.Click += modifyBtn_Click;
            // 
            // createBtn
            // 
            createBtn.CustomizableEdges = customizableEdges7;
            createBtn.DisabledState.BorderColor = Color.DarkGray;
            createBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            createBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            createBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            createBtn.FillColor = Color.White;
            createBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.ForeColor = Color.Black;
            createBtn.Location = new Point(535, 3);
            createBtn.Name = "createBtn";
            createBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            createBtn.Size = new Size(170, 54);
            createBtn.TabIndex = 5;
            createBtn.Text = "CREATE";
            createBtn.Click += createBtn_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(refreshBtn);
            Controls.Add(deleteBtn);
            Controls.Add(modifyBtn);
            Controls.Add(createBtn);
            Controls.Add(AccountsList);
            Name = "UserManagement";
            Size = new Size(708, 335);
            ResumeLayout(false);
        }

        #endregion

        private ListView AccountsList;
        private ColumnHeader account_id;
        private ColumnHeader username;
        private ColumnHeader password;
        private ColumnHeader full_name;
        private Guna.UI2.WinForms.Guna2Button refreshBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button modifyBtn;
        private Guna.UI2.WinForms.Guna2Button createBtn;
        private ColumnHeader clearance_level;
        private ColumnHeader realPassword;
    }
}
