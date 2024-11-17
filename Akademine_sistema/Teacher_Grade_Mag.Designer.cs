namespace Akademine_sistema
{
    partial class Teacher_Grade_Mag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Grade_Mag));
            button7 = new Button();
            button8 = new Button();
            SelectLesson = new ComboBox();
            LessonsCB = new ComboBox();
            StudentGroupCB = new ComboBox();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            StudentGV = new DataGridView();
            Id = new TextBox();
            label1 = new Label();
            TeacherCB = new ComboBox();
            StudentCB = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Grade = new TextBox();
            ((System.ComponentModel.ISupportInitialize)StudentGV).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(677, 121);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 31);
            button7.TabIndex = 75;
            button7.Text = "Refresh";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(595, 121);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 31);
            button8.TabIndex = 74;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // SelectLesson
            // 
            SelectLesson.FormattingEnabled = true;
            SelectLesson.Location = new Point(449, 122);
            SelectLesson.Name = "SelectLesson";
            SelectLesson.Size = new Size(151, 28);
            SelectLesson.TabIndex = 73;
            SelectLesson.Text = "SelectLesson";
            // 
            // LessonsCB
            // 
            LessonsCB.BackColor = SystemColors.InactiveCaption;
            LessonsCB.FormattingEnabled = true;
            LessonsCB.Location = new Point(151, 302);
            LessonsCB.Name = "LessonsCB";
            LessonsCB.Size = new Size(122, 28);
            LessonsCB.TabIndex = 72;
            LessonsCB.Text = "Lessons";
            // 
            // StudentGroupCB
            // 
            StudentGroupCB.BackColor = SystemColors.InactiveCaption;
            StudentGroupCB.FormattingEnabled = true;
            StudentGroupCB.Location = new Point(151, 258);
            StudentGroupCB.Name = "StudentGroupCB";
            StudentGroupCB.Size = new Size(122, 28);
            StudentGroupCB.TabIndex = 69;
            StudentGroupCB.Text = "StudentGroup";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(187, 411);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 67;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 124);
            label3.Name = "label3";
            label3.Size = new Size(176, 24);
            label3.TabIndex = 66;
            label3.Text = "Grade Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(618, 83);
            label2.Name = "label2";
            label2.Size = new Size(145, 24);
            label2.TabIndex = 65;
            label2.Text = "Student List";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(74, 411);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 64;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(187, 372);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 63;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(74, 372);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 62;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // StudentGV
            // 
            StudentGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            StudentGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentGV.Location = new Point(279, 157);
            StudentGV.Margin = new Padding(3, 4, 3, 4);
            StudentGV.Name = "StudentGV";
            StudentGV.RowHeadersWidth = 51;
            StudentGV.Size = new Size(496, 277);
            StudentGV.TabIndex = 61;
            // 
            // Id
            // 
            Id.BackColor = SystemColors.ActiveCaption;
            Id.Location = new Point(248, 121);
            Id.Margin = new Padding(3, 4, 3, 4);
            Id.Name = "Id";
            Id.Size = new Size(122, 27);
            Id.TabIndex = 59;
            Id.Text = "GN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 16);
            label1.Name = "label1";
            label1.Size = new Size(691, 41);
            label1.TabIndex = 58;
            label1.Text = "Student Grade Management System";
            // 
            // TeacherCB
            // 
            TeacherCB.BackColor = SystemColors.InactiveCaption;
            TeacherCB.FormattingEnabled = true;
            TeacherCB.Location = new Point(151, 171);
            TeacherCB.Name = "TeacherCB";
            TeacherCB.Size = new Size(122, 28);
            TeacherCB.TabIndex = 76;
            TeacherCB.Text = "Teacher";
            // 
            // StudentCB
            // 
            StudentCB.BackColor = SystemColors.InactiveCaption;
            StudentCB.FormattingEnabled = true;
            StudentCB.Location = new Point(151, 214);
            StudentCB.Name = "StudentCB";
            StudentCB.Size = new Size(122, 28);
            StudentCB.TabIndex = 77;
            StudentCB.Text = "Student";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 218);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 78;
            label4.Text = "Student:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 171);
            label5.Name = "label5";
            label5.Size = new Size(106, 24);
            label5.TabIndex = 79;
            label5.Text = "Teacher:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 262);
            label6.Name = "label6";
            label6.Size = new Size(83, 24);
            label6.TabIndex = 80;
            label6.Text = "Group:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(51, 302);
            label7.Name = "label7";
            label7.Size = new Size(94, 24);
            label7.TabIndex = 81;
            label7.Text = "Lesson:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(62, 337);
            label8.Name = "label8";
            label8.Size = new Size(83, 24);
            label8.TabIndex = 83;
            label8.Text = "Grade:";
            // 
            // Grade
            // 
            Grade.BackColor = SystemColors.ActiveCaption;
            Grade.Location = new Point(151, 337);
            Grade.Margin = new Padding(3, 4, 3, 4);
            Grade.Name = "Grade";
            Grade.Size = new Size(122, 27);
            Grade.TabIndex = 82;
            Grade.Text = "Grade";
            // 
            // Teacher_Grade_Mag
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(Grade);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(StudentCB);
            Controls.Add(TeacherCB);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(SelectLesson);
            Controls.Add(LessonsCB);
            Controls.Add(StudentGroupCB);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(StudentGV);
            Controls.Add(Id);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teacher_Grade_Mag";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher_Grade_Mag";
            Load += Teacher_Grade_Mag_Load;
            ((System.ComponentModel.ISupportInitialize)StudentGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button8;
        private ComboBox SelectLesson;
        private ComboBox LessonsCB;
        private ComboBox StudentGroupCB;
        private Button button4;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView StudentGV;
        private TextBox Id;
        private Label label1;
        private ComboBox TeacherCB;
        private ComboBox StudentCB;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox Grade;
    }
}