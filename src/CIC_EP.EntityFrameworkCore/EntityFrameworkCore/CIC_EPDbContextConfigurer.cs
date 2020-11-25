using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CIC_EP.EntityFrameworkCore
{
    public static class CIC_EPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CIC_EPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CIC_EPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}