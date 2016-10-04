using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Pro
{
    public partial class Form1 : Form
    {
        private Button[] buttons;

        public Form1()
        {
            InitializeComponent();

            BackButton.Enabled = false;
            buttons = new Button[]
            {
                button1, button2, button3,
                button6, button5, button4,
                button7, button8, button9,
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(1);
            System.Diagnostics.Process.Start("calc.exe");
            System.Threading.Thread.Sleep(500);
            Tabs.SelectTab(0);
            BackButton.Enabled = false;

            //Junk, don't touch it
            Button clickedButton = sender as Button;
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(2);
            Button clickedButton = sender as Button;
            foreach (var b in buttons)
            {
                //b.Enabled = false;
                //b.Visible = false;;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Tabs.SelectTab(3);
            Button clickedButton = sender as Button;
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
            Button clickedButton = sender as Button;
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
            Button clickedButton = sender as Button;
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
            Button clickedButton = sender as Button;
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
            Button clickedButton = sender as Button;
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
            Button clickedButton = sender as Button;
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
            Button clickedButton = sender as Button;
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
                        BackButton.Enabled = false;;
                    }
            }
        }

        private void MainTab_Click(object sender, EventArgs e)
        {

        }
    }
    }
