using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool state = false;
        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            random.Next(1200);
            progressBar1.Value = 0;
            SetCursorPos(random.Next(1200), random.Next(600));
            for (int i = 0; i < 100; i++)
            {
                SetCursorPos(random.Next(10,1800), random.Next(150,900));
                Thread.Sleep(10);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                progressBar1.Value = i+1;
                //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
            progressBar1.Value = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var x = Cursor.Position.X;
            var y = Cursor.Position.Y;
            string text = $"X: {x}\t Y: {y}";
            label2.Text = text;
            if (checkBox1.Checked)
            {
                IntPtr hDC = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(hDC))
                {
                    g.DrawString(text, this.Font, Brushes.Red, x + 10, y + 10);
                }
                ReleaseDC(IntPtr.Zero, hDC);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            int num = (int)numericUpDown1.Value;
            progressBar1.Maximum = num;
            SetCursorPos(int.Parse(TextBoxX.Text), int.Parse(TextBoxY.Text));
            for (int i = 0; i < num; i++)
            {
                progressBar1.Value = i+1;
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                Thread.Sleep(1);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                label1.Text = $"Clicks:{i+1}";
            }
            progressBar1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (state is false)
            { 
                timer1.Start();
                state = true;
            }
            else
            {
                timer1.Stop();
                state = false;
            }
        }
    }
}
