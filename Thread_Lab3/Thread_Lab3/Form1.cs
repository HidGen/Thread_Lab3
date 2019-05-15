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

namespace Thread_Lab3
{
    public partial class Form1 : Form
    {
        public delegate void MyDelegate();

        public Form1()
        {
            InitializeComponent();
        }

        ManualResetEvent _pauseEvent = new ManualResetEvent(true);
        Thread block_red;
        Thread block_orange;
        Thread block_yellow;
        Thread block_green;
        Thread block_blue;

        public async void button2_Click(object sender, EventArgs e)
        {
                button2.Visible = false;
            panel6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;

            block_red = new Thread(new ThreadStart(block1));
                block_red.Start();
                await Task.Delay(500);  
            block_orange = new Thread(new ThreadStart(block2));
                block_orange.Start();
                await Task.Delay(500);
                block_yellow = new Thread(new ThreadStart(block3));
                block_yellow.Start();
                await Task.Delay(500);
                block_green = new Thread(new ThreadStart(block4));
                block_green.Start();
                await Task.Delay(500);
                block_blue = new Thread(new ThreadStart(block5));
                block_blue.Start();
            button1.Visible = true;
        }

        public void block1()
        {
            panel1.BeginInvoke(new Action(() => { panel1.Visible = true; }));
            int w = 0;
            while (w < 350)
            {
                int r = panel1.Location.X;
                panel1.BeginInvoke(new Action(() => { panel1.Location = panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 2); }));
                w = panel1.Location.Y;
                Thread.Sleep(10);
                if (w == 332) 
                {
                    if ((StatClass.q <= 50) && (StatClass.w >= 50))
                    {
                        StatClass.catched++;
                        label1.BeginInvoke(new Action(() => { label1.Text = ("Catched: " + StatClass.catched); }));
                        Console.WriteLine("stat" + StatClass.catched);
                    }
                    else if ((StatClass.q <= 100) && (StatClass.w >= 100))
                    {
                        StatClass.catched++;
                        label1.BeginInvoke(new Action(() => { label1.Text = ("Catched: " + StatClass.catched); }));
                        Console.WriteLine("stat" + StatClass.catched);
                    }
                    else
                    {
                        StatClass.lost++;
                        label2.BeginInvoke(new Action(() => { label2.Text = ("Lost: " + StatClass.lost); }));
                    }
                }
            }
            if (w >= 350)
            {
                panel1.BeginInvoke(new Action(() => { panel1.Visible = false; }));
                panel1.BeginInvoke(new Action(() => { panel1.Location = panel1.Location = new Point(45, 26); }));
                Random rnd = new Random();
                int qwerty = rnd.Next(1, 10) * 100;
                Thread.Sleep(qwerty);
                block1();
            }
        }
        public void block2()
        {
            panel2.BeginInvoke(new Action(() => { panel2.Visible = true; }));
            int w = 0;
            while (w < 350)
            {
                panel2.BeginInvoke(new Action(() => { panel2.Location = panel2.Location = new Point(panel2.Location.X, panel2.Location.Y + 2); }));
                w = panel2.Location.Y;
                Thread.Sleep(10);
                if (w == 332)
                {
                    if ((StatClass.q <= 130) && (StatClass.w >= 130))
                    {
                        StatClass.catched++;
                        label1.BeginInvoke(new Action(() => { label1.Text = ("Catched: " + StatClass.catched); }));
                        Console.WriteLine("stat" + StatClass.catched);
                    }
                    else if ((StatClass.q <= 180) && (StatClass.w >= 180))
                    {
                        StatClass.catched++;
                        label1.BeginInvoke(new Action(() => { label1.Text = ("Catched: " + StatClass.catched); }));
                        Console.WriteLine("stat" + StatClass.catched);
                    }
                    else
                    {
                        StatClass.lost++;
                        label2.BeginInvoke(new Action(() => { label2.Text = ("Lost: " + StatClass.lost); }));
                    }
                }
            }
            if (w >= 350)
            {
                panel2.BeginInvoke(new Action(() => { panel2.Visible = false; }));
                panel2.BeginInvoke(new Action(() => { panel2.Location = panel2.Location = new Point(130, 26); }));
                Random rnd = new Random();
                int qwerty = rnd.Next(1, 10) * 100;
                Thread.Sleep(qwerty);
                block2();
                w = 0;
            }
        }

        public void block3()
        {
            panel3.BeginInvoke(new Action(() => { panel3.Visible = true; }));
            int w = 0;
            while (w < 350)
            {
                panel3.BeginInvoke(new Action(() => { panel3.Location = panel3.Location = new Point(panel3.Location.X, panel3.Location.Y + 2); }));
                w = panel3.Location.Y;
                Thread.Sleep(10);
                if (w == 332)
                {
                    if ((StatClass.q <= 210) && (StatClass.w >= 210))
                    {
                        StatClass.catched++;
                        label1.BeginInvoke(new Action(() => { label1.Text = ("Catched: " + StatClass.catched); }));
                        Console.WriteLine("stat" + StatClass.catched);
                    }
                    else if ((StatClass.q <= 260) && (StatClass.w >= 260))
                    {
                        StatClass.catched++;
                        label1.BeginInvoke(new Action(() => { label1.Text = ("Catched: " + StatClass.catched); }));
                        Console.WriteLine("stat" + StatClass.catched);
                    }
                    else
                    {
                        StatClass.lost++;
                        label2.BeginInvoke(new Action(() => { label2.Text = ("Lost: " + StatClass.lost); }));
                    }
                }
            }
            if (w >= 350)
            {
                panel3.BeginInvoke(new Action(() => { panel3.Visible = false; }));
                panel3.BeginInvoke(new Action(() => { panel3.Location = panel3.Location = new Point(210, 26); }));
                Random rnd = new Random();
                int qwerty = rnd.Next(1, 10) * 100;
                Thread.Sleep(qwerty);
                block3();
                w = 0;
            }

        }

