namespace Akademine_sistema
{
    partial class LecTur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecTur));
            button5 = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(36, 149);
            button5.Name = "button5";
            button5.Size = new Size(340, 29);
            button5.TabIndex = 11;
            button5.Text = "Log out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 26);
            label1.Name = "label1";
            label1.Size = new Size(276, 41);
            label1.TabIndex = 7;
            label1.Text = "Teacher Page";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(36, 104);
            button1.Name = "button1";
            button1.Size = new Size(340, 29);
            button1.TabIndex = 6;
            button1.Text = "Student Grade";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LecTur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(423, 208);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LecTur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LecTur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label1;
        private Button button1;
    }
}