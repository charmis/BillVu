using BillVu.WebApi.Controllers;
using BillVu.WebApi.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BillVu.WebApi.Test
{
    public class BillScenarios : IClassFixture<DbContextFixture>
    {
        private DbContextFixture _contextFixture = null;

        public BillScenarios(DbContextFixture fixture)
        {
            _contextFixture = fixture;
        }

        [Fact]
        public void Get_All_Bills_Should_Return_Bills()
        {
            BillsController billsCtrl = new BillsController(_contextFixture.DbContext);
            IEnumerable<Bill> bills = billsCtrl.GetBills();
            
            bills.Should().NotBeNull();
        }

        [Fact]
        public void Get_With_Given_Id_Should_Return_Bill()
        {
            BillsController billsCtrl = new BillsController(_contextFixture.DbContext);
            var firstBill = billsCtrl.GetBills().First();
            var okObjectResult = billsCtrl.GetBill(firstBill.Id.ToString()) as OkObjectResult;

            okObjectResult.Value.Should().NotBeNull();
        }

        [Fact]
        public void Get_With_Saved_Id_Should_Return_OkResult()
        {
            BillsController billsCtrl = new BillsController(_contextFixture.DbContext);
            var firstBill = billsCtrl.GetBills().First();
            var okObjectResult = billsCtrl.GetBill(firstBill.Id.ToString()) as OkObjectResult;

            okObjectResult.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public void Get_With_Random_Id_Should_Return_NotFoundResult()
        {
            BillsController billsCtrl = new BillsController(_contextFixture.DbContext);
            string randomGuid = Guid.NewGuid().ToString();
            var result = billsCtrl.GetBill(randomGuid);

            result.Should().BeOfType<NotFoundResult>();
        }

        [Fact]
        public void Get_With_Invalid_Id_Should_Return_Exception()
        {
            BillsController billsCtrl = new BillsController(_contextFixture.DbContext);            
            Action result = () => billsCtrl.GetBill("32423-234324");
            result.Should().ThrowExactly<ArgumentException>();
        }
    }
}
