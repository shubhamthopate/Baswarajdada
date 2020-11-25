using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CIC_EP.MultiTenancy.HostDashboard.Dto;

namespace CIC_EP.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}