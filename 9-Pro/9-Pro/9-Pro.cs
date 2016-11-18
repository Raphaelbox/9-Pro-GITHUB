using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _9_Pro
{
    public partial class Form1 : Form
    {
        private readonly Button[] buttons;
        private string path = Path.GetDirectoryName(Application.ExecutablePath);

        //Button2
        public Process prc = new Process();
        public string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public string windir = Environment.GetEnvironmentVariable("WINDIR");

        //Stuff in Form
        public Form1()
        {
            InitializeComponent();
            Tabs.SelectTab(0);
            BackButton.Enabled = false;
            buttons = new[]
            {
                button1, button2, button3,
                button6, button5, button4,
                button7, button8, button9
            };
        }

        //Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            Tabs.SelectTab(1);
            /*Process.Start("calc.exe");
            var timer1 = new Timer();
            timer1.Interval = 3000;
            timer1.Tick += (obj, args) => { Tabs.SelectTab(0); };
            timer1.Start();
            */
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;
                BackButton.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(2);
            var clickedButton = sender as Button;
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;
                BackButton.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(3);
            var clickedButton = sender as Button;
            Process.Start("www.youtube.com");
            var timer2 = new Timer();
            timer2.Interval = 3000;
            timer2.Tick += (obj, args) => { Tabs.SelectTab(0); };
            timer2.Start();
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;
                BackButton.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(4);
            var clickedButton = sender as Button;
            Process.Start("http://www.quickmeme.com/");
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;
                BackButton.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(5);
            var clickedButton = sender as Button;
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;
                BackButton.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(6);
            var clickedButton = sender as Button;
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;
                BackButton.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(7);
            var clickedButton = sender as Button;
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;
                BackButton.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(8);
            var clickedButton = sender as Button;
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;
                BackButton.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(9);
            var clickedButton = sender as Button;
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;
                BackButton.Enabled = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(0);
            foreach (var b in buttons)
            {
                b.Enabled = true;
                b.Visible = true;
                if (Tabs.SelectedIndex == 0)
                {
                    BackButton.Enabled = false;
                    ;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Tab1
        private static Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        private void tab1BopenCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }


        }

        //Tab2
        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void tab2button1_Click(object sender, EventArgs e)
        {
            var deskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = deskPath;
            prc.Start();
        }

        private void tab2button2_Click(object sender, EventArgs e)
        {
            var downloadPath = Path.Combine(userPath, "Downloads");
            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = downloadPath;
            prc.Start();
        }

        private void tab2button3_Click(object sender, EventArgs e)
        {
            var docsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = docsPath;
            prc.Start();
        }

        private void tab2button4_Click(object sender, EventArgs e)
        {
            var pcPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = pcPath;
            prc.Start();
        }

        private void tab2button5_Click(object sender, EventArgs e)
        {
            var musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = musicPath;
            prc.Start();
        }

        private void tab2button6_Click(object sender, EventArgs e)
        {
            var picsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = picsPath;
            prc.Start();
        }

        private void tab2button7_Click(object sender, EventArgs e)
        {
            var vidsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = vidsPath;
            prc.Start();
        }

        private void tab2button9_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Made by Yoni & Raphael!");
        }

        private void btn1tab_Click(object sender, EventArgs e)
        {

        }

        private void tab1Broot_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}