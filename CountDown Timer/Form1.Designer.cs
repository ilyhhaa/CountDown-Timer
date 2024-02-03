namespace CountDown_Timer
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
            components = new System.ComponentModel.Container();
            TopLabel = new Label();
            Timerlabel = new Label();
            resetButton = new Button();
            stopButton = new Button();
            startButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            plusbutton = new Button();
            minusbutton = new Button();
            SuspendLayout();
            // 
            // TopLabel
            // 
            TopLabel.Font = new Font("Copperplate Gothic Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TopLabel.Location = new Point(291, 9);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(227, 63);
            TopLabel.TabIndex = 0;
            TopLabel.Text = "Count Down Timer";
            TopLabel.TextAlign = ContentAlignment.TopCenter;
            TopLabel.Click += label1_Click;
            // 
            // Timerlabel
            // 
            Timerlabel.Font = new Font("Copperplate Gothic Bold", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            Timerlabel.Location = new Point(291, 116);
            Timerlabel.Name = "Timerlabel";
            Timerlabel.Size = new Size(227, 63);
            Timerlabel.TabIndex = 1;
            Timerlabel.Text = "60 seconds\r\n";
            Timerlabel.TextAlign = ContentAlignment.TopCenter;
            Timerlabel.Click += label1_Click_1;
            // 
            // resetButton
            // 
            resetButton.BackColor = SystemColors.MenuHighlight;
            resetButton.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(244, 182);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(160, 54);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.IndianRed;
            stopButton.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            stopButton.Location = new Point(426, 182);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(161, 54);
            stopButton.TabIndex = 3;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += stopButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.Desktop;
            startButton.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(244, 251);
            startButton.Name = "startButton";
            startButton.Size = new Size(343, 50);
            startButton.TabIndex = 4;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // plusbutton
            // 
            plusbutton.BackColor = SystemColors.MenuHighlight;
            plusbutton.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plusbutton.Location = new Point(244, 307);
            plusbutton.Name = "plusbutton";
            plusbutton.Size = new Size(160, 54);
            plusbutton.TabIndex = 5;
            plusbutton.Text = "+";
            plusbutton.UseVisualStyleBackColor = false;
            plusbutton.Click += plusbutton_Click;
            // 
            // minusbutton
            // 
            minusbutton.BackColor = SystemColors.MenuHighlight;
            minusbutton.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            minusbutton.Location = new Point(426, 307);
            minusbutton.Name = "minusbutton";
            minusbutton.Size = new Size(160, 54);
            minusbutton.TabIndex = 6;
            minusbutton.Text = "-";
            minusbutton.UseVisualStyleBackColor = false;
            minusbutton.Click += minusbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(minusbutton);
            Controls.Add(plusbutton);
            Controls.Add(startButton);
            Controls.Add(stopButton);
            Controls.Add(resetButton);
            Controls.Add(Timerlabel);
            Controls.Add(TopLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Countdown Timer";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label TopLabel;
        private Label Timerlabel;
        private Button resetButton;
        private Button stopButton;
        private Button startButton;
        private System.Windows.Forms.Timer timer;
        private Button plusbutton;
        private Button minusbutton;
    }
}