        public void block4()
        {
            panel4.BeginInvoke(new Action(() => { panel4.Visible = true; }));
            int w = 0;
            while (w < 350)
            {
                panel4.BeginInvoke(new Action(() => { panel4.Location = panel4.Location = new Point(panel4.Location.X, panel4.Location.Y + 2); }));
                w = panel4.Location.Y;
                Thread.Sleep(10);
                if (w == 332)
                {
                    if ((StatClass.q <= 290) && (StatClass.w >= 290))
                    {
                        StatClass.catched++;
                        label1.BeginInvoke(new Action(() => { label1.Text = ("Catched: " + StatClass.catched); }));
                        Console.WriteLine("stat" + StatClass.catched);
                    }
                    else if ((StatClass.q <= 340) && (StatClass.w >= 340))
                    {
                        StatClass.catched++;
                        label1.BeginInvoke(new Action(() => { label1.Text = ("Catched: " + StatClass.catched); }));
                        Console.WriteLine("stat" + StatClass.catched);
                    }
                    else
                    {
                        StatClass.lost++;
                        label2.BeginInvoke(new Action(() => { label2.Text = ("Lost: " + StatClass.lost); }));
                    }
                }
            }
            if (w >= 350)
            {
                panel4.BeginInvoke(new Action(() => { panel4.Visible = false; }));
                panel4.BeginInvoke(new Action(() => { panel4.Location = panel4.Location = new Point(290, 26); }));
                Random rnd = new Random();
                int qwerty = rnd.Next(1, 10) * 100;
                Thread.Sleep(qwerty);
                block4();
            }
        }

        public void block5()
        {
            panel5.BeginInvoke(new Action(() => { panel5.Visible = true; }));
            int w = 0;
            while (w < 350)
            {
                panel5.BeginInvoke(new Action(() => { panel5.Location = panel5.Location = new Point(panel5.Location.X, panel5.Location.Y + 2); }));
                w = panel5.Location.Y;
                Thread.Sleep(10);
                if (w == 332)
                {
                    if ((StatClass.q <= 370) && (StatClass.w >= 370))
                    {
                        StatClass.catched++;
                        label1.BeginInvoke(new Action(() => { label1.Text = ("Catched: " + StatClass.catched); }));
                        Console.WriteLine("stat" + StatClass.catched);
                    }
                    else if ((StatClass.q <= 420) && (StatClass.w >= 420))
                    {
                        StatClass.catched++;
                        label1.BeginInvoke(new Action(() => { label1.Text = ("Catched: " + StatClass.catched); }));
                        Console.WriteLine("stat" + StatClass.catched);
                    }
                    else
                    {
                        StatClass.lost++;
                        label2.BeginInvoke(new Action(() => { label2.Text = ("Lost: " + StatClass.lost); }));
                    }
                }
            }
            if (w >= 350)
            {
                panel5.BeginInvoke(new Action(() => { panel5.Visible = false; }));
                panel5.BeginInvoke(new Action(() => { panel5.Location = panel5.Location = new Point(370, 26); }));
                Random rnd = new Random();
                int qwerty = rnd.Next(1, 10) * 100;
                Thread.Sleep(qwerty);
                block5();
            }

        }
               
        public void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;

            button1.Visible = false;
            button2.Visible = true;
            panel6.Visible = false;
            _pauseEvent.Reset();
            block_red.Abort();
            block_orange.Abort();
            block_yellow.Abort();
            block_green.Abort();
            block_blue.Abort();
            Thread.Sleep(100);
            panel1.Visible = false;
            panel1.Location = panel1.Location = new Point(45, 25);
            panel2.Visible = false;
            panel2.Location = panel2.Location = new Point(130, 25);
            panel3.Visible = false;
            panel3.Location = panel3.Location = new Point(210, 25);
            panel4.Visible = false;
            panel4.Location = panel4.Location = new Point(290, 25);
            panel5.Visible = false;
            panel5.Location = panel5.Location = new Point(370, 25);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            { panel6.Location = panel6.Location = new Point(panel6.Location.X + 25, panel6.Location.Y ); }
            else
            if (e.KeyCode == Keys.Z)
            { panel6.Location = panel6.Location = new Point(panel6.Location.X - 25, panel6.Location.Y); }

            StatClass.q = panel6.Location.X;
            StatClass.w = StatClass.q + 150;
            Console.WriteLine(StatClass.q);
            Console.WriteLine(StatClass.w);
        }
    }
}


