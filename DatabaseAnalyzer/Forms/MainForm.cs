using System.Drawing.Drawing2D;

namespace DatabaseAnalyzer.Forms;

public partial class MainForm : Form
{
    private int cornerRadius = 20;
    private int borderSize = 1;
    private Color borderColor = Color.DarkSlateGray;
    private Color defaultBackColor = Color.FromArgb(28, 29, 34);
    private Color selectedButtonBackColor = Color.FromArgb(36, 60, 104);

    public MainForm()
    {
        InitializeComponent();

        this.FormBorderStyle = FormBorderStyle.None;
        this.Padding = new Padding(borderSize);

        this.Load += MainForm_Load;
        this.Paint += MainForm_Paint;
        this.Resize += MainForm_Resize;

        homeButton.Click += HomeButton_Click;
        connectButton.Click += ConnectButton_Click;
        compareButton.Click += CompareButton_Click;
        syncButton.Click += SyncButton_Click;
        reportButton.Click += ReportButton_Click;
        snapshotButton.Click += SnapshotButton_Click;
        compareWithSnapshotButton.Click += CompareWithButton_Click;
        viewDifferencesButton.Click += ViewDifferencesButton_Click;
    }

    private void MainForm_Paint(object? sender, PaintEventArgs e)
    {
        FormRegionAndBorder(this, cornerRadius, e.Graphics, borderColor, borderSize);
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        HomeButton_Click(homeButton, EventArgs.Empty);
    }

    private void MainForm_Resize(object? sender, EventArgs e)
    {
        this.Invalidate();
    }

    private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
    {
        GraphicsPath path = new GraphicsPath();
        float curveSize = radius * 2F;

        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }

    private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
    {
        if (this.WindowState != FormWindowState.Minimized)
        {
            using (GraphicsPath roundedPath = GetRoundedPath(form.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                
                form.Region = new Region(roundedPath);

                if (borderSize >= 1)
                {
                    Rectangle rect = form.ClientRectangle;
                    rect.X += (int)(borderSize / 2);
                    rect.Y += (int)(borderSize / 2);
                    rect.Width -= (int)(borderSize);
                    rect.Height -= (int)(borderSize);

                    using (GraphicsPath borderPath = GetRoundedPath(rect, radius - borderSize / 2f))
                    {
                        graph.DrawPath(penBorder, borderPath);
                    }
                }
            }
        }
    }

    private void ViewDifferencesButton_Click(object? sender, EventArgs e)
    {
        SetActiveButton(viewDifferencesButton);
    }

    private void CompareWithButton_Click(object? sender, EventArgs e)
    {
        SetActiveButton(compareWithSnapshotButton);
    }

    private void SnapshotButton_Click(object? sender, EventArgs e)
    {
        SetActiveButton(snapshotButton);
    }

    private void ReportButton_Click(object? sender, EventArgs e)
    {
        SetActiveButton(reportButton);
    }

    private void SyncButton_Click(object? sender, EventArgs e)
    {
        SetActiveButton(syncButton);
    }
    private void CompareButton_Click(object? sender, EventArgs e)
    {
        var comparePage = new ComparePage();
        comparePage.Dock = DockStyle.Fill;
        splitContainer.Panel2.Controls.Clear();
        splitContainer.Panel2.Controls.Add(comparePage);
        comparePage.Show();
        SetActiveButton(compareButton);
    }
    private void ConnectButton_Click(object? sender, EventArgs e)
    {
        var connectPage = new ConnectPage();
        connectPage.Dock = DockStyle.Fill;
        splitContainer.Panel2.Controls.Clear();
        splitContainer.Panel2.Controls.Add(connectPage);
        connectPage.Show();
        SetActiveButton(connectButton);
    }
    private void HomeButton_Click(object? sender, EventArgs e)
    {
        var home = new HomePage();
        home.Dock = DockStyle.Fill;
        splitContainer.Panel2.Controls.Clear();
        splitContainer.Panel2.Controls.Add(home);
        home.Show();
        SetActiveButton(homeButton);
    }

    private void SetActiveButton(Button activeButton)
    {
        ResetButtonColors(splitContainer.Panel1);
        
        if (activeButton != null)
            activeButton.BackColor = selectedButtonBackColor;
    }

    private void ResetButtonColors(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            if (control is Button btn)
            {
                btn.BackColor = defaultBackColor;
            }
            else if (control.HasChildren)
            {
                ResetButtonColors(control);
            }
        }
    }
}
