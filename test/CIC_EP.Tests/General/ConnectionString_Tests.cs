using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace CIC_EP.Tests.General
{
    // ReSharper disable once InconsistentNaming
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=CIC_EP; Trusted_Connection=True;");
            csb["Database"].ShouldBe("CIC_EP");
        }
    }
}
