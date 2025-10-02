using System.Runtime.InteropServices;

namespace DatabaseAnalyzer.Components
{
    public partial class TiltleBar : UserControl
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public TiltleBar()
        {
            InitializeComponent();

            minimizeButton.Click += MinimizeButton_Click;
            maximizeButton.Click += MaximizeButton_Click;
            closeButton.Click += CloseButton_Click;

            this.Load += TitleBar_Load;
            this.MouseDown += TitleBar_MouseDown;
            this.DoubleClick += TitleBar_DoubleClick;

            if (this.Controls.Count > 0)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (!(ctrl is Button))
                        ctrl.MouseDown += TitleBar_MouseDown;
                }
            }
        }

        private void TitleBar_Load(object? sender, EventArgs e)
        {
            Form? parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Resize += ParentForm_Resize;
                UpdateMaximizeIcon(parentForm.WindowState);
            }
        }

        private bool IsOverButton(System.Drawing.Point location)
        {
            return minimizeButton.Bounds.Contains(location) ||
                   maximizeButton.Bounds.Contains(location) ||
                   closeButton.Bounds.Contains(location);
        }

        private void TitleBar_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !IsOverButton(e.Location))
            {
                Form? parentForm = this.FindForm();
                if (parentForm != null)
                {
                    ReleaseCapture();
                    SendMessage(parentForm.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            }
        }

        private void TitleBar_DoubleClick(object? sender, EventArgs e)
        {
            Form? parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.WindowState = parentForm.WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            }
        }

        private void ParentForm_Resize(object? sender, EventArgs e)
        {
            if (sender is Form form)
            {
                UpdateMaximizeIcon(form.WindowState);
            }
        }

        private void UpdateMaximizeIcon(FormWindowState state)
        {
            if (state == FormWindowState.Maximized)
            {
                maximizeButton.Image = Properties.Resources.minimize_window;
            }
            else
            {
                maximizeButton.Image = Properties.Resources.fullscreen;
            }
        }

        private void CloseButton_Click(object? sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void MaximizeButton_Click(object? sender, EventArgs e)
        {
            Form? parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.WindowState = parentForm.WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            }
        }

        private void MinimizeButton_Click(object? sender, EventArgs e)
        {
            this.FindForm()!.WindowState = FormWindowState.Minimized;
        }
    }
}
