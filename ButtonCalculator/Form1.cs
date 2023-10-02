using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCalculator
{
    public partial class Form1 : Form
    {
        private char _process;
        private bool _clean;
        private int _previous;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                lblScreen.Text = "";
                _clean = false;
            }
            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                lblScreen.Text = "";
                _clean = false;
            }
            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                lblScreen.Text = "";
                _clean = false;
            }
            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                lblScreen.Text = "";
                _clean = false;
            }
            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                lblScreen.Text = "";
                _clean = false;
            }
            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                lblScreen.Text = "";
                _clean = false;
            }
            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                lblScreen.Text = "";
                _clean = false;
            }
            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                lblScreen.Text = "";
                _clean = false;
            }
            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                lblScreen.Text = "";
                _clean = false;
            }
            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                lblScreen.Text = "";
                _clean = false;
            }
            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "0";
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            _process = '+';
            _clean = true;
            _previous = Convert.ToInt32(lblScreen.Text);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            _process = '-';
            _clean = true;
            _previous = Convert.ToInt32(lblScreen.Text);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            _process = '*';
            _clean = true;
            _previous = Convert.ToInt32(lblScreen.Text);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            _process = '/';
            _clean = true;
            _previous = Convert.ToInt32(lblScreen.Text);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            int current = Convert.ToInt32(lblScreen.Text);
            int equal = 0;

            if (_process == '+') equal = _previous + Convert.ToInt32(lblScreen.Text);
            if (_process == '-') equal = _previous - Convert.ToInt32(lblScreen.Text);
            if (_process == '*') equal = _previous * Convert.ToInt32(lblScreen.Text);
            if (_process == '/') equal = _previous / Convert.ToInt32(lblScreen.Text);
            lblScreen.Text = Convert.ToString(equal);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            lblScreen.Text = "0";
        }
    }
}
