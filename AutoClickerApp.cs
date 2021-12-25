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

        // -------------- on load: set up default settings --------------
        private void AutoClickerApp_Load(object sender, EventArgs e)
        {
            ClickButtonComboBox.SelectedIndex = 0;
            IntervalBox.Value = 100;
        }

        // -------------- this allows for global keyboard presses --------------
        const int mActionHotKeyID = 1;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int key);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hwnd, int id);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyID)
            {
                StartClicker();
            }
            base.WndProc(ref m);
        }

        // -------------- this allows for setting cursor position and cursor clicks --------------
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private int clickCount = 0;

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
            BtnStart.Text = "Stop (F6)";
            this.Text = "Running - Auto Clicker App";
            
        }
        private void StopClicker()
        {
            Timer.Enabled = false;
            BtnStart.Text = "Start (F6)";
            this.Text = "Stopped - Auto Clicker App";
            clickCount = 0;
        }

        // this is called every timer tick
        private void Timer_Tick(object sender, EventArgs e)
        {
            DoMouseClick();
            clickCount++;
            CounterLabel.Text = clickCount.ToString();

            // if limit is set check every tick if clickCount == limit
            if (RepeatUntilLimitRadio.Checked == true)
                if (clickCount == ClickLimitBox.Value) StopClicker();
        }

        // this set the current cursor position and calls mouse_event()
        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position            
            uint Y = (uint)Cursor.Position.Y;
            uint X = (uint)Cursor.Position.X;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();



        // NOTES: study how this is working and get a good idea before continuing
        // Future plans?
        // - allow for right OR left click?
        // - move the x and y a small amount randomly to prevent detection
        // - allow for setting a certain number of clicks OR click until stop
    }
}
