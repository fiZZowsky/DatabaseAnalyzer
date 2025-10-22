using DatabaseAnalyzer.Models;
using DatabaseAnalyzer.Repositories;
using DatabaseAnalyzer.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseAnalyzer
{
    public partial class ComparePage : UserControl
    {
        private readonly IConnectionService _connectionService;
        private List<Connection> _allConnections;

        public ComparePage()
        {
            InitializeComponent();
            
            var dbContext = new DbContext();
            IConnectionRepository repo = new ConnectionRepository(dbContext);
            _connectionService = new ConnectionService(repo);
            
            LoadConnections();
            
            cmbDb1.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            cmbDb2.SelectedIndexChanged += Cmb_SelectedIndexChanged;
        }
        
        private void LoadConnections()
        {
            _allConnections = _connectionService.GetConnections();
            
            cmbDb1.DisplayMember = "Name";
            cmbDb2.DisplayMember = "Name";
            
            cmbDb1.DataSource = new List<Connection>(_allConnections);
            cmbDb2.DataSource = new List<Connection>(_allConnections);
            
            cmbDb1.SelectedIndex = -1;
            cmbDb2.SelectedIndex = -1;
        }
        
        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxDataSources();
        }

        private void UpdateComboBoxDataSources()
        {
            var selected1 = cmbDb1.SelectedItem as Connection;
            var selected2 = cmbDb2.SelectedItem as Connection;
            
            cmbDb1.SelectedIndexChanged -= Cmb_SelectedIndexChanged;
            cmbDb2.SelectedIndexChanged -= Cmb_SelectedIndexChanged;
            
            var listFor1 = new List<Connection>(_allConnections);
            if (selected2 != null)
            {
                listFor1 = listFor1.Where(c => c.Id != selected2.Id).ToList();
            }
            cmbDb1.DataSource = listFor1;
            cmbDb1.SelectedItem = selected1;
            
            var listFor2 = new List<Connection>(_allConnections);
            if (selected1 != null)
            {
                listFor2 = listFor2.Where(c => c.Id != selected1.Id).ToList();
            }
            cmbDb2.DataSource = listFor2;
            cmbDb2.SelectedItem = selected2;
            
            cmbDb1.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            cmbDb2.SelectedIndexChanged += Cmb_SelectedIndexChanged;
        }
    }
}