using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
namespace People
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
