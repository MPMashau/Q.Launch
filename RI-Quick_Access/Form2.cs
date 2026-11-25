using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLaunch
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string claude = "https://claude.ai/new";
            Process.Start(new ProcessStartInfo(claude) { UseShellExecute = true });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string noteBook = "https://notebook.google.com/";
            Process.Start(new ProcessStartInfo(noteBook) { UseShellExecute = true });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chatGpt = "https://chatgpt.com/";
            Process.Start(new ProcessStartInfo(chatGpt) { UseShellExecute = true });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string zAi = "https://chat.z.ai/";
            Process.Start(new ProcessStartInfo(zAi) { UseShellExecute = true });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string perchance = "https://perchance.org/generators";
            Process.Start(new ProcessStartInfo(perchance) { UseShellExecute = true });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string dataBricks = "https://www.databricks.com/";
            Process.Start(new ProcessStartInfo(dataBricks) { UseShellExecute = true });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string alx = "https://www.alxafrica.com/";
            Process.Start(new ProcessStartInfo(alx) { UseShellExecute = true });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string freeCodeCamp = "https://www.freecodecamp.org/";
            Process.Start(new ProcessStartInfo(freeCodeCamp) { UseShellExecute = true });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string growWithGoogle = "https://grow.google/intl/ssa-en/";
            Process.Start(new ProcessStartInfo(growWithGoogle) { UseShellExecute = true });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string msLearn = "https://learn.microsoft.com/en-us/";
            Process.Start(new ProcessStartInfo(msLearn) { UseShellExecute = true });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string w3Schools = "https://www.w3schools.com/";
            Process.Start(new ProcessStartInfo(w3Schools) { UseShellExecute = true });
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string linkedIn = "https://www.linkedin.com/in/prince-mashau-784124354/?lipi=urn%3Ali%3Apage%3Ad_flagship3_profile_view_base_contact_details%3BewEHv49tQriMXGVIrHkKDw%3D%3D";
            Process.Start(new ProcessStartInfo(linkedIn) { UseShellExecute = true });
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string whatsappChannel = "https://whatsapp.com/channel/0029Vb9XZbl0wajqruispm3g";
            Process.Start(new ProcessStartInfo(whatsappChannel) { UseShellExecute = true });
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string repo = "https://github.com/xcmorgan/";
            Process.Start(new ProcessStartInfo(repo) { UseShellExecute = true });
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string msStudio = "https://visualstudio.microsoft.com/downloads/";
            Process.Start(new ProcessStartInfo(msStudio) { UseShellExecute = true });
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string vsCode = "https://code.visualstudio.com/download";
            Process.Start(new ProcessStartInfo(vsCode) { UseShellExecute = true });
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string netBeans = "https://netbeans.apache.org/index.html";
            Process.Start(new ProcessStartInfo(netBeans) { UseShellExecute = true});
        }
    }
}
