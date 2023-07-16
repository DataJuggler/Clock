namespace Clock
{
    partial class ClockForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockForm));
            Timer = new System.Windows.Forms.Timer(components);
            DateLabel = new Label();
            TimeLabel = new Label();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 12000;
            Timer.Tick += Timer_Tick;
            // 
            // DateLabel
            // 
            DateLabel.Dock = DockStyle.Bottom;
            DateLabel.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.ForeColor = Color.Firebrick;
            DateLabel.Location = new Point(0, 74);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(344, 48);
            DateLabel.TabIndex = 1;
            DateLabel.Text = "Saturday October 16, 2023";
            DateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            TimeLabel.Dock = DockStyle.Fill;
            TimeLabel.Font = new Font("Bookman Old Style", 48F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = Color.Firebrick;
            TimeLabel.Location = new Point(0, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(344, 74);
            TimeLabel.TabIndex = 2;
            TimeLabel.Text = "9:43 PM";
            TimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClockForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(344, 122);
            Controls.Add(TimeLabel);
            Controls.Add(DateLabel);
            Font = new Font("Verdana", 48F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(800, 600);
            Name = "ClockForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Clock";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private Label DateLabel;
        private Label TimeLabel;
    }
}