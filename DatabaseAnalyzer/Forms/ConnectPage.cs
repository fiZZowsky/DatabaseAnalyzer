using System.Windows.Forms;
using DatabaseAnalyzer.Models;
using DatabaseAnalyzer.Services;
using DatabaseAnalyzer.Repositories;

namespace DatabaseAnalyzer.Forms
{
    public partial class ConnectPage : UserControl
    {
        private readonly IConnectionService _connectionService;
        private List<Connection> _connections;
        private int lastSelectedIndex = -1;

        public ConnectPage()
        {
            InitializeComponent();

            var dbContext = new DbContext();
            IConnectionRepository connectionRepository = new ConnectionRepository(dbContext);
            _connectionService = new ConnectionService(connectionRepository);

            LoadConnections();

            connectionsSplitContainer.Panel2Collapsed = true;
            lastSelectedIndex = -1;

            detailsPanel.Paint += DetailsPanel_Paint;
            connectionsCheckedListBox.MouseDown += ConnectionsCheckedListBox_MouseDown;
            connectionsCheckedListBox.SelectedIndexChanged += ConnectionsCheckedListBox_SelectedIndexChanged;
            connectionsCheckedListBox.ItemCheck += ConnectionsCheckedListBox_ItemCheck;

            customControlsPanel.AddClicked += (s, e) => AddConnection();
            customControlsPanel.EditClicked += (s, e) => EditConnection();
            customControlsPanel.DeleteClicked += (s, e) => DeleteConnection();

            SetButtonsAvailability();
        }

        private void LoadConnections()
        {
            _connections = _connectionService.GetConnections();

            connectionsCheckedListBox.Items.Clear();
            foreach (var conn in _connections)
            {
                connectionsCheckedListBox.Items.Add(conn.Name, false);
            }
        }

        private void DetailsPanel_Paint(object? sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.DarkSlateGray, 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, detailsPanel.Width - 1, detailsPanel.Height - 1);
            }
        }

        private void ConnectionsCheckedListBox_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(SetButtonsAvailability));
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
        }

        private void LoadDetailsFor(int index)
        {
            if (index < 0 || index >= _connections.Count)
                return;

            var conn = _connections[index];

            conNameTextBox.Text = conn.Name;
            hostnameTextBox.Text = conn.Hostname;
            portTextBox.Text = conn.Port.ToString();

            if (string.IsNullOrEmpty(conn.SID))
            {
                sidServiceNameLabel.Text = "Service name";
                sidServiceNameTextBox.Text = conn.ServiceName;
            }
            else
            {
                sidServiceNameLabel.Text = "SID";
                sidServiceNameTextBox.Text = conn.SID; ;
            }
        }

        private void ClearDetailFields()
        {
            conNameTextBox.Text = string.Empty;
            hostnameTextBox.Text = string.Empty;
            portTextBox.Text = string.Empty;
            sidServiceNameTextBox.Text = string.Empty;
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
            
            Rectangle itemRect = connectionsCheckedListBox.GetItemRectangle(idx);
            
            if (e.X < itemRect.Left + 20)
            {
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

        private void AddConnection()
        {
            var addModal = new AddConnectionModal();
            if (addModal.ShowDialog() == DialogResult.OK)
            {
                var connection = addModal._connection;

                _connectionService.SaveConnection(connection);

                _connections.Add(connection);
                connectionsCheckedListBox.Items.Add(connection.Name, false);
            }
        }

        private void EditConnection()
        {
            if (connectionsCheckedListBox.CheckedItems.Count != 1)
                return;

            int idx = connectionsCheckedListBox.CheckedIndices[0];
            var connectionToEdit = _connections[idx];
            var editModal = new AddConnectionModal(connectionToEdit);

            if (editModal.ShowDialog() == DialogResult.OK)
            {
                _connections[idx] = editModal._connection;

                _connectionService.SaveConnection(_connections[idx]);

                connectionsCheckedListBox.Items[idx] = editModal._connection.Name;
            }
        }

        private void DeleteConnection()
        {
            int checkedCount = connectionsCheckedListBox.CheckedItems.Count;
            if (checkedCount == 0)
                return;

            var result = MessageBox.Show(
                $"Are you sure you want to delete {checkedCount} selected connection(s)?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var indicesToRemove = connectionsCheckedListBox.CheckedIndices.Cast<int>().OrderByDescending(i => i).ToList();

                foreach (var idx in indicesToRemove)
                {
                    int connectionId = _connections[idx].Id;

                    _connectionService.DeleteConnection(connectionId);

                    _connections.RemoveAt(idx);
                    connectionsCheckedListBox.Items.RemoveAt(idx);
                }

                connectionsCheckedListBox.ClearSelected();
                SetButtonsAvailability();
            }
        }

        private void SetButtonsAvailability()
        {
            int checkedCount = connectionsCheckedListBox.CheckedItems.Count;

            customControlsPanel.EnableEditButton = (checkedCount == 1);
            customControlsPanel.EnableDeleteButton = (checkedCount > 0);
        }
    }
}