using BillVu.WebApi.Infrastructure;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace BillVu.WebApi.Test
{
    public class DbContextFixture
    {        
        public BillVuDbContext DbContext { get; private set;}

        public DbContextFixture()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<BillVuDbContext>()
                .UseSqlite(connection)
                .Options;

            DbContext = new BillVuDbContext(options);

            DbContext.Database.EnsureCreated();
        }
    }
}
