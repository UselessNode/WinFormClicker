using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Auto
{
    public partial class Form1 : Form
    {
        private Point clickPosition;
        private bool isPositionSelected = false;
        private bool isRunning = false;

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        public Form1()
        {
            InitializeComponent();
            // Синхронизация NumericUpDown и TrackBar для кликов
            numericUpDownClicks.ValueChanged += (s, e) => trackBarClicks.Value = (int)numericUpDownClicks.Value;
            trackBarClicks.Scroll += (s, e) => numericUpDownClicks.Value = trackBarClicks.Value;
            // Синхронизация NumericUpDown и TrackBar для интервала
            numericUpDownInterval.ValueChanged += (s, e) => trackBarInterval.Value = (int)numericUpDownInterval.Value;
            trackBarInterval.Scroll += (s, e) => numericUpDownInterval.Value = trackBarInterval.Value;
        }

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кликните на экране, чтобы выбрать позицию для кликов.");
            isPositionSelected = false;
            // Запускаем таймер для отслеживания клика мыши
            var timer = new System.Windows.Forms.Timer { Interval = 100 };
            timer.Tick += (s, ev) =>
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    clickPosition = Cursor.Position;
                    labelPosition.Text = $"X: {clickPosition.X}, Y: {clickPosition.Y}";
                    isPositionSelected = true;
                    timer.Stop();
                }
            };
            timer.Start();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!isPositionSelected)
            {
                //MessageBox.Show("Сначала выберите позицию для кликов.");
                return;
            }
            if (isRunning)
            {
                //MessageBox.Show("Автокликер уже запущен.");
                return;
            }
            isRunning = true;
            int totalClicks = (int)numericUpDownClicks.Value;
            int interval = (int)numericUpDownInterval.Value;
            progressBar.Maximum = totalClicks;
            progressBar.Value = 0;
            labelClickCount.Text = "Кликов: 0";
            labelClicksRemaining.Text = $"Осталось: {totalClicks}";

            Thread clickThread = new Thread(() =>
            {
                for (int i = 0; i < totalClicks; i++)
                {
                    if (!isRunning) break;
                    SetCursorPos(clickPosition.X, clickPosition.Y);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    Invoke(new Action(() =>
                    {
                        progressBar.Value = i + 1;
                        labelClickCount.Text = $"Кликов: {i + 1}";
                        labelClicksRemaining.Text = $"Осталось: {totalClicks - i - 1}";
                    }));
                    Thread.Sleep(interval);
                }
                isRunning = false;
            });
            clickThread.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            isRunning = false;
            base.OnFormClosing(e);
        }
    }
}