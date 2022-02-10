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

namespace AutoClicker
{
    public partial class AutoClickerApp : Form
    {
        public AutoClickerApp()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, mActionHotKeyID, 0, (int)Keys.F6);
        }

        // -------------- on load: set up default values --------------
        private Random rnd = new Random();
        private int originalInterval = 0;
        private int clickCount = 0;
        private int direction = 1;
        private void AutoClickerApp_Load(object sender, EventArgs e)
        {
            ClickButtonComboBox.SelectedIndex = 0;
        }

        // -------------- this allows to start clicker with global key press --------------
        private const int mActionHotKeyID = 1;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int key);

        // this external method is not being used in this case
        //[DllImport("user32.dll")]
        //public static extern bool UnregisterHotKey(IntPtr hwnd, int id);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyID)
            {
                StartClicker();
            }
            base.WndProc(ref m);
        }

        // -------------- this handles starting and stopping --------------
        // start button
        private void BtnStart_Click(object sender, EventArgs e) => StartClicker();

        // toggle the timer and set interval value
        private void StartClicker()
        {
            if (Timer.Enabled == true)
            {
                StopClicker();
                return;
            }
            int interval = (int)IntervalBox.Value;
            Timer.Enabled = true;
            Timer.Interval = interval;
            originalInterval = interval;
            BtnStart.Text = "Stop (F6)";
            BtnStart.BackColor = Color.DarkRed;
            this.Text = "Running - Auto Clicker App";

        }
        private void StopClicker()
        {
            Timer.Enabled = false;
            BtnStart.Text = "Start (F6)";
            BtnStart.BackColor = Color.DarkGreen;
            this.Text = "Stopped - Auto Clicker App";
            clickCount = 0;
        }

        // -------------- this handles the clicking --------------
        // this imported function does the actual click
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private void Timer_Tick(object sender, EventArgs e)
        {
            // if a limit is set, check every tick if limit reached
            if (RepeatUntilLimitRadio.Checked == true)
            if (clickCount == ClickLimitBox.Value) StopClicker();

            // do left or right mouse click
            if (ClickButtonComboBox.Text == "Left Click") DoLeftMouseClick();
            else DoRightMouseClick();
            clickCount++;
            CounterLabel.Text = clickCount.ToString();

            // MoveMousePosition() and  ChangeInterval() is called each timer tick randomly
            // this is an attempt to prevent detection
            int rndNum = rnd.Next(1, 11);
            if (rndNum == 1) MoveMousePosition();
            rndNum = rnd.Next(1, 4);
            if (rndNum == 1) ChangeInterval();
            // every 25 clicks reset interval to original value
            if (clickCount % 25 == 0)
			{
                Timer.Interval = originalInterval;
                IntervalBox.Value = originalInterval;
            }
		}

        public void DoLeftMouseClick()
        {
            // Call the imported function with the cursor's current position            
            uint Y = (uint)Cursor.Position.Y;
            uint X = (uint)Cursor.Position.X;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
        public void DoRightMouseClick()
        {
            // Call the imported function with the cursor's current position            
            uint Y = (uint)Cursor.Position.Y;
            uint X = (uint)Cursor.Position.X;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }

        // -------------- these functions are for anti-detection --------------
        // this will move the mouse position in a square pattern each time it is called 
        private void MoveMousePosition()
        {
            switch (direction)
            {
                case 1:
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 1);
                    direction = 2;
                    break;
                case 2:
                    Cursor.Position = new Point(Cursor.Position.X + 2, Cursor.Position.Y);
                    direction = 3;
                    break;
                case 3:
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
                    direction = 4;
                    break;
                case 4:
                    Cursor.Position = new Point(Cursor.Position.X - 2, Cursor.Position.Y);
                    direction = 1;
                    break;
            }
        }
        // this will change the interval from 1 to 5 milliseconds
        private void ChangeInterval()
		{
            int rndNum = rnd.Next(1, 6);
            int upOrDown = rnd.Next(1, 3);
            int newInterval = Timer.Interval += rndNum;
            if (newInterval < 1) return;
            if (upOrDown == 1) Timer.Interval = newInterval;
            else Timer.Interval = newInterval;
            IntervalBox.Value = Timer.Interval;
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();
    }
}
