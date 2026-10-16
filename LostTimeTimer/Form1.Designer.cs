namespace LostTimeTimer
{
    partial class Form1
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
            BtnStart = new Button();
            LblTimer = new Label();
            BtnStop = new Button();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(12, 49);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(75, 23);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // LblTimer
            // 
            LblTimer.AutoSize = true;
            LblTimer.Font = new Font("Segoe UI", 20F);
            LblTimer.Location = new Point(30, 9);
            LblTimer.Name = "LblTimer";
            LblTimer.Size = new Size(119, 37);
            LblTimer.TabIndex = 1;
            LblTimer.Text = "00:00:00";
            // 
            // BtnStop
            // 
            BtnStop.Location = new Point(93, 49);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(75, 23);
            BtnStop.TabIndex = 2;
            BtnStop.Text = "Stop";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(185, 81);
            Controls.Add(BtnStop);
            Controls.Add(LblTimer);
            Controls.Add(BtnStart);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "LostTimeTimer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStart;
        private Label LblTimer;
        private Button BtnStop;
    }
}
