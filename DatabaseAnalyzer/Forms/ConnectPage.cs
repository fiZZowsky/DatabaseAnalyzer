using System.Windows.Forms;

namespace DatabaseAnalyzer.Forms
{
    public partial class ConnectPage : UserControl
    {
        private int lastSelectedIndex = -1;

        public ConnectPage()
        {
            InitializeComponent();

            connectionsSplitContainer.Panel2Collapsed = true;
            lastSelectedIndex = -1;
            
            detailsPanel.Paint += DetailsPanel_Paint;
            connectionsCheckedListBox.MouseDown += ConnectionsCheckedListBox_MouseDown;
            connectionsCheckedListBox.SelectedIndexChanged += ConnectionsCheckedListBox_SelectedIndexChanged;

            customControlsPanel.AddClicked += (s, e) => AddConnection();
            customControlsPanel.EditClicked += (s, e) => EditConnection();
            customControlsPanel.DeleteClicked += (s, e) => DeleteConnection();
            customControlsPanel.RefreshClicked += (s, e) => RefreshConnections();
        }

        private void DetailsPanel_Paint(object? sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.DarkSlateGray, 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, detailsPanel.Width - 1, detailsPanel.Height - 1);
            }
        }

        private void ConnectionsCheckedListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int idx = connectionsCheckedListBox.SelectedIndex;
            if (idx == -1)
            {
                lastSelectedIndex = -1;
                connectionsSplitContainer.Panel2Collapsed = true;
                ClearDetailFields();
            }
            else
            {
                lastSelectedIndex = idx;
                connectionsSplitContainer.Panel2Collapsed = false;
                LoadDetailsFor(idx);
            }

            SetButtonsAvailability();
        }

        private void LoadDetailsFor(int index)
        {
            conNameTextBox.Text = "test";
            hostnameTextBox.Text = "test";
            portTextBox.Text = "test";
            sidTextBox.Text = "test";
        }

        private void ClearDetailFields()
        {
            conNameTextBox.Text = string.Empty;
            hostnameTextBox.Text = string.Empty;
            portTextBox.Text = string.Empty;
            sidTextBox.Text = string.Empty;
        }

        private void ConnectionsCheckedListBox_MouseDown(object? sender, MouseEventArgs e)
        {
            int idx = connectionsCheckedListBox.IndexFromPoint(e.Location);
            if (idx < 0)
            {
                if (connectionsCheckedListBox.SelectedIndex != -1)
                    connectionsCheckedListBox.SelectedIndex = -1;
                return;
            }

            if (idx == lastSelectedIndex)
            {
                connectionsCheckedListBox.SelectedIndex = -1;
                lastSelectedIndex = -1;
                return;
            }
            
            connectionsCheckedListBox.SelectedIndex = idx;
        }

        private void SetButtonsAvailability()
        {
            bool isSelected = connectionsCheckedListBox.SelectedIndex != -1;

            customControlsPanel.EnableEditButton = isSelected;
            customControlsPanel.EnableDeleteButton = isSelected;
        }

        private void AddConnection()
        {
        }

        private void EditConnection()
        {
        }

        private void DeleteConnection()
        {
        }

        private void RefreshConnections()
        {
        }
    }
}
