using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace hit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[] btn = new Button[9];
        int hit = 0;
        int miss = 0;
        int temp = 0;
        int att = 0;
        double sec;

        private void Form1_Load(object sender, EventArgs e)
        {
            btn[0] = button1; btn[1] = button2; btn[2] = button3;
            btn[3] = button4; btn[4] = button5; btn[5] = button6;
            btn[6] = button7; btn[7] = button8; btn[8] = button9;
            button2.Click += button1_Click; button3.Click += button1_Click;  //按下button3 button2 觸發button1_Click
            button4.Click += button1_Click; button5.Click += button1_Click;
            button6.Click += button1_Click; button7.Click += button1_Click;
            button8.Click += button1_Click; button9.Click += button1_Click;
            sec = 30;

            for (int i = 0; i < 9; i++)
            {
                btn[i].Text = "";
                btn[i].Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = "剩餘時間:" + (sec -= 0.1).ToString("#.0") + "秒";
            if (sec <= 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                for (int i = 0; i < 9; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int t = temp;
            Button btnClick = (Button)sender;
            if (btnClick.Text == "X")
            {
                att = 0;
                hit += 1;
                label2.Text = "擊中:" + hit.ToString() + "次";
                btnClick.Text = "";
            }
            else
            {
                att = 1;
                miss += 1;
                label3.Text = "失誤:" + miss.ToString() + "次";

            }

        }


        private void button10_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    timer2.Interval = 1000;
                    break;
                case 1:
                    timer2.Interval = 500;
                    break;
                case 2:
                    timer2.Interval = 250;
                    break;
                case 3:
                    timer2.Interval = 10;
                    break;
            }
            hit = 0; miss = 0;
            label2.Text = "擊中:" + hit.ToString() + "次";
            label3.Text = "失誤:" + (miss+temp).ToString() + "次";
            for (int i = 0; i < 9; i++)
            {
                btn[i].Text = "";
                btn[i].Enabled = true;
            }
            button10.Enabled = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            att = 0;
            for (int i = 0; i < 9; i++)
            {
                btn[i].Text = "";
            }
            Random rnd = new Random();
            //int temp = rnd.Next(0, 9);
            btn[rnd.Next(0, 9)].Text = "X";
            if(att == 1)
            {
                temp += 1;
                label4.Text = "" + temp;
            }


        }

        private void comboBox1_StyleChanged(object sender, EventArgs e)
        {
            button10.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button10.Enabled = true;
        }
    }
}
