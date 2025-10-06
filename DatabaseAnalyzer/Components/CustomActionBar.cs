namespace DatabaseAnalyzer.Components
{
    public partial class CustomActionBar : UserControl
    {
        public event EventHandler? AcceptClicked;
        public event EventHandler? CancelClicked;

        public CustomActionBar()
        {
            InitializeComponent();

            acceptButton.Click += (s, e) => AcceptClicked?.Invoke(s, e);
            cancelButton.Click += (s, e) => CancelClicked?.Invoke(s, e);
        }
    }
}
