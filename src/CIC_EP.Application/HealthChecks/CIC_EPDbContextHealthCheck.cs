using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using CIC_EP.EntityFrameworkCore;

namespace CIC_EP.HealthChecks
{
    public class CIC_EPDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public CIC_EPDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("CIC_EPDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("CIC_EPDbContext could not connect to database"));
        }
    }
}
