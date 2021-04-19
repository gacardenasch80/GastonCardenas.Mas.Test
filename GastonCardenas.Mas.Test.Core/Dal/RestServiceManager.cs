using GastonCardenas.Mas.Test.Core.Infrastructure;
using GastonCardenas.Mas.Test.Core.Models;
using RestSharp;
using System.Collections.Generic;

namespace GastonCardenas.Mas.Test.Core.Dal
{
    public static class RestServiceManager
    {
        /// <summary>
        /// Metodo que obtiene los empleados a partir del API Externo
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static List<Employee> GetEmployees(RestEndPointModel model)
        {
            var client = new RestClient(model.BaseUrl);

            var request = new RestRequest(model.EmployeeResName, Method.GET);

            var response = client.Execute(request);

            return response.Content.ToEmployeeList();
        }
    }
}
