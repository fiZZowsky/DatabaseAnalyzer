namespace DatabaseAnalyzer.Components
{
    public partial class SimpleButton : Button
    {
        public SimpleButton()
        {
            InitializeComponent();

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;

            this.Paint += SimpleButton_Paint;
        }

        private void SimpleButton_Paint(object? sender, PaintEventArgs e)
        {
            var btn = (Button)sender;

            if (btn.Enabled)
            {
                btn.BackColor = Color.FromArgb(36, 60, 104);
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.FromArgb(180,120, 130, 150);
                btn.ForeColor = Color.FromArgb(230, 230, 230);
            }
        }
    }
}
