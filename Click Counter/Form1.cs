using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Counter
{
    public partial class Form1 : Form
    {
        int score = 0;
        int del = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            //randomColorGenerator();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Green) {
                addScore();
            }
            else if (button1.BackColor == Color.DarkCyan)
            {
                minusScore();
            }
            //button1.BackColor = Color.DarkCyan; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Green)
            {
                addScore();
            }
            else if (button2.BackColor == Color.DarkCyan)
            {
                minusScore();
            }
            // button2.BackColor = Color.DarkCyan; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Green)
            {
                addScore();
            }
            else if (button3.BackColor == Color.DarkCyan)
            {
                minusScore();
            }
            // button3.BackColor = Color.DarkCyan;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Green)
            {
                addScore();
            }
            else if (button4.BackColor == Color.DarkCyan)
            {
                minusScore();
            }
            // button4.BackColor = Color.DarkCyan; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Green)
            {
                addScore();
            }
            else if (button5.BackColor == Color.DarkCyan)
            {
                minusScore();
            }
            // button5.BackColor = Color.DarkCyan; 
        }   

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Green)
            {
                addScore();
            }
            else if (button6.BackColor == Color.DarkCyan)
            {
                minusScore();
            }
            //button6.BackColor = Color.DarkCyan;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Green)
            {
                addScore();
            }
            else if (button7.BackColor == Color.DarkCyan)
            {
                minusScore();
            }
            //button7.BackColor = Color.DarkCyan;
                
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Green)
            {
                addScore();
            }
            else if (button8.BackColor == Color.DarkCyan)
            {
                minusScore();
            }
            //button8.BackColor = Color.DarkCyan;
                
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Green)
            {
                addScore();
            }
            else if (button9.BackColor == Color.DarkCyan)
            {
                minusScore();
            }
            //button9.BackColor = Color.DarkCyan;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Green)
            {
                addScore();
            }
            else if (button10.BackColor == Color.DarkCyan)
            {
                minusScore();
            }
            //button10.BackColor = Color.DarkCyan;
        }
        
        public void addScore() {
            score += 10;
            scoreLbl.Text = score.ToString();
        }
        public void minusScore() {
            score -= 10;
            scoreLbl.Text = score.ToString();
        }
        public void randomColorGenerator() {
            int ajaira = random.Next(1, 11);
            del = ajaira;
            if (ajaira == 1) { button1.BackColor = Color.Green; }
            else if(ajaira == 2) { button2.BackColor = Color.Green; }
            else if(ajaira == 3) { button3.BackColor = Color.Green; }
            else if(ajaira == 4) { button4.BackColor = Color.Green; }
            else if(ajaira == 5) { button5.BackColor = Color.Green; }
            else if(ajaira == 6) { button6.BackColor = Color.Green; }
            else if (ajaira == 7) { button7.BackColor = Color.Green; }
            else if (ajaira == 8) { button8.BackColor = Color.Green; }
            else if (ajaira == 9) { button9.BackColor = Color.Green; }
            else if (ajaira == 10) { button10.BackColor = Color.Green; }
            timer1.Stop();
            timer1.Start();
        }
        public void colorRestore()
        {
            if (del == 1) { button1.BackColor = Color.DarkCyan; }
            else if (del == 2) { button2.BackColor = Color.DarkCyan; }
            else if (del == 3) { button3.BackColor = Color.DarkCyan; }
            else if (del == 4) { button4.BackColor = Color.DarkCyan; }
            else if (del == 5) { button5.BackColor = Color.DarkCyan; }
            else if (del == 6) { button6.BackColor = Color.DarkCyan; }
            else if (del == 7) { button7.BackColor = Color.DarkCyan; }
            else if (del == 8) { button8.BackColor = Color.DarkCyan; }
            else if (del == 9) { button9.BackColor = Color.DarkCyan; }
            else if (del == 10) { button10.BackColor = Color.DarkCyan; }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            colorRestore();
            //timer1.Stop();
            timer1.Start();
            randomColorGenerator();
        }
    }
}
