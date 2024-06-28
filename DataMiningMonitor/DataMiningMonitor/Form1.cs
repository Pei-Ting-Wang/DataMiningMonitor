using DataMiningMonitor.Forms;
using DataMiningMonitor.Interfaces;
using DataMiningMonitor.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DataMiningMonitor
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Form1(IServiceProvider serviceProvider)
        {    
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void unrealizedProfitAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnrealizedPnLForm unrealizedPnLForm = new UnrealizedPnLForm();
            unrealizedPnLForm.Show();
        }

        private void tradingDailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyTreadingReport dailyTreadingReport = _serviceProvider.GetRequiredService<DailyTreadingReport>();
            dailyTreadingReport.Show();
        }
    }
}
