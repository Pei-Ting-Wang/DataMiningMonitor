using DataMiningMonitor.Interfaces;
using DataMiningMonitor.Models;

namespace DataMiningMonitor.Services
{
    public  class TestService: ITestService
    {
        private readonly BasicInfoContext _dbcontext;

        public TestService(BasicInfoContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void Test()
        {
            var data = _dbcontext.DailyHitRates.ToList().FirstOrDefault();
        }
    }
}
