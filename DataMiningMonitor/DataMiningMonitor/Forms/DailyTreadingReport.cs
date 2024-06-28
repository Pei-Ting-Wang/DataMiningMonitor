using DataMiningMonitor.Dtos;
using DataMiningMonitor.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMiningMonitor.Forms
{
    public partial class DailyTreadingReport : Form
    {
        private readonly IDailyTreadingReportService _dailyTreadingReportService;
        public DailyTreadingReport(IDailyTreadingReportService dailyTreadingReportService)
        {
            InitializeComponent();
            _dailyTreadingReportService = dailyTreadingReportService;
        }

        private void GetDailyReport(object sender, EventArgs e)
        {
            string ReportDate = SelectedTime.Text;
            string Pid = InputPid.Text;
            List<DailytReport> dailyReports = new List<DailytReport>();
            dailyReports = _dailyTreadingReportService.GetDailyReport(ReportDate, Pid);
            if (dailyReports.Count != 0)
            { 
                // Create a new DataGridView
                DataGridView dataGridView = new DataGridView();

                // Set the data source of the DataGridView to the dailyReports list
                dataGridView.DataSource = dailyReports;

                // Add the DataGridView to the form
                Controls.Add(dataGridView);
            }
            
        }
    }
}
