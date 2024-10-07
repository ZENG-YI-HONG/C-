using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pintoo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            rnd();
        }

        private void check()
        {
            if((button11.ImageIndex == 0 && button12.ImageIndex == 1 && button13.ImageIndex == 2 && button21.ImageIndex == 3 && button22.ImageIndex == 4 && button23.ImageIndex == 5 && button31.ImageIndex == 6 && button32.ImageIndex == 7))
            {
                label1.Text = "恭喜完成";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void rnd()
        {
            int[] randomArray = new int[8];
            Random rnd = new Random();  //產生亂數初始值
            for (int i = 0; i < 8; i++)
            {
                randomArray[i] = rnd.Next(0, 8);   //亂數產生，亂數產生的範圍是1~9

                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])    //檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0;  //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
                        randomArray[i] = rnd.Next(0, 8);   //重新產生，存回陣列，亂數產生的範圍是1~9
                    }
                }
            }
            button11.ImageIndex = randomArray[0]; button12.ImageIndex = randomArray[1]; button13.ImageIndex = randomArray[2];
            button21.ImageIndex = randomArray[3]; button22.ImageIndex = randomArray[4]; button23.ImageIndex = randomArray[5];
            button31.ImageIndex = randomArray[6]; button32.ImageIndex = randomArray[7]; button33.ImageIndex = 8;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (button12.ImageIndex == 8)
            {
                button12.ImageIndex = button11.ImageIndex;
                button11.ImageIndex = 8;
                 
                check();
            }
            else if (button21.ImageIndex == 8)
            {
                button21.ImageIndex = button11.ImageIndex;
                button11.ImageIndex = 8;
                 
                check();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rnd();
            label1.Text = "";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button21.ImageIndex == 8)
            {
                button21.ImageIndex = button31.ImageIndex;
                button31.ImageIndex = 8;
                 
                check();
            }
            else if (button32.ImageIndex == 8)
            {
                button32.ImageIndex = button31.ImageIndex;
                button31.ImageIndex = 8;
                 
                check();
            }


        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button22.ImageIndex == 8)
            {
                button22.ImageIndex = button32.ImageIndex;
                button32.ImageIndex = 8;
                 
                check();
            }
            else if (button31.ImageIndex == 8)
            {
                button31.ImageIndex = button32.ImageIndex;
                button32.ImageIndex = 8;
                 
                check();
            }
            else if (button33.ImageIndex == 8)
            {
                button33.ImageIndex = button32.ImageIndex;
                button32.ImageIndex = 8;
                 
                check();
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button11.ImageIndex == 8)
            {
                button11.ImageIndex = button12.ImageIndex;
                button12.ImageIndex = 8;
                 
                check();
            }
            else if (button13.ImageIndex == 8)
            {
                button13.ImageIndex = button12.ImageIndex;
                button12.ImageIndex = 8;
                 
                check();
            }
            else if (button22.ImageIndex == 8)
            {
                button22.ImageIndex = button12.ImageIndex;
                button12.ImageIndex = 8;
                 
                check();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button11.ImageIndex == 8)
            {
                button11.ImageIndex = button21.ImageIndex;
                button21.ImageIndex = 8;
                 
                check();
            }
            else if (button31.ImageIndex == 8)
            {
                button31.ImageIndex = button21.ImageIndex;
                button21.ImageIndex = 8;
                 
                check();
            }
            else if (button22.ImageIndex == 8)
            {
                button22.ImageIndex = button21.ImageIndex;
                button21.ImageIndex = 8;
                 
                check();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button12.ImageIndex == 8)
            {
                button12.ImageIndex = button22.ImageIndex;
                button22.ImageIndex = 8;
                 
                check();
            }
            else if (button21.ImageIndex == 8)
            {
                button21.ImageIndex = button22.ImageIndex;
                button22.ImageIndex = 8;
                 
                check();
            }
            else if (button32.ImageIndex == 8)
            {
                button32.ImageIndex = button22.ImageIndex;
                button22.ImageIndex = 8;
                 
                check();
            }
            else if (button23.ImageIndex == 8)
            {
                button23.ImageIndex = button22.ImageIndex;
                button22.ImageIndex = 8;
                 
                check();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button13.ImageIndex == 8)
            {
                button13.ImageIndex = button23.ImageIndex;
                button23.ImageIndex = 8;
                 
                check();
            }
            else if (button22.ImageIndex == 8)
            {
                button22.ImageIndex = button23.ImageIndex;
                button23.ImageIndex = 8;
                 
                check();
            }
            else if (button33.ImageIndex == 8)
            {
                button33.ImageIndex = button23.ImageIndex;
                button23.ImageIndex = 8;
                 
                check();
            }

        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button23.ImageIndex == 8)
            {
                button23.ImageIndex = button33.ImageIndex;
                button33.ImageIndex = 8;
                 
                check();
            }
            else if (button32.ImageIndex == 8)
            {
                button32.ImageIndex = button33.ImageIndex;
                button33.ImageIndex = 8;
                 
                check();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button12.ImageIndex == 8)
            {
                button12.ImageIndex = button13.ImageIndex;
                button13.ImageIndex = 8;
                 
                check();
            }
            else if (button23.ImageIndex == 8)
            {
                button23.ImageIndex = button13.ImageIndex;
                button13.ImageIndex = 8;
                 
                check();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button11.ImageIndex = 0; button12.ImageIndex = 1; button13.ImageIndex = 2;
           button21.ImageIndex = 3; button22.ImageIndex = 4; button23.ImageIndex = 5;
           button31.ImageIndex = 6; button32.ImageIndex = 7; button33.ImageIndex = 8;
            check();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; //1000毫秒
            timer1.Enabled = true; //計時器開始計時

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
    
}
