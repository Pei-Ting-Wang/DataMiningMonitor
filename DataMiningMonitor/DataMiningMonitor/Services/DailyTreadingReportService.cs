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
        public List<DailytReport> GetDailyReport(DateOnly reportDate, string pid)
        {

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
