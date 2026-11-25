namespace People
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            picMorning = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            monthCalendar1 = new MonthCalendar();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            picDay = new PictureBox();
            picEvening = new PictureBox();
            picNight = new PictureBox();
            button7 = new Button();
            button8 = new Button();
            label2 = new Label();
            button1 = new Button();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)picMorning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEvening).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNight).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(183, 57);
            button2.Name = "button2";
            button2.Size = new Size(163, 23);
            button2.TabIndex = 2;
            button2.Text = "Student Portal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // picMorning
            // 
            picMorning.Image = (Image)resources.GetObject("picMorning.Image");
            picMorning.Location = new Point(12, 12);
            picMorning.Name = "picMorning";
            picMorning.Size = new Size(165, 155);
            picMorning.SizeMode = PictureBoxSizeMode.StretchImage;
            picMorning.TabIndex = 3;
            picMorning.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(183, 100);
            button3.Name = "button3";
            button3.Size = new Size(163, 23);
            button3.TabIndex = 4;
            button3.Text = "Academic Planner";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCyan;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(183, 144);
            button4.Name = "button4";
            button4.Size = new Size(163, 23);
            button4.TabIndex = 5;
            button4.Text = "Class Timetables";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(358, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrange;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(358, 200);
            button5.Name = "button5";
            button5.Size = new Size(152, 23);
            button5.TabIndex = 7;
            button5.Text = "Qualifications/Courses";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCyan;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(12, 200);
            button6.Name = "button6";
            button6.Size = new Size(152, 23);
            button6.TabIndex = 8;
            button6.Text = "IIE Rosebank Website";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Desktop;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 257);
            label1.Name = "label1";
            label1.Size = new Size(573, 35);
            label1.TabIndex = 9;
            label1.Text = resources.GetString("label1.Text");
            // 
            // picDay
            // 
            picDay.Image = (Image)resources.GetObject("picDay.Image");
            picDay.Location = new Point(12, 12);
            picDay.Name = "picDay";
            picDay.Size = new Size(165, 155);
            picDay.SizeMode = PictureBoxSizeMode.StretchImage;
            picDay.TabIndex = 10;
            picDay.TabStop = false;
            // 
            // picEvening
            // 
            picEvening.Image = (Image)resources.GetObject("picEvening.Image");
            picEvening.Location = new Point(12, 12);
            picEvening.Name = "picEvening";
            picEvening.Size = new Size(164, 155);
            picEvening.SizeMode = PictureBoxSizeMode.StretchImage;
            picEvening.TabIndex = 11;
            picEvening.TabStop = false;
            picEvening.Visible = false;
            // 
            // picNight
            // 
            picNight.Image = (Image)resources.GetObject("picNight.Image");
            picNight.Location = new Point(12, 12);
            picNight.Name = "picNight";
            picNight.Size = new Size(164, 155);
            picNight.SizeMode = PictureBoxSizeMode.StretchImage;
            picNight.TabIndex = 12;
            picNight.TabStop = false;
            picNight.Visible = false;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkSlateBlue;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(272, 200);
            button7.Name = "button7";
            button7.Size = new Size(74, 23);
            button7.TabIndex = 13;
            button7.Text = "CloudLabs";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkSlateBlue;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(183, 200);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 14;
            button8.Text = "Github";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.FlatStyle = FlatStyle.Popup;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(550, 292);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 15;
            label2.Text = "v1.3.0";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(183, 12);
            button1.Name = "button1";
            button1.Size = new Size(163, 23);
            button1.TabIndex = 18;
            button1.Text = "ARC";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.LightGreen;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(517, 200);
            button10.Name = "button10";
            button10.Size = new Size(68, 23);
            button10.TabIndex = 20;
            button10.Text = "More...";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(599, 312);
            Controls.Add(button10);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(picNight);
            Controls.Add(picEvening);
            Controls.Add(picDay);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(monthCalendar1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(picMorning);
            Controls.Add(button2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Q.Launch";
            ((System.ComponentModel.ISupportInitialize)picMorning).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEvening).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private PictureBox picMorning;
        private Button button3;
        private Button button4;
        private MonthCalendar monthCalendar1;
        private Button button5;
        private Button button6;
        private Label label1;
        private PictureBox picDay;
        private PictureBox picEvening;
        private PictureBox picNight;
        private Button button7;
        private Button button8;
        private Label label2;
        private Button button1;
        private Button button10;
    }
}
