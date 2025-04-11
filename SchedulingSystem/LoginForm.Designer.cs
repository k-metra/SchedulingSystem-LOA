namespace SchedulingSystem
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            userBox = new TextBox();
            passBox = new TextBox();
            label3 = new Label();
            showPassBtn = new Button();
            showPass = new ImageList(components);
            loginBtn = new Button();
            alertText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(429, 27);
            label1.TabIndex = 0;
            label1.Text = "Log-in";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 49);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // userBox
            // 
            userBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userBox.Location = new Point(145, 46);
            userBox.Name = "userBox";
            userBox.Size = new Size(173, 29);
            userBox.TabIndex = 2;
            // 
            // passBox
            // 
            passBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passBox.Location = new Point(145, 93);
            passBox.Name = "passBox";
            passBox.Size = new Size(173, 29);
            passBox.TabIndex = 4;
            passBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 96);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // showPassBtn
            // 
            showPassBtn.ImageIndex = 0;
            showPassBtn.ImageList = showPass;
            showPassBtn.Location = new Point(324, 93);
            showPassBtn.Name = "showPassBtn";
            showPassBtn.Size = new Size(29, 29);
            showPassBtn.TabIndex = 5;
            showPassBtn.UseVisualStyleBackColor = true;
            showPassBtn.Click += button1_Click;
            // 
            // showPass
            // 
            showPass.ColorDepth = ColorDepth.Depth32Bit;
            showPass.ImageStream = (ImageListStreamer)resources.GetObject("showPass.ImageStream");
            showPass.TransparentColor = Color.Transparent;
            showPass.Images.SetKeyName(0, "eye-line.png");
            showPass.Images.SetKeyName(1, "eye-off-line.png");
            // 
            // loginBtn
            // 
            loginBtn.Image = Properties.Resources.login_box_line;
            loginBtn.Location = new Point(180, 159);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 31);
            loginBtn.TabIndex = 6;
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // alertText
            // 
            alertText.AutoSize = true;
            alertText.ForeColor = Color.Red;
            alertText.Location = new Point(128, 130);
            alertText.Name = "alertText";
            alertText.Size = new Size(196, 15);
            alertText.TabIndex = 7;
            alertText.Tag = "";
            alertText.Text = "* Username or password is incorrect";
            alertText.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 202);
            ControlBox = false;
            Controls.Add(alertText);
            Controls.Add(loginBtn);
            Controls.Add(showPassBtn);
            Controls.Add(passBox);
            Controls.Add(label3);
            Controls.Add(userBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log-in";
            KeyPress += input_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userBox;
        private TextBox passBox;
        private Label label3;
        private Button showPassBtn;
        private ImageList showPass;
        private Button loginBtn;
        private Label alertText;
    }
}