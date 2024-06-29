using DataMiningMonitor.Dtos;

namespace DataMiningMonitor.Interfaces
{
    public interface IDailyTreadingReportService
    {
        List<DailytReport> GetDailyReport(DateOnly reportDate, string pid);
    }
}
