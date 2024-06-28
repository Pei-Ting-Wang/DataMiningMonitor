using DataMiningMonitor.Dtos;

namespace DataMiningMonitor.Interfaces
{
    public interface IDailyTreadingReportService
    {
        List<DailytReport> GetDailyReport(string reportDate, string pid);
    }
}
