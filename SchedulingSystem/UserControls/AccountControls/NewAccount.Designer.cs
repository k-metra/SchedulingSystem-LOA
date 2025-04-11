namespace SchedulingSystem.UserControls.AccountControls
{
    partial class NewAccount
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Title = new Label();
            label1 = new Label();
            userBox = new TextBox();
            passBox = new TextBox();
            label2 = new Label();
            fullNameBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            levelBox = new ComboBox();
            cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            confirmBtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(282, 99);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = null;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(405, 32);
            Title.TabIndex = 1;
            Title.Text = "CREATE NEW ACCOUNT";
            Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 61);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // userBox
            // 
            userBox.Location = new Point(106, 58);
            userBox.Name = "userBox";
            userBox.Size = new Size(179, 23);
            userBox.TabIndex = 3;
            // 
            // passBox
            // 
            passBox.Location = new Point(106, 96);
            passBox.Name = "passBox";
            passBox.Size = new Size(179, 23);
            passBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 99);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // fullNameBox
            // 
            fullNameBox.Location = new Point(106, 137);
            fullNameBox.Name = "fullNameBox";
            fullNameBox.Size = new Size(179, 23);
            fullNameBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 140);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Full Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 181);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "Level:";
            // 
            // levelBox
            // 
            levelBox.FormattingEnabled = true;
            levelBox.Location = new Point(106, 178);
            levelBox.Name = "levelBox";
            levelBox.Size = new Size(179, 23);
            levelBox.TabIndex = 9;
            levelBox.SelectedIndexChanged += levelBox_SelectedIndexChanged;
            // 
            // cancelBtn
            // 
            cancelBtn.CustomBorderColor = Color.FromArgb(255, 128, 128);
            cancelBtn.CustomBorderThickness = new Padding(0, 0, 0, 3);
            cancelBtn.CustomizableEdges = customizableEdges1;
            cancelBtn.DisabledState.BorderColor = Color.DarkGray;
            cancelBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelBtn.FillColor = Color.White;
            cancelBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.Location = new Point(223, 214);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cancelBtn.Size = new Size(95, 45);
            cancelBtn.TabIndex = 18;
            cancelBtn.Text = "CANCEL";
            cancelBtn.Click += cancelBtn_Click;
            // 
            // confirmBtn
            // 
            confirmBtn.CustomBorderColor = Color.FromArgb(128, 128, 255);
            confirmBtn.CustomBorderThickness = new Padding(0, 0, 0, 3);
            confirmBtn.CustomizableEdges = customizableEdges3;
            confirmBtn.DisabledState.BorderColor = Color.DarkGray;
            confirmBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            confirmBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            confirmBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            confirmBtn.FillColor = Color.White;
            confirmBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmBtn.ForeColor = Color.Black;
            confirmBtn.Location = new Point(69, 214);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            confirmBtn.Size = new Size(95, 45);
            confirmBtn.TabIndex = 17;
            confirmBtn.Text = "CONFIRM";
            confirmBtn.Click += confirmBtn_Click;
            // 
            // NewAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 271);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(levelBox);
            Controls.Add(label4);
            Controls.Add(fullNameBox);
            Controls.Add(label3);
            Controls.Add(passBox);
            Controls.Add(label2);
            Controls.Add(userBox);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label Title;
        private Label label1;
        private TextBox userBox;
        private TextBox passBox;
        private Label label2;
        private TextBox fullNameBox;
        private Label label3;
        private Label label4;
        private ComboBox levelBox;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button confirmBtn;
    }
}