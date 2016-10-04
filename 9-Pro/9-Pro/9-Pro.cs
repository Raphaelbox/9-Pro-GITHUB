using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            Button clickedButton = sender as Button;
            foreach (var b in buttons)
            {
                BackButton.Enabled = true;
                b.Enabled = false;
                b.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            foreach (var b in buttons)
            {
                b.Enabled = true;
                b.Visible = true;
                if (b.Enabled == true & b.Visible == true)
                    {
                        BackButton.Enabled = false;
                    }
            }
        }

        }
    }
