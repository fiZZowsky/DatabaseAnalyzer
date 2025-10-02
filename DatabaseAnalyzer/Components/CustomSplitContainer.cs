namespace DatabaseAnalyzer.Components
{
    public partial class CustomSplitContainer : SplitContainer
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(Color.DarkSlateGray, 1))
            {
                int x = this.SplitterDistance;
                e.Graphics.DrawLine(pen, x, 0, x, this.Height - 30);
            }
        }
    }
}
