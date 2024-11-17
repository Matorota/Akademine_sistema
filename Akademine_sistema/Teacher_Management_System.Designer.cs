namespace Akademine_sistema
{
    partial class Teacher_Management_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Management_System));
            label4 = new Label();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            TeacherGV = new DataGridView();
            TeacherName = new TextBox();
            TeacherId = new TextBox();
            label1 = new Label();
            TeacherSurname = new TextBox();
            TeacherPassword = new TextBox();
            TeacherPhone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)TeacherGV).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 168);
            label4.Name = "label4";
            label4.Size = new Size(80, 24);
            label4.TabIndex = 52;
            label4.Text = "Name:";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(176, 382);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 51;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 136);
            label3.Name = "label3";
            label3.Size = new Size(130, 24);
            label3.TabIndex = 50;
            label3.Text = "TeacherID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(487, 92);
            label2.Name = "label2";
            label2.Size = new Size(147, 24);
            label2.TabIndex = 49;
            label2.Text = "Teacher List";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(55, 382);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 48;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(176, 328);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 47;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(55, 328);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 46;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TeacherGV
            // 
            TeacherGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TeacherGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TeacherGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherGV.Location = new Point(304, 120);
            TeacherGV.Margin = new Padding(3, 4, 3, 4);
            TeacherGV.Name = "TeacherGV";
            TeacherGV.RowHeadersWidth = 51;
            TeacherGV.Size = new Size(468, 293);
            TeacherGV.TabIndex = 45;
            // 
            // TeacherName
            // 
            TeacherName.BackColor = SystemColors.ActiveCaption;
            TeacherName.Location = new Point(176, 168);
            TeacherName.Margin = new Padding(3, 4, 3, 4);
            TeacherName.Name = "TeacherName";
            TeacherName.Size = new Size(122, 27);
            TeacherName.TabIndex = 44;
            TeacherName.Text = "TeacherName";
            // 
            // TeacherId
            // 
            TeacherId.BackColor = SystemColors.ActiveCaption;
            TeacherId.Location = new Point(176, 133);
            TeacherId.Margin = new Padding(3, 4, 3, 4);
            TeacherId.Name = "TeacherId";
            TeacherId.Size = new Size(122, 27);
            TeacherId.TabIndex = 43;
            TeacherId.Text = "TeacherId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(574, 41);
            label1.TabIndex = 42;
            label1.Text = "Teacher Management System";
            // 
            // TeacherSurname
            // 
            TeacherSurname.BackColor = SystemColors.ActiveCaption;
            TeacherSurname.Location = new Point(176, 203);
            TeacherSurname.Margin = new Padding(3, 4, 3, 4);
            TeacherSurname.Name = "TeacherSurname";
            TeacherSurname.Size = new Size(122, 27);
            TeacherSurname.TabIndex = 53;
            TeacherSurname.Text = "TeacherSurname";
            // 
            // TeacherPassword
            // 
            TeacherPassword.BackColor = SystemColors.ActiveCaption;
            TeacherPassword.Location = new Point(176, 238);
            TeacherPassword.Margin = new Padding(3, 4, 3, 4);
            TeacherPassword.Name = "TeacherPassword";
            TeacherPassword.Size = new Size(122, 27);
            TeacherPassword.TabIndex = 54;
            TeacherPassword.Text = "TeacherPassword";
            // 
            // TeacherPhone
            // 
            TeacherPhone.BackColor = SystemColors.ActiveCaption;
            TeacherPhone.Location = new Point(176, 273);
            TeacherPhone.Margin = new Padding(3, 4, 3, 4);
            TeacherPhone.Name = "TeacherPhone";
            TeacherPhone.Size = new Size(122, 27);
            TeacherPhone.TabIndex = 55;
            TeacherPhone.Text = "TeacherPhone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 206);
            label5.Name = "label5";
            label5.Size = new Size(115, 24);
            label5.TabIndex = 56;
            label5.Text = "Surname:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 238);
            label6.Name = "label6";
            label6.Size = new Size(125, 24);
            label6.TabIndex = 57;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(84, 273);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 58;
            label7.Text = "Phone:";
            // 
            // Teacher_Management_System
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TeacherPhone);
            Controls.Add(TeacherPassword);
            Controls.Add(TeacherSurname);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TeacherGV);
            Controls.Add(TeacherName);
            Controls.Add(TeacherId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teacher_Management_System";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher_Management_System";
            Load += Teacher_Management_System_Load;
            ((System.ComponentModel.ISupportInitialize)TeacherGV).EndInit();
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
        private DataGridView TeacherGV;
        private TextBox TeacherName;
        private TextBox TeacherId;
        private Label label1;
        private TextBox TeacherSurname;
        private TextBox TeacherPassword;
        private TextBox TeacherPhone;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}