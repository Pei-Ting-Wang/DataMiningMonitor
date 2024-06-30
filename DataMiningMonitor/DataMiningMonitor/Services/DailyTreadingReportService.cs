using DataMiningMonitor.Dtos;
using DataMiningMonitor.Interfaces;
using DataMiningMonitor.Models;
using Microsoft.EntityFrameworkCore;

namespace DataMiningMonitor.Services
{
    public class DailyTreadingReportService : IDailyTreadingReportService
    {
        /// <summary>
        /// 取得買賣日報表
        /// </summary>
        /// <param name="reportDate">日期</param>
        /// <param name="pid">代碼</param>
        /// <returns>代碼報表清單</returns>
        public List<DailytReport> GetDailyReport(DateOnly reportDate, string pid)
        {
            BasicInfoContext _dbcontext = new BasicInfoContext();   
            var dailyLimitPriceInfo = _dbcontext.DailyLimitPriceInfos.AsNoTracking()
                                        .Where(w => w.Pid == pid).FirstOrDefault();


            List<DailytReport> dailytReports = new List<DailytReport>();

            if (dailyLimitPriceInfo != null)
            {
                bool isWarrant = dailyLimitPriceInfo.IsWarrant;

                if (isWarrant)
                {
                    dailytReports = _dbcontext.TwbrokerDeals.AsNoTracking()
                        .Where(w => w.Date == reportDate && w.Pid == pid)
                        .Select(s => new DailytReport
                        {
                            BrokerId = s.BrokerId,
                            Price = s.Price,
                            Blotsum = s.Blotsum,
                            Slotsum = s.Slotsum
                        }).ToList();
                }
                else
                {
                    dailytReports = _dbcontext.TwbrokerStockDeals.AsNoTracking()
                        .Where(w => w.Date == reportDate && w.Pid == pid)
                        .Select(s => new DailytReport
                        {
                            BrokerId = s.BrokerId,
                            Price = s.Price,
                            Blotsum = s.Blotsum,
                            Slotsum = s.Slotsum
                        }).ToList();
                }
            }
            return dailytReports;
        }


    }
}
