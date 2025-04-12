namespace SchedulingSystem.UserControls.SettingsWindows.AccountWindows
{
    partial class ChangePassword
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
            label1 = new Label();
            currentPassBox = new TextBox();
            newPassBox = new TextBox();
            label2 = new Label();
            reEnterPassBox = new TextBox();
            label3 = new Label();
            confirmBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Current Password:";
            // 
            // currentPassBox
            // 
            currentPassBox.Location = new Point(121, 19);
            currentPassBox.Name = "currentPassBox";
            currentPassBox.Size = new Size(146, 23);
            currentPassBox.TabIndex = 1;
            // 
            // newPassBox
            // 
            newPassBox.Location = new Point(121, 52);
            newPassBox.Name = "newPassBox";
            newPassBox.Size = new Size(146, 23);
            newPassBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "New Password:";
            // 
            // reEnterPassBox
            // 
            reEnterPassBox.Location = new Point(121, 86);
            reEnterPassBox.Name = "reEnterPassBox";
            reEnterPassBox.Size = new Size(146, 23);
            reEnterPassBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Re-enter Password:";
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(40, 128);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(75, 23);
            confirmBtn.TabIndex = 6;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(168, 128);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(284, 163);
            ControlBox = false;
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(reEnterPassBox);
            Controls.Add(label3);
            Controls.Add(newPassBox);
            Controls.Add(label2);
            Controls.Add(currentPassBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox currentPassBox;
        private TextBox newPassBox;
        private Label label2;
        private TextBox reEnterPassBox;
        private Label label3;
        private Button confirmBtn;
        private Button cancelBtn;
    }
}