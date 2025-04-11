namespace SchedulingSystem.UserControls
{
    partial class NewSchedule
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
            label2 = new Label();
            subjNameBox = new TextBox();
            subjCodeBox = new TextBox();
            label3 = new Label();
            specializationBox = new TextBox();
            label4 = new Label();
            gradeBox = new TextBox();
            label5 = new Label();
            roomBox = new TextBox();
            label6 = new Label();
            teacherBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            confirmBtn = new Guna.UI2.WinForms.Guna2Button();
            cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            sectionBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(421, 34);
            Title.TabIndex = 0;
            Title.Text = "CREATE NEW SCHEDULE";
            Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 57);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Subject Name:";
            // 
            // subjNameBox
            // 
            subjNameBox.Location = new Point(121, 54);
            subjNameBox.Name = "subjNameBox";
            subjNameBox.Size = new Size(178, 23);
            subjNameBox.TabIndex = 2;
            // 
            // subjCodeBox
            // 
            subjCodeBox.Location = new Point(121, 92);
            subjCodeBox.Name = "subjCodeBox";
            subjCodeBox.Size = new Size(178, 23);
            subjCodeBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 95);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 3;
            label3.Text = "Subject Code:";
            // 
            // specializationBox
            // 
            specializationBox.Location = new Point(121, 128);
            specializationBox.Name = "specializationBox";
            specializationBox.Size = new Size(178, 23);
            specializationBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 131);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 5;
            label4.Text = "Specialization:";
            // 
            // gradeBox
            // 
            gradeBox.Location = new Point(121, 166);
            gradeBox.Name = "gradeBox";
            gradeBox.Size = new Size(178, 23);
            gradeBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 169);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 7;
            label5.Text = "Grade Level:";
            // 
            // roomBox
            // 
            roomBox.Location = new Point(121, 205);
            roomBox.Name = "roomBox";
            roomBox.Size = new Size(178, 23);
            roomBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 208);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 9;
            label6.Text = "Room:";
            // 
            // teacherBox
            // 
            teacherBox.Location = new Point(121, 238);
            teacherBox.Name = "teacherBox";
            teacherBox.Size = new Size(178, 23);
            teacherBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 241);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 11;
            label7.Text = "Teacher:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 311);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 13;
            label8.Text = "Date:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Checked = true;
            dateTimePicker.CustomFormat = "yyyy-MM-DD HH:mm";
            dateTimePicker.CustomizableEdges = customizableEdges1;
            dateTimePicker.FillColor = Color.FromArgb(224, 224, 224);
            dateTimePicker.Font = new Font("Segoe UI", 9F);
            dateTimePicker.Format = DateTimePickerFormat.Long;
            dateTimePicker.Location = new Point(121, 304);
            dateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dateTimePicker.Size = new Size(178, 27);
            dateTimePicker.TabIndex = 14;
            dateTimePicker.Value = new DateTime(2025, 4, 11, 13, 49, 7, 537);
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
            confirmBtn.Location = new Point(314, 92);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            confirmBtn.Size = new Size(95, 45);
            confirmBtn.TabIndex = 15;
            confirmBtn.Text = "CONFIRM";
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.CustomBorderColor = Color.FromArgb(255, 128, 128);
            cancelBtn.CustomBorderThickness = new Padding(0, 0, 0, 3);
            cancelBtn.CustomizableEdges = customizableEdges5;
            cancelBtn.DisabledState.BorderColor = Color.DarkGray;
            cancelBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelBtn.FillColor = Color.White;
            cancelBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.Location = new Point(314, 153);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cancelBtn.Size = new Size(95, 45);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "CANCEL";
            cancelBtn.Click += cancelBtn_Click;
            // 
            // sectionBox
            // 
            sectionBox.Location = new Point(121, 268);
            sectionBox.Name = "sectionBox";
            sectionBox.Size = new Size(178, 23);
            sectionBox.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 271);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 17;
            label9.Text = "Section:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 311);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 13;
            label10.Text = "Date:";
            // 
            // NewSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(421, 344);
            Controls.Add(sectionBox);
            Controls.Add(label9);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(dateTimePicker);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(teacherBox);
            Controls.Add(label7);
            Controls.Add(roomBox);
            Controls.Add(label6);
            Controls.Add(gradeBox);
            Controls.Add(label5);
            Controls.Add(specializationBox);
            Controls.Add(label4);
            Controls.Add(subjCodeBox);
            Controls.Add(label3);
            Controls.Add(subjNameBox);
            Controls.Add(label2);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New Schedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label2;
        private TextBox subjNameBox;
        private TextBox subjCodeBox;
        private Label label3;
        private TextBox specializationBox;
        private Label label4;
        private TextBox gradeBox;
        private Label label5;
        private TextBox roomBox;
        private Label label6;
        private TextBox teacherBox;
        private Label label7;
        private Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2Button confirmBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private TextBox sectionBox;
        private Label label9;
        private Label label10;
    }
}