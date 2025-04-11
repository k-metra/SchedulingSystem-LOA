namespace SchedulingSystem
{
    partial class MainControlForm
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

        #region Windows Form Designer generated code

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
            Title = new Label();
            buttonsPanel = new Panel();
            settingsBtn = new Guna.UI2.WinForms.Guna2Button();
            userMgtBtn = new Guna.UI2.WinForms.Guna2Button();
            homeBtn = new Guna.UI2.WinForms.Guna2Button();
            container = new Panel();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.BackColor = SystemColors.ActiveCaption;
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(708, 40);
            Title.TabIndex = 0;
            Title.Text = "Scheduling System";
            Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(settingsBtn);
            buttonsPanel.Controls.Add(userMgtBtn);
            buttonsPanel.Controls.Add(homeBtn);
            buttonsPanel.Dock = DockStyle.Top;
            buttonsPanel.Location = new Point(0, 40);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(708, 48);
            buttonsPanel.TabIndex = 1;
            // 
            // settingsBtn
            // 
            settingsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            settingsBtn.CheckedState.CustomBorderColor = Color.FromArgb(128, 128, 255);
            settingsBtn.CheckedState.FillColor = Color.White;
            settingsBtn.CustomBorderColor = Color.White;
            settingsBtn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            settingsBtn.CustomizableEdges = customizableEdges1;
            settingsBtn.DisabledState.BorderColor = Color.DarkGray;
            settingsBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            settingsBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            settingsBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            settingsBtn.FillColor = Color.White;
            settingsBtn.FocusedColor = Color.FromArgb(192, 192, 255);
            settingsBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsBtn.ForeColor = Color.Black;
            settingsBtn.HoverState.BorderColor = Color.Gray;
            settingsBtn.Location = new Point(378, 0);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.PressedColor = Color.Teal;
            settingsBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            settingsBtn.Size = new Size(183, 48);
            settingsBtn.TabIndex = 2;
            settingsBtn.Text = "Settings";
            settingsBtn.Click += settingsBtn_Click;
            // 
            // userMgtBtn
            // 
            userMgtBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            userMgtBtn.CheckedState.CustomBorderColor = Color.FromArgb(128, 128, 255);
            userMgtBtn.CheckedState.FillColor = Color.White;
            userMgtBtn.CustomBorderColor = Color.White;
            userMgtBtn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            userMgtBtn.CustomizableEdges = customizableEdges3;
            userMgtBtn.DisabledState.BorderColor = Color.DarkGray;
            userMgtBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            userMgtBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            userMgtBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            userMgtBtn.Enabled = false;
            userMgtBtn.FillColor = Color.White;
            userMgtBtn.FocusedColor = Color.FromArgb(192, 192, 255);
            userMgtBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userMgtBtn.ForeColor = Color.Black;
            userMgtBtn.HoverState.BorderColor = Color.Gray;
            userMgtBtn.Location = new Point(189, 0);
            userMgtBtn.Name = "userMgtBtn";
            userMgtBtn.PressedColor = Color.Teal;
            userMgtBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            userMgtBtn.Size = new Size(183, 48);
            userMgtBtn.TabIndex = 1;
            userMgtBtn.Text = "User Management";
            userMgtBtn.Click += userMgtBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            homeBtn.Checked = true;
            homeBtn.CheckedState.CustomBorderColor = Color.FromArgb(128, 128, 255);
            homeBtn.CheckedState.FillColor = Color.White;
            homeBtn.CustomBorderColor = Color.White;
            homeBtn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            homeBtn.CustomizableEdges = customizableEdges5;
            homeBtn.DisabledState.BorderColor = Color.DarkGray;
            homeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            homeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            homeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            homeBtn.FillColor = Color.White;
            homeBtn.FocusedColor = Color.FromArgb(192, 192, 255);
            homeBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeBtn.ForeColor = Color.Black;
            homeBtn.HoverState.BorderColor = Color.Gray;
            homeBtn.Location = new Point(0, 0);
            homeBtn.Name = "homeBtn";
            homeBtn.PressedColor = Color.Teal;
            homeBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            homeBtn.Size = new Size(183, 48);
            homeBtn.TabIndex = 0;
            homeBtn.Text = "Home";
            homeBtn.Click += guna2Button1_Click;
            // 
            // container
            // 
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 88);
            container.Name = "container";
            container.Size = new Size(708, 335);
            container.TabIndex = 2;
            // 
            // MainControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 423);
            ControlBox = false;
            Controls.Add(container);
            Controls.Add(buttonsPanel);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainControlForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainControlForm";
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private Panel buttonsPanel;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private Guna.UI2.WinForms.Guna2Button userMgtBtn;
        private Guna.UI2.WinForms.Guna2Button settingsBtn;
        private Panel container;
    }
}