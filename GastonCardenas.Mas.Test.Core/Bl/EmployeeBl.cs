using GastonCardenas.Mas.Test.Core.Dal;
using GastonCardenas.Mas.Test.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GastonCardenas.Mas.Test.Core.Bl
{
    public static class EmployeeBl
    {
        /// <summary>
        /// Funcion que lista los Empleados consumiendo el API
        /// </summary>
        /// <param name="model">Modelo que se quiere devolver</param>
        /// <param name="employeeId">Id del Empleado</param>
        /// <returns></returns>
        public static List<Employee> GetEmployees(RestEndPointModel model, int employeeId = 0)
        {
            var employees = RestServiceManager.GetEmployees(model);

            if (employeeId > 0)
                FilterEmployee(ref employees, employeeId);

            CalculateAnnualSalary(ref employees);

            return employees;
        }
        /// <summary>
        /// Funcion que filtra los empleados por Id
        /// </summary>
        /// <param name="employees">Lista de Empleados</param>
        /// <param name="employeeId">Id del empleado</param>
        private static void FilterEmployee(ref List<Employee> employees, int employeeId)
        {
            var employee = employees.FirstOrDefault(x => x.Id.Equals(employeeId));

            employees = (employee != null) ? new List<Employee> { employee } : new List<Employee>();
        }
        /// <summary>
        /// Funcion que calcula el Salario Anual de los empreados
        /// </summary>
        /// <param name="employees"></param>
        private static void CalculateAnnualSalary(ref List<Employee> employees)
        {
            employees.ForEach(x => x.CalculateAnnualSalary());
        }
    }
}
