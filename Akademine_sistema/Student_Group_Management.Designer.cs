namespace Akademine_sistema
{
    partial class Student_Group_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Group_Management));
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            GrupesGV = new DataGridView();
            GrupesName = new TextBox();
            GrupesID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)GrupesGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(690, 41);
            label1.TabIndex = 2;
            label1.Text = "Student Group Management System";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(168, 282);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 26;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(168, 243);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 25;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(168, 204);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 24;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GrupesGV
            // 
            GrupesGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrupesGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GrupesGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrupesGV.Location = new Point(281, 110);
            GrupesGV.Margin = new Padding(3, 4, 3, 4);
            GrupesGV.Name = "GrupesGV";
            GrupesGV.RowHeadersWidth = 51;
            GrupesGV.Size = new Size(383, 239);
            GrupesGV.TabIndex = 23;
            // 
            // GrupesName
            // 
            GrupesName.BackColor = SystemColors.ActiveCaption;
            GrupesName.Location = new Point(153, 158);
            GrupesName.Margin = new Padding(3, 4, 3, 4);
            GrupesName.Name = "GrupesName";
            GrupesName.Size = new Size(122, 27);
            GrupesName.TabIndex = 22;
            GrupesName.Text = "GrupesName";
            // 
            // GrupesID
            // 
            GrupesID.BackColor = SystemColors.ActiveCaption;
            GrupesID.Location = new Point(153, 123);
            GrupesID.Margin = new Padding(3, 4, 3, 4);
            GrupesID.Name = "GrupesID";
            GrupesID.Size = new Size(122, 27);
            GrupesID.TabIndex = 21;
            GrupesID.Text = "GrupesID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 126);
            label3.Name = "label3";
            label3.Size = new Size(107, 24);
            label3.TabIndex = 28;
            label3.Text = "GroupID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 82);
            label2.Name = "label2";
            label2.Size = new Size(218, 24);
            label2.TabIndex = 27;
            label2.Text = "Student Group List";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(168, 321);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 29;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1, 161);
            label4.Name = "label4";
            label4.Size = new Size(146, 24);
            label4.TabIndex = 30;
            label4.Text = "GroupName:";
            // 
            // Student_Group_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(690, 378);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(GrupesGV);
            Controls.Add(GrupesName);
            Controls.Add(GrupesID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_Group_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Group_Management";
            Load += Student_Group_Management_Load;
            ((System.ComponentModel.ISupportInitialize)GrupesGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView GrupesGV;
        private TextBox GrupesName;
        private TextBox GrupesID;
        private Label label3;
        private Label label2;
        private Button button4;
        private Label label4;
    }
}