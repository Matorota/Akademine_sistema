namespace Akademine_sistema
{
    partial class Student_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Management));
            label4 = new Label();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            StudentGV = new DataGridView();
            StudentName = new TextBox();
            StudentID = new TextBox();
            label1 = new Label();
            button6 = new Button();
            button5 = new Button();
            SelectGroupSearch = new ComboBox();
            StudentPhone = new TextBox();
            StudentPassword = new TextBox();
            StudentGroupCB = new ComboBox();
            StudentSurname = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            LessonsCB = new ComboBox();
            button7 = new Button();
            button8 = new Button();
            SelectLesson = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)StudentGV).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(111, 161);
            label4.Name = "label4";
            label4.Size = new Size(80, 24);
            label4.TabIndex = 41;
            label4.Text = "Name:";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(178, 411);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 40;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 126);
            label3.Name = "label3";
            label3.Size = new Size(128, 24);
            label3.TabIndex = 39;
            label3.Text = "StudentID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(684, 65);
            label2.Name = "label2";
            label2.Size = new Size(145, 24);
            label2.TabIndex = 38;
            label2.Text = "Student List";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(65, 411);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 37;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(178, 372);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 36;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(65, 372);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 35;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StudentGV
            // 
            StudentGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            StudentGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentGV.Location = new Point(325, 165);
            StudentGV.Margin = new Padding(3, 4, 3, 4);
            StudentGV.Name = "StudentGV";
            StudentGV.RowHeadersWidth = 51;
            StudentGV.Size = new Size(496, 277);
            StudentGV.TabIndex = 34;
            // 
            // StudentName
            // 
            StudentName.BackColor = SystemColors.ActiveCaption;
            StudentName.Location = new Point(197, 158);
            StudentName.Margin = new Padding(3, 4, 3, 4);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(122, 27);
            StudentName.TabIndex = 33;
            StudentName.Text = "StudentName";
            // 
            // StudentID
            // 
            StudentID.BackColor = SystemColors.ActiveCaption;
            StudentID.Location = new Point(197, 123);
            StudentID.Margin = new Padding(3, 4, 3, 4);
            StudentID.Name = "StudentID";
            StudentID.Size = new Size(122, 27);
            StudentID.TabIndex = 32;
            StudentID.Text = "StudentID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 24);
            label1.Name = "label1";
            label1.Size = new Size(567, 41);
            label1.TabIndex = 31;
            label1.Text = "Student Management System";
            // 
            // button6
            // 
            button6.Location = new Point(723, 93);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 48;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(641, 93);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 47;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // SelectGroupSearch
            // 
            SelectGroupSearch.FormattingEnabled = true;
            SelectGroupSearch.Location = new Point(495, 94);
            SelectGroupSearch.Name = "SelectGroupSearch";
            SelectGroupSearch.Size = new Size(151, 28);
            SelectGroupSearch.TabIndex = 46;
            SelectGroupSearch.Text = "SelectGroup";
            // 
            // StudentPhone
            // 
            StudentPhone.BackColor = SystemColors.InactiveCaption;
            StudentPhone.Location = new Point(197, 265);
            StudentPhone.Margin = new Padding(3, 4, 3, 4);
            StudentPhone.Name = "StudentPhone";
            StudentPhone.Size = new Size(122, 27);
            StudentPhone.TabIndex = 45;
            StudentPhone.Text = "StudentPhone";
            // 
            // StudentPassword
            // 
            StudentPassword.BackColor = SystemColors.InactiveCaption;
            StudentPassword.Location = new Point(197, 230);
            StudentPassword.Margin = new Padding(3, 4, 3, 4);
            StudentPassword.Name = "StudentPassword";
            StudentPassword.Size = new Size(122, 27);
            StudentPassword.TabIndex = 44;
            StudentPassword.Text = "StudentPassword";
            // 
            // StudentGroupCB
            // 
            StudentGroupCB.BackColor = SystemColors.InactiveCaption;
            StudentGroupCB.FormattingEnabled = true;
            StudentGroupCB.Location = new Point(197, 299);
            StudentGroupCB.Name = "StudentGroupCB";
            StudentGroupCB.Size = new Size(122, 28);
            StudentGroupCB.TabIndex = 43;
            StudentGroupCB.Text = "StudentGroup";
            // 
            // StudentSurname
            // 
            StudentSurname.BackColor = SystemColors.InactiveCaption;
            StudentSurname.Location = new Point(197, 193);
            StudentSurname.Margin = new Padding(3, 4, 3, 4);
            StudentSurname.Name = "StudentSurname";
            StudentSurname.Size = new Size(122, 27);
            StudentSurname.TabIndex = 42;
            StudentSurname.Text = "StudentSurname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(76, 196);
            label5.Name = "label5";
            label5.Size = new Size(115, 24);
            label5.TabIndex = 49;
            label5.Text = "Surname:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(63, 230);
            label6.Name = "label6";
            label6.Size = new Size(125, 24);
            label6.TabIndex = 50;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(102, 265);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 51;
            label7.Text = "Phone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 303);
            label8.Name = "label8";
            label8.Size = new Size(163, 24);
            label8.TabIndex = 52;
            label8.Text = "Groups/Class:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(85, 337);
            label9.Name = "label9";
            label9.Size = new Size(106, 24);
            label9.TabIndex = 54;
            label9.Text = "Lessons:";
            // 
            // LessonsCB
            // 
            LessonsCB.BackColor = SystemColors.InactiveCaption;
            LessonsCB.FormattingEnabled = true;
            LessonsCB.Location = new Point(196, 333);
            LessonsCB.Name = "LessonsCB";
            LessonsCB.Size = new Size(122, 28);
            LessonsCB.TabIndex = 53;
            LessonsCB.Text = "Lessons";
            // 
            // button7
            // 
            button7.Location = new Point(723, 129);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 31);
            button7.TabIndex = 57;
            button7.Text = "Refresh";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(641, 129);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 31);
            button8.TabIndex = 56;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // SelectLesson
            // 
            SelectLesson.FormattingEnabled = true;
            SelectLesson.Location = new Point(495, 130);
            SelectLesson.Name = "SelectLesson";
            SelectLesson.Size = new Size(151, 28);
            SelectLesson.TabIndex = 55;
            SelectLesson.Text = "SelectLesson";
            // 
            // Student_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(832, 450);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(SelectLesson);
            Controls.Add(label9);
            Controls.Add(LessonsCB);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(SelectGroupSearch);
            Controls.Add(StudentPhone);
            Controls.Add(StudentPassword);
            Controls.Add(StudentGroupCB);
            Controls.Add(StudentSurname);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(StudentGV);
            Controls.Add(StudentName);
            Controls.Add(StudentID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Management";
            Load += Student_Management_Load;
            ((System.ComponentModel.ISupportInitialize)StudentGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button4;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView StudentGV;
        private TextBox StudentName;
        private TextBox StudentID;
        private Label label1;
        private Button button6;
        private Button button5;
        private ComboBox SelectGroupSearch;
        private TextBox StudentPhone;
        private TextBox StudentPassword;
        private ComboBox StudentGroupCB;
        private TextBox StudentSurname;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox LessonsCB;
        private Button button7;
        private Button button8;
        private ComboBox SelectLesson;
    }
}