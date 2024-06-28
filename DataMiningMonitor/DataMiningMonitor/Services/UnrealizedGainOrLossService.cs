using DataMiningMonitor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMiningMonitor.Services
{
    public class UnrealizedGainOrLossService
    {
        private readonly BasicInfoContext _dbcontext;
        public UnrealizedGainOrLossService(BasicInfoContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
