using System.Drawing.Drawing2D;

namespace DatabaseAnalyzer.Components
{
    public partial class RoundedButton : Button
    {
        public int CornerRadius { get; set; } = 10;

        private Color _defaultBackColor = Color.FromArgb(28, 29, 34);
        private Color _selectedBackColor = Color.FromArgb(36, 60, 104);

        private bool _isSelected = false;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                Invalidate();
            }
        }

        public Color SelectedBackColor
        {
            get => _selectedBackColor;
            set { _selectedBackColor = value; Invalidate(); }
        }

        public Color DefaultBackColor
        {
            get => _defaultBackColor;
            set { _defaultBackColor = value; Invalidate(); }
        }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = _defaultBackColor;
            ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleLeft;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color fillColor = _isSelected ? _selectedBackColor : _defaultBackColor;

            using (var brush = new SolidBrush(fillColor))
            using (var path = GetRoundedRectPath(ClientRectangle, CornerRadius))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            TextRenderer.DrawText(pevent.Graphics, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            if (Image != null)
            {
                int iconY = (Height - Image.Height) / 2;
                pevent.Graphics.DrawImage(Image, 5, iconY, Image.Width, Image.Height);
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
