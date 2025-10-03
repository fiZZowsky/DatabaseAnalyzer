using System.ComponentModel;

namespace DatabaseAnalyzer.Components
{
    public partial class CustomControlsPanel : UserControl
    {
        public event EventHandler? AddClicked;
        public event EventHandler? EditClicked;
        public event EventHandler? DeleteClicked;
        public event EventHandler? RefreshClicked;

        public CustomControlsPanel()
        {
            InitializeComponent();

            addButton.Click += (s, e) => AddClicked?.Invoke(s, e);
            editButton.Click += (s, e) => EditClicked?.Invoke(s, e);
            deleteButton.Click += (s, e) => DeleteClicked?.Invoke(s, e);
            refreshButton.Click += (s, e) => RefreshClicked?.Invoke(s, e);
        }

        [Category("Panel Controls")]
        public bool ShowAddButton
        {
            get => addButton.Visible;
            set => addButton.Visible = value;
        }

        [Category("Panel Controls")]
        public bool ShowEditButton
        {
            get => editButton.Visible;
            set => editButton.Visible = value;
        }

        [Category("Panel Controls")]
        public bool ShowDeleteButton
        {
            get => deleteButton.Visible;
            set => deleteButton.Visible = value;
        }

        [Category("Panel Controls")]
        public bool ShowRefreshButton
        {
            get => refreshButton.Visible;
            set => refreshButton.Visible = value;
        }

        [Category("Panel Controls")]
        public bool EnableAddButton
        {
            get => addButton.Enabled;
            set => addButton.Enabled = value;
        }

        [Category("Panel Controls")]
        public bool EnableEditButton
        {
            get => editButton.Enabled;
            set => editButton.Enabled = value;
        }

        [Category("Panel Controls")]
        public bool EnableDeleteButton
        {
            get => deleteButton.Enabled;
            set => deleteButton.Enabled = value;
        }

        [Category("Panel Controls")]
        public bool EnableRefreshButton
        {
            get => refreshButton.Enabled;
            set => refreshButton.Enabled = value;
        }
    }
}
