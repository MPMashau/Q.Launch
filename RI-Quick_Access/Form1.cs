
using QLaunch;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using static System.Net.WebRequestMethods;
namespace People
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime currentTime = DateTime.Now;
            picDay.Visible = false;
            picNight.Visible = false;
            picEvening.Visible = false;
            picMorning.Visible = false;

            if (currentTime.Hour >= 6 && currentTime.Hour < 12)
            {
                picMorning.Visible = true;
                SoundPlayer morning = new SoundPlayer("goodMorning.wav");
                morning.Play();
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
            {
                picDay.Visible = true;
                SoundPlayer day = new SoundPlayer("goodDay.wav");
                day.Play();
            }
            else if (currentTime.Hour >= 18 && currentTime.Hour < 22)
            {
                picEvening.Visible = true;
                SoundPlayer evening = new SoundPlayer("goodEvening.wav");
                evening.Play();
            }
            else
            {
                picNight.Visible = true;
                SoundPlayer night = new SoundPlayer("goodNight.wav");
                night.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arc = "https://mystudies.iie.edu.za/"; //link to the ARC in rosebank

            Process.Start(new ProcessStartInfo(arc) { UseShellExecute = true });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string studentPortal = "https://student.rosebankcollege.co.za/student-portal/"; //student portal link
            Process.Start(new ProcessStartInfo(studentPortal) { UseShellExecute = true });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string academicPlanner = "https://advtechonline.sharepoint.com/:f:/r/sites/RoseBankCollege2/RosebankCollege/Shared%20Documents/Academic%20Planners?csf=1&web=1&e=yLq3gF";
            Process.Start(new ProcessStartInfo(academicPlanner) { UseShellExecute = true });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string classTimetables = "https://advtechonline.sharepoint.com/sites/RoseBankCollege2/RosebankCollege/Shared%20Documents/Forms/AllItems.aspx?id=/sites/RoseBankCollege2/RosebankCollege/Shared%20Documents/Student%20Timetables&viewid=81e85945-1fb4-4701-941d-ec692ad84ec9"; //link to class timetables
            Process.Start(new ProcessStartInfo(classTimetables) { UseShellExecute = true });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string courses = "https://www.rbi.ac.za/qualifications/";
            Process.Start(new ProcessStartInfo(courses) { UseShellExecute = true });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string rosebankWebsite = "https://www.rbi.ac.za/";
            Process.Start(new ProcessStartInfo(rosebankWebsite) { UseShellExecute = true });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cloudLabs = "https://portal.cloudlabs.ai/";
            Process.Start(new ProcessStartInfo(cloudLabs) { UseShellExecute = true });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string github = "https://github.com/";
            Process.Start(new ProcessStartInfo(github) { UseShellExecute = true });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string repo = "https://github.com/xcmorgan/RI-Quick-Access";
            Process.Start(new ProcessStartInfo(repo) { UseShellExecute = true });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
