namespace Akademine_sistema
{
    partial class StudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMain));
            button5 = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(14, 141);
            button5.Name = "button5";
            button5.Size = new Size(340, 29);
            button5.TabIndex = 14;
            button5.Text = "Log out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 18);
            label1.Name = "label1";
            label1.Size = new Size(269, 41);
            label1.TabIndex = 13;
            label1.Text = "Student Page";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(14, 96);
            button1.Name = "button1";
            button1.Size = new Size(340, 29);
            button1.TabIndex = 12;
            button1.Text = "Grades";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StudentMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(388, 233);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label1;
        private Button button1;
    }
}