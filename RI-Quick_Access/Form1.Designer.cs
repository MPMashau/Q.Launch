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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            monthCalendar1 = new MonthCalendar();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(604, 335);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(182, 12);
            button1.Name = "button1";
            button1.Size = new Size(164, 25);
            button1.TabIndex = 1;
            button1.Text = "ARC";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
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
            button5.Location = new Point(183, 218);
            button5.Name = "button5";
            button5.Size = new Size(165, 23);
            button5.TabIndex = 7;
            button5.Text = "Qualifications/Courses";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCyan;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(12, 218);
            button6.Name = "button6";
            button6.Size = new Size(165, 23);
            button6.TabIndex = 8;
            button6.Text = "IIE Rosebank Website";
            button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Desktop;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 268);
            label1.Name = "label1";
            label1.Size = new Size(573, 35);
            label1.TabIndex = 9;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(599, 312);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(monthCalendar1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "RI - Quick Access";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button4;
        private MonthCalendar monthCalendar1;
        private Button button5;
        private Button button6;
        private Label label1;
    }
}
