using DataMiningMonitor.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace DataMiningMonitor
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public MainForm(IServiceProvider serviceProvider)
        {    
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void unrealizedProfitAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnrealizedPnLForm unrealizedPnLForm = new UnrealizedPnLForm();
            unrealizedPnLForm.Show();
        }

        /// <summary>
        /// 買賣日報表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tradingDailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyTreadingReport dailyTreadingReport = _serviceProvider.GetRequiredService<DailyTreadingReport>();
            dailyTreadingReport.Show();
        }
    }
}
