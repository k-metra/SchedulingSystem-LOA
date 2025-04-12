namespace SchedulingSystem.UserControls
{
    partial class Settings
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
            logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            controlsPanel = new Panel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            settingsPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            controlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logoutBtn
            // 
            logoutBtn.CustomizableEdges = customizableEdges1;
            logoutBtn.DisabledState.BorderColor = Color.DarkGray;
            logoutBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            logoutBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logoutBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logoutBtn.FillColor = Color.White;
            logoutBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.Black;
            logoutBtn.Image = Properties.Resources.logout_box_line;
            logoutBtn.Location = new Point(3, 281);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            logoutBtn.Size = new Size(180, 45);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Logout";
            logoutBtn.Click += logoutBtn_Click;
            // 
            // controlsPanel
            // 
            controlsPanel.BackColor = SystemColors.ControlLight;
            controlsPanel.BorderStyle = BorderStyle.Fixed3D;
            controlsPanel.Controls.Add(guna2Button2);
            controlsPanel.Controls.Add(guna2Button1);
            controlsPanel.Controls.Add(logoutBtn);
            controlsPanel.Location = new Point(3, 3);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(188, 329);
            controlsPanel.TabIndex = 1;
            // 
            // guna2Button2
            // 
            guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button2.CheckedState.BorderColor = Color.White;
            guna2Button2.CheckedState.CustomBorderColor = Color.DimGray;
            guna2Button2.CustomBorderColor = Color.Transparent;
            guna2Button2.CustomBorderThickness = new Padding(0, 0, 0, 3);
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.White;
            guna2Button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Image = Properties.Resources.question_line;
            guna2Button2.ImageSize = new Size(22, 22);
            guna2Button2.Location = new Point(1, 54);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(180, 45);
            guna2Button2.TabIndex = 2;
            guna2Button2.Text = "About";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button1.CheckedState.BorderColor = Color.White;
            guna2Button1.CheckedState.CustomBorderColor = Color.DimGray;
            guna2Button1.CustomBorderColor = Color.Transparent;
            guna2Button1.CustomBorderThickness = new Padding(0, 0, 0, 3);
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = Properties.Resources.account_circle_line;
            guna2Button1.ImageSize = new Size(22, 22);
            guna2Button1.Location = new Point(1, 3);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Account";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // settingsPanel
            // 
            settingsPanel.CustomizableEdges = customizableEdges7;
            settingsPanel.FillColor = Color.LightGray;
            settingsPanel.FillColor2 = Color.DimGray;
            settingsPanel.Location = new Point(197, 3);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            settingsPanel.Size = new Size(508, 329);
            settingsPanel.TabIndex = 2;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(settingsPanel);
            Controls.Add(controlsPanel);
            Name = "Settings";
            Size = new Size(708, 335);
            controlsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Panel controlsPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel settingsPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
