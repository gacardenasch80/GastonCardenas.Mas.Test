using System;
using System.Collections.Generic;
using System.Text;

namespace GastonCardenas.Mas.Test.Core.Models
{
    /// <summary>
    /// Clase que me define las variables del API
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Url del Endpoint del API
        /// </summary>
        public string MasApiBaseUrl { get; set; }
        /// <summary>
        /// Recurso o clarse que se esta llamando
        /// </summary>
        public string MasApiEmployeesResource { get; set; }
    }
}
