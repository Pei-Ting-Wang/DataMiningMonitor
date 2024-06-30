using DataMiningMonitor.Dtos;

namespace DataMiningMonitor.Interfaces
{
    public interface IDailyTreadingReportService
    {
        /// <summary>
        /// 取得買賣日報表
        /// </summary>
        /// <param name="reportDate">日期</param>
        /// <param name="pid">代碼</param>
        /// <returns>代碼報表清單</returns>
        List<DailytReport> GetDailyReport(DateOnly reportDate, string pid);
    }
}
