using BillVu.WebApi.Controllers;
using BillVu.WebApi.Infrastructure;
using BillVu.WebApi.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace BillVu.WebApi.Test
{
    public class BillScenarios
    {
        [Fact]
        public void Get_All_Bills_Should_Return_Bills()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<BillVuDbContext>()
                .UseSqlite(connection)
                .Options;

            var context = new BillVuDbContext(options);
            
            context.Database.EnsureCreated();
            BillsController billsCtrl = new BillsController(context);
            IEnumerable<Bill> bills = billsCtrl.GetBills();
            
            Assert.True(bills != null);
        }
    }
}
