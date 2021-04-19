using GastonCardenas.Mas.Test.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GastonCardenas.Mas.Test.Core.Infrastructure
{
    public static class ExtMethods
    {
        /// <summary>
        /// Metodo que convierte un json en una lista del Empleado
        /// </summary>
        /// <param name="jsonString">Json de Empleados</param>
        /// <returns></returns>
        public static List<Employee> ToEmployeeList(this string jsonString)
        {
            return JsonConvert.DeserializeObject<List<Employee>>(jsonString);
        }
    }
}
