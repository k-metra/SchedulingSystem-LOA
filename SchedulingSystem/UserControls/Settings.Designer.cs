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
            logoutBtn = new Guna.UI2.WinForms.Guna2Button();
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
            logoutBtn.Location = new Point(287, 120);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            logoutBtn.Size = new Size(180, 45);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Logout";
            logoutBtn.Click += logoutBtn_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(logoutBtn);
            Name = "Settings";
            Size = new Size(708, 335);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button logoutBtn;
    }
}
