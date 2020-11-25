using CIC_EP.EntityFrameworkCore;

namespace CIC_EP.Test.Base.TestData
{
    public class TestDataBuilder
    {
        private readonly CIC_EPDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(CIC_EPDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();
            new TestEditionsBuilder(_context).Create();

            _context.SaveChanges();
        }
    }
}
