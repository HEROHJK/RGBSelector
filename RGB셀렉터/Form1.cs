using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RGB셀렉터
{
    public partial class Form1 : Form
    {
        public static bool spoidMode = false;
        public Form1()
        {
            InitializeComponent();

            MouseHook.Start();
            MouseHook.MouseUpAction += new EventHandler(MouseUpEvent);
            MouseHook.MouseMoveAction += new EventHandler(MouseMoveEvent);
        }

        void MouseUpEvent(object sender, EventArgs e)
        {
            if (!spoidMode) return;
            Cursor.Current = Cursors.Default;
            spoidMode = false;
        }

        void MouseMoveEvent(object sender, EventArgs e)
        {
            if (!spoidMode) return;
            var value = sender as Point;
            SetColorValue(new RGB(GetScreenColor(value.x, value.y)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetColorValue(new RGB(200, 200, 200));
        }

        void SetColorValue(RGB rgb)
        {
            redTextBox.Text = rgb.red.ToString();
            redScrollBar.Value = rgb.red;

            greenTextBox.Text = rgb.green.ToString();
            greenScrollBar.Value = rgb.green;

            blueTextBox.Text = rgb.blue.ToString();
            blueScrollBar.Value = rgb.blue;

            hexTextBox.Text = rgb.ToString();

            rgbBox.BackColor = rgb.ToColor();
        }

        RGB ChangeRGB(string control)
        {
            var rgb = new RGB(rgbBox.BackColor);
            try
            {
                switch (control)
                {
                    case "redTextBox":
                        rgb.red = Convert.ToInt32(redTextBox.Text); break;
                    case "redScrollBar":
                        rgb.red = redScrollBar.Value; break;
                    case "greenTextBox":
                        rgb.green = Convert.ToInt32(greenTextBox.Text); break;
                    case "greenScrollBar":
                        rgb.green = greenScrollBar.Value; break;
                    case "blueTextBox":
                        rgb.blue = Convert.ToInt32(blueTextBox.Text); break;
                    case "blueScrollBar":
                        rgb.blue = blueScrollBar.Value; break;
                    case "hexTextBox":
                        rgb = new RGB(hexTextBox.Text); break;
                }
            }
            catch
            {
                rgb = new RGB(rgbBox.BackColor);
            }

            return rgb;
        }

        Color GetScreenColor(int x, int y)
        {
            Bitmap bmp = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(x, y, 0, 0, new Size(1, 1));

            return bmp.GetPixel(0, 0);
        }

        private void TextBoxValueChange(object sender, KeyEventArgs e)
        {
            var control = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                var rgb = new RGB(rgbBox.BackColor);
                try
                {
                    SetColorValue(ChangeRGB(control.Name));
                }
                catch
                {
                    SetColorValue(rgb);
                }
            }
        }

        private void ScrollBarValueChanged(object sender, EventArgs e)
        {
            var control = sender as HScrollBar;

            SetColorValue(ChangeRGB(control.Name));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { String temp = ""; temp = String.Format("x : {0} y : {1}", e.X, e.Y); Console.WriteLine(temp); }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            spoidMode = true;
            Cursor.Current = Cursors.Cross;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MouseHook.stop();
        }

        private void TextBoxFocusOut(object sender, EventArgs e)
        {
            var control = sender as TextBox;
            var rgb = new RGB(rgbBox.BackColor);
            try
            {
                SetColorValue(ChangeRGB(control.Name));
            }
            catch
            {
                SetColorValue(rgb);
            }
        }
    }

    class RGB
    {
        #region 변수
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        #endregion

        #region 생성자들
        public RGB()
        {
            red = 0;
            green = 0;
            blue = 0;
        }
        public RGB(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        public RGB(string hexString)
        {
            hexString = hexString.Replace("#", "").Trim(' ');

            red = Convert.ToInt32(hexString.Substring(0, 2), 16);
            green = Convert.ToInt32(hexString.Substring(2, 2), 16);
            blue = Convert.ToInt32(hexString.Substring(4, 2), 16);
            red = green = blue = 0;
        }
        public RGB(Color color)
        {
            red = color.R;
            green = color.G;
            blue = color.B;
        }
        #endregion

        #region 변환
        override public string ToString()
        {
            return string.Format("#{0}{1}{2}",
                red.ToString("X2"),
                green.ToString("X2"),
                blue.ToString("X2"));
        }
        public Color ToColor()
        {
            return Color.FromArgb(red, green, blue);
        }
        #endregion
    }

    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public static class MouseHook
    {
        public static event EventHandler MouseUpAction = delegate { };
        public static event EventHandler MouseMoveAction = delegate { };

        public static void Start()
        {
            _hookID = SetHook(_proc);


        }
        public static void stop()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                  GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
          int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (!Form1.spoidMode) return CallNextHookEx(_hookID, nCode, wParam, lParam);
            if (nCode >= 0 && MouseMessages.WM_LBUTTONUP == (MouseMessages)wParam)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                MouseUpAction(null, new EventArgs());
            }
            else if (nCode >= 0 && MouseMessages.WM_MOUSEMOVE == (MouseMessages)wParam)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                MouseMoveAction(new Point(hookStruct.pt.x, hookStruct.pt.y), new EventArgs());
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
          LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
          IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);


    }
}
