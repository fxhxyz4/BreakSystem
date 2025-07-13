namespace BreakSystem
{
    partial class BreakSystemUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakSystemUI));
            button1 = new Button();
            title = new Label();
            title2 = new Label();
            title3 = new Label();
            timeText = new TextBox();
            breakText = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("MS Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(240, 274);
            button1.Name = "button1";
            button1.Size = new Size(147, 32);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("MS Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            title.Location = new Point(304, 39);
            title.Name = "title";
            title.Size = new Size(177, 27);
            title.TabIndex = 1;
            title.Text = "BreakSystem";
            // 
            // title2
            // 
            title2.AutoSize = true;
            title2.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title2.Location = new Point(39, 135);
            title2.Name = "title2";
            title2.Size = new Size(298, 21);
            title2.TabIndex = 2;
            title2.Text = "Timer duration (minutes)";
            // 
            // title3
            // 
            title3.AutoSize = true;
            title3.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title3.Location = new Point(444, 135);
            title3.Name = "title3";
            title3.Size = new Size(298, 21);
            title3.TabIndex = 3;
            title3.Text = "Break duration (minutes)";
            // 
            // timeText
            // 
            timeText.BackColor = SystemColors.InfoText;
            timeText.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            timeText.ForeColor = SystemColors.InactiveCaption;
            timeText.Location = new Point(39, 181);
            timeText.Name = "timeText";
            timeText.Size = new Size(298, 28);
            timeText.TabIndex = 4;
            // 
            // breakText
            // 
            breakText.BackColor = SystemColors.InactiveCaptionText;
            breakText.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            breakText.ForeColor = SystemColors.InactiveCaption;
            breakText.Location = new Point(444, 181);
            breakText.Name = "breakText";
            breakText.Size = new Size(298, 28);
            breakText.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("MS Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(405, 274);
            button2.Name = "button2";
            button2.Size = new Size(147, 32);
            button2.TabIndex = 6;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BreakSystemUI
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(793, 455);
            Controls.Add(button2);
            Controls.Add(breakText);
            Controls.Add(timeText);
            Controls.Add(title3);
            Controls.Add(title2);
            Controls.Add(title);
            Controls.Add(button1);
            Cursor = Cursors.AppStarting;
            Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ActiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BreakSystemUI";
            Opacity = 0.8D;
            Text = "BreakSystem";
            TransparencyKey = Color.FromArgb(255, 128, 255);
            Load += BreakSystemUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label title;
        private Label title2;
        private Label title3;
        private TextBox timeText;
        private TextBox breakText;
        private Button button2;
    }
}
