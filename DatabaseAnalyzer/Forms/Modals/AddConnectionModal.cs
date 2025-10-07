using DatabaseAnalyzer.Models;

namespace DatabaseAnalyzer.Forms;

public partial class AddConnectionModal : Form
{
    public Connection _connection = new Connection();

    public AddConnectionModal()
    {
        InitializeComponent();

        InitializeEvents();
    }

    public AddConnectionModal(Connection connection)
    {
        InitializeComponent();

        SetupControlsData(connection);
        InitializeEvents();
    }

    private void SetupControlsData(Connection connection)
    {
        _connection = connection;

        conNameTextBox.Text = connection.Name;
        hostnameTextBox.Text = connection.Hostname;
        portTextBox.Text = connection.Port.ToString();
        usernameTextBox.Text = connection.Username;
        passwordTextBox.Text = connection.Password;
        sidTextBox.Text = connection.SID;
        serviceNameTextBox.Text = connection.ServiceName;

        if (!string.IsNullOrEmpty(connection.SID))
            sidRadioButton.Checked = true;
        else if (!string.IsNullOrEmpty(connection.ServiceName))
            serviceNameRadioButton.Checked = true;

        SetRadioButtonsState();
    }

    private void InitializeEvents()
    {
        portTextBox.KeyPress += PortTextBox_KeyPress;
        conNameTextBox.TextChanged += ConNameTextBox_TextChanged;
        hostnameTextBox.TextChanged += HostnameTextBox_TextChanged;
        portTextBox.TextChanged += PortTextBox_TextChanged;
        usernameTextBox.TextChanged += UsernameTextBox_TextChanged;
        passwordTextBox.TextChanged += PasswordTextBox_TextChanged;
        sidTextBox.TextChanged += SIDTextBox_TextChanged;
        serviceNameTextBox.TextChanged += ServiceNameTextBox_TextChanged;

        sidRadioButton.CheckedChanged += SIDRadioButton_CheckedChanged;
        serviceNameRadioButton.CheckedChanged += serviceNameRadioButton_ChackedChanged;

        customActionBar.AcceptClicked += (s, e) => Accept();
        customActionBar.CancelClicked += (s, e) => Cancel();
    }

    private void PortTextBox_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void serviceNameRadioButton_ChackedChanged(object? sender, EventArgs e)
    {
        SetRadioButtonsState();
    }

    private void SIDRadioButton_CheckedChanged(object? sender, EventArgs e)
    {
        SetRadioButtonsState();
    }

    private void SetRadioButtonsState()
    {
        sidRadioButton.CheckedChanged -= SIDRadioButton_CheckedChanged;
        serviceNameRadioButton.CheckedChanged -= serviceNameRadioButton_ChackedChanged;

        if (sidRadioButton.Checked)
        {
            sidTextBox.Enabled = true;
            serviceNameTextBox.Enabled = false;
            serviceNameTextBox.Text = string.Empty;
            
            if (serviceNameRadioButton.Checked)
                serviceNameRadioButton.Checked = false;

            sidPanel.BackColor = Color.DarkSlateGray;
            serviceNamePanel.BackColor = Color.FromArgb(45, 46, 55);
        }
        else if (serviceNameRadioButton.Checked)
        {
            sidTextBox.Enabled = false;
            sidTextBox.Text = string.Empty;
            serviceNameTextBox.Enabled = true;

            if (sidRadioButton.Checked)
                sidRadioButton.Checked = false;

            sidPanel.BackColor = Color.FromArgb(45, 46, 55);
            serviceNamePanel.BackColor = Color.DarkSlateGray;
        }

        sidRadioButton.CheckedChanged += SIDRadioButton_CheckedChanged;
        serviceNameRadioButton.CheckedChanged += serviceNameRadioButton_ChackedChanged;
    }

    private void ServiceNameTextBox_TextChanged(object? sender, EventArgs e)
    {
        _connection.ServiceName = serviceNameTextBox.Text;
    }

    private void SIDTextBox_TextChanged(object? sender, EventArgs e)
    {
        _connection.SID = sidTextBox.Text;
    }

    private void PasswordTextBox_TextChanged(object? sender, EventArgs e)
    {
        _connection.Password = passwordTextBox.Text;
    }

    private void UsernameTextBox_TextChanged(object? sender, EventArgs e)
    {
        _connection.Username = usernameTextBox.Text;
    }

    private void PortTextBox_TextChanged(object? sender, EventArgs e)
    {
        var port = portTextBox.Text;
        _connection.Port = Convert.ToInt32(string.IsNullOrEmpty(port) ? "0" : port);
    }

    private void HostnameTextBox_TextChanged(object? sender, EventArgs e)
    {
        _connection.Hostname = hostnameTextBox.Text;
    }

    private void ConNameTextBox_TextChanged(object? sender, EventArgs e)
    {
        _connection.Name = conNameTextBox.Text;
    }

    private bool IsModelValid()
    {
        bool isValid = true;
        if (string.IsNullOrWhiteSpace(_connection.Name))
        {
            conNamePanel.BackColor = Color.Crimson;
            isValid = false;
        }
        else
            conNamePanel.BackColor = Color.DarkSlateGray;

        if (string.IsNullOrWhiteSpace(_connection.Hostname))
        {
            hostnamePanel.BackColor = Color.Crimson;
            isValid = false;
        }
        else
            hostnamePanel.BackColor = Color.DarkSlateGray;

        if (_connection.Port == null || _connection.Port <= 0)
        {
            portPanel.BackColor = Color.Crimson;
            isValid = false;
        }
        else
            portPanel.BackColor = Color.DarkSlateGray;

        if (string.IsNullOrWhiteSpace(_connection.Username))
        {
            usernamePanel.BackColor = Color.Crimson;
            isValid = false;
        }
        else
            usernamePanel.BackColor = Color.DarkSlateGray;

        if (string.IsNullOrWhiteSpace(_connection.Password))
        {
            passwordPanel.BackColor = Color.Crimson;
            isValid = false;
        }
        else
            passwordPanel.BackColor = Color.DarkSlateGray;

        if (sidRadioButton.Checked)
        {
            if (string.IsNullOrWhiteSpace(_connection.SID))
            {
                sidPanel.BackColor = Color.Crimson;
                isValid = false;
            }
            else
                sidPanel.BackColor = Color.DarkSlateGray;

            serviceNamePanel.BackColor = Color.FromArgb(45, 46, 55);
        }
        else if (serviceNameRadioButton.Checked)
        {
            if (string.IsNullOrWhiteSpace(_connection.ServiceName))
            {
                serviceNamePanel.BackColor = Color.Crimson;
                isValid = false;
            }
            else
                serviceNamePanel.BackColor = Color.DarkSlateGray;

            sidPanel.BackColor = Color.FromArgb(45, 46, 55);
        }
        else
        {
            sidPanel.BackColor = Color.DarkSlateGray;
            serviceNamePanel.BackColor = Color.DarkSlateGray;
        }

        return isValid;
    }

    private void Accept()
    {
        if (!IsModelValid())
        {
            MessageBox.Show("Please fill in all required fields.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void Cancel()
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}