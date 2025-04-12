namespace SchedulingSystem.UserControls.SettingsWindows
{
    partial class AccountSettings
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            userBox = new Guna.UI2.WinForms.Guna2TextBox();
            passBox = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            fullName = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // userBox
            // 
            userBox.CustomizableEdges = customizableEdges7;
            userBox.DefaultText = "";
            userBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            userBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            userBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            userBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            userBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            userBox.Font = new Font("Segoe UI", 9F);
            userBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            userBox.Location = new Point(128, 10);
            userBox.Name = "userBox";
            userBox.PlaceholderText = "";
            userBox.SelectedText = "";
            userBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            userBox.Size = new Size(200, 36);
            userBox.TabIndex = 1;
            // 
            // passBox
            // 
            passBox.CustomizableEdges = customizableEdges9;
            passBox.DefaultText = "";
            passBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passBox.Enabled = false;
            passBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passBox.Font = new Font("Segoe UI", 9F);
            passBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passBox.Location = new Point(128, 62);
            passBox.Name = "passBox";
            passBox.PlaceholderText = "";
            passBox.SelectedText = "";
            passBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            passBox.Size = new Size(200, 36);
            passBox.TabIndex = 3;
            passBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 62);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // fullName
            // 
            fullName.CustomizableEdges = customizableEdges11;
            fullName.DefaultText = "";
            fullName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            fullName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            fullName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            fullName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            fullName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            fullName.Font = new Font("Segoe UI", 9F);
            fullName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            fullName.Location = new Point(128, 113);
            fullName.Name = "fullName";
            fullName.PlaceholderText = "";
            fullName.SelectedText = "";
            fullName.ShadowDecoration.CustomizableEdges = customizableEdges12;
            fullName.Size = new Size(200, 36);
            fullName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 113);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 4;
            label3.Text = "Full Name:";
            // 
            // AccountSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fullName);
            Controls.Add(label3);
            Controls.Add(passBox);
            Controls.Add(label2);
            Controls.Add(userBox);
            Controls.Add(label1);
            Name = "AccountSettings";
            Size = new Size(508, 329);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox userBox;
        private Guna.UI2.WinForms.Guna2TextBox passBox;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox fullName;
        private Label label3;
    }
}
