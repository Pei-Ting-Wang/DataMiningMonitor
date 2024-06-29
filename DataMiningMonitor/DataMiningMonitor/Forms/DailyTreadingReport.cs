using DataMiningMonitor.Dtos;
using DataMiningMonitor.Interfaces;


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

        private async void GetDailyReport(object sender, EventArgs e)
        {
            try
            {
                status.Text = "查詢中...";
                DateOnly reportDate = DateOnly.FromDateTime(SelectedTime.Value);
                string pid = InputPid.Text;
                List<DailytReport> dailyReports = new List<DailytReport>();
                dailyReports = await Task.Run(() => _dailyTreadingReportService.GetDailyReport(reportDate, pid));
                if (dailyReports.Count != 0)
                {
                    dateResult.Text = reportDate.ToString();
                    pidResult.Text = pid;
                    DailyReportGridView.DataSource = dailyReports;
                    DailyReportGridView.Columns[0].HeaderText = "分點";
                    DailyReportGridView.Columns[1].HeaderText = "價格";
                    DailyReportGridView.Columns[2].HeaderText = "買進股數";
                    DailyReportGridView.Columns[3].HeaderText = "賣出股數";
                }
            }
            catch (Exception ex)
            {
                status.Text = "查詢失敗!!!";
                status.ForeColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                status.Text = "查詢完成!!!";
                status.ForeColor = Color.Blue;
            }
        }
    }
}
