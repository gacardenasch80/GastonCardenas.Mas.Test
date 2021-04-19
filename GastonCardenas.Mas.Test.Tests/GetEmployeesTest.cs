using GastonCardenas.Mas.Test.Core.Bl;
using GastonCardenas.Mas.Test.Core.Models;
using System;
using Xunit;

namespace GastonCardenas.Mas.Test.Tests
{
    public class GetEmployeesTest
    {
        readonly string BaseUrl = "http://masglobaltestapi.azurewebsites.net/api/";
        readonly string EmployeeRes = "Employees";

        [Fact]
        public void WhenEmployeeIdDontExistsTheReturnedListMustBeEmpty()
        {
            var restInfo = new RestEndPointModel(BaseUrl, EmployeeRes);

            var rnd = new Random(888);
            var id = rnd.Next(888, 99999);

            var employee = EmployeeBl.GetEmployees(restInfo, id);

            Assert.Empty(employee);
        }
        
        [Fact]
        public void WhenEmployeeIdExistsTheReturnedList()
        {
            var restInfo = new RestEndPointModel(BaseUrl, EmployeeRes);
            var id = 1;
            var employee = EmployeeBl.GetEmployees(restInfo, id);
            Assert.Single(employee);
        }
    }
}
