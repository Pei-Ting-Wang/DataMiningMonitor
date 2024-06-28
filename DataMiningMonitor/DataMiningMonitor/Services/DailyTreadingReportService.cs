using DataMiningMonitor.Dtos;
using DataMiningMonitor.Interfaces;
using DataMiningMonitor.Models;
using Microsoft.EntityFrameworkCore;

namespace DataMiningMonitor.Services
{
    public class DailyTreadingReportService : IDailyTreadingReportService
    {
        private readonly BasicInfoContext _dbcontext;
        public DailyTreadingReportService(BasicInfoContext context)
        {
            _dbcontext = context;
        }
        public List<DailytReport> GetDailyReport(string reportDate, string pid)
        {
            var dailyLimitPriceInfo = _dbcontext.DailyLimitPriceInfos.AsNoTracking().FirstOrDefault(w => w.Pid == pid);

            List<DailytReport> dailytReports = new List<DailytReport>();

            if (dailyLimitPriceInfo != null)
            {
                bool isWarrant = dailyLimitPriceInfo.IsWarrant;

                if (isWarrant)
                {
                    dailytReports = _dbcontext.TwbrokerStockDeals.AsNoTracking().Where(w =>  w.Pid == pid).Select(s => new DailytReport
                    {
                        Date = s.Date,
                        Pid = s.Pid,
                        BrokerId = s.BrokerId,
                        Price = s.Price,
                        Blotsum = s.Blotsum,
                        Slotsum = s.Slotsum
                    }).Take(5).ToList();
                }
                else
                {
                    var test = _dbcontext.TwbrokerDeals.AsNoTracking().ToList().Take(5);
                    dailytReports = _dbcontext.TwbrokerDeals.AsNoTracking().Where(w =>w.Pid == pid).Select(s => new DailytReport
                    {
                        Date = s.Date,
                        Pid = s.Pid,
                        BrokerId = s.BrokerId,
                        Price = s.Price,
                        Blotsum = s.Blotsum,
                        Slotsum = s.Slotsum
                    }).Take(5).ToList();
                };
            }
            return dailytReports;
        }


    }
}
