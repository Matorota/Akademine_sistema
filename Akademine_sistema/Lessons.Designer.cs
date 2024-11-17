namespace Akademine_sistema
{
    partial class Lessons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lessons));
            label4 = new Label();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            GrupesGV = new DataGridView();
            LessonName = new TextBox();
            LessonID = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GrupesGV).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 161);
            label4.Name = "label4";
            label4.Size = new Size(157, 24);
            label4.TabIndex = 41;
            label4.Text = "LessonName:";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(179, 321);
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
            label3.Location = new Point(41, 126);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 39;
            label3.Text = "LessonID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(372, 82);
            label2.Name = "label2";
            label2.Size = new Size(229, 24);
            label2.TabIndex = 38;
            label2.Text = "Student Lesson List";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(179, 282);
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
            button2.Location = new Point(179, 243);
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
            button1.Location = new Point(179, 204);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 35;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GrupesGV
            // 
            GrupesGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrupesGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GrupesGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrupesGV.Location = new Point(292, 110);
            GrupesGV.Margin = new Padding(3, 4, 3, 4);
            GrupesGV.Name = "GrupesGV";
            GrupesGV.RowHeadersWidth = 51;
            GrupesGV.Size = new Size(383, 239);
            GrupesGV.TabIndex = 34;
            // 
            // LessonName
            // 
            LessonName.BackColor = SystemColors.ActiveCaption;
            LessonName.Location = new Point(164, 158);
            LessonName.Margin = new Padding(3, 4, 3, 4);
            LessonName.Name = "LessonName";
            LessonName.Size = new Size(122, 27);
            LessonName.TabIndex = 33;
            LessonName.Text = "LessonName";
            // 
            // LessonID
            // 
            LessonID.BackColor = SystemColors.ActiveCaption;
            LessonID.Location = new Point(164, 123);
            LessonID.Margin = new Padding(3, 4, 3, 4);
            LessonID.Name = "LessonID";
            LessonID.Size = new Size(122, 27);
            LessonID.TabIndex = 32;
            LessonID.Text = "LessonID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(710, 41);
            label1.TabIndex = 31;
            label1.Text = "Student Lesson Management System";
            // 
            // Lessons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(723, 370);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(GrupesGV);
            Controls.Add(LessonName);
            Controls.Add(LessonID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Lessons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lessons";
            Load += Lessons_Load;
            ((System.ComponentModel.ISupportInitialize)GrupesGV).EndInit();
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
        private DataGridView GrupesGV;
        private TextBox LessonName;
        private TextBox LessonID;
        private Label label1;
    }
}