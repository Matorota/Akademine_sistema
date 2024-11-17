namespace Akademine_sistema
{
    partial class Student_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_view));
            button4 = new Button();
            label2 = new Label();
            GrupesGV = new DataGridView();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            SelectStudent = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)GrupesGV).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(164, 409);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 33;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 95);
            label2.Name = "label2";
            label2.Size = new Size(218, 24);
            label2.TabIndex = 32;
            label2.Text = "Student Group List";
            // 
            // GrupesGV
            // 
            GrupesGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrupesGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GrupesGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrupesGV.Location = new Point(23, 162);
            GrupesGV.Margin = new Padding(3, 4, 3, 4);
            GrupesGV.Name = "GrupesGV";
            GrupesGV.RowHeadersWidth = 51;
            GrupesGV.Size = new Size(383, 239);
            GrupesGV.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 30;
            label1.Text = "Grades";
            // 
            // button7
            // 
            button7.Location = new Point(263, 123);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 31);
            button7.TabIndex = 78;
            button7.Text = "Refresh";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(181, 123);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 31);
            button8.TabIndex = 77;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // SelectStudent
            // 
            SelectStudent.FormattingEnabled = true;
            SelectStudent.Location = new Point(35, 124);
            SelectStudent.Name = "SelectStudent";
            SelectStudent.Size = new Size(151, 28);
            SelectStudent.TabIndex = 76;
            SelectStudent.Text = "SelectStudent";
            // 
            // Student_view
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(453, 450);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(SelectStudent);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(GrupesGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_view";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_view";
            Load += Student_view_Load;
            ((System.ComponentModel.ISupportInitialize)GrupesGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label2;
        private DataGridView GrupesGV;
        private Label label1;
        private Button button7;
        private Button button8;
        private ComboBox SelectStudent;
    }
}