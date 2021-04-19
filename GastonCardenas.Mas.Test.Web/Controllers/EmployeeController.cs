using DataTables.Queryable;
using GastonCardenas.Mas.Test.Core.Bl;
using GastonCardenas.Mas.Test.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Linq;

namespace GastonCardenas.Mas.Test.Web.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly AppSettings _appSettings;

        public EmployeeController(IOptions<AppSettings> settings)
        {
            _appSettings = settings.Value;
        }

        [HttpPost]
        [Route("{id:int?}")]
        [Consumes("application/x-www-form-urlencoded")] //jqueryDatables envía los datos en formato x-www-form-urlencoded
        public ActionResult PostEmployees([FromForm] DataTablesAjaxPostModel model, [FromRoute] int id = 0)
        {
            var restInfo = new RestEndPointModel(_appSettings.MasApiBaseUrl, _appSettings.MasApiEmployeesResource);

            var employees = EmployeeBl.GetEmployees(restInfo, id);

            return Ok(new
            {
                draw = model.Draw,
                recordsTotal = employees.Count(),
                recordsFiltered = employees.Count(),
                data = employees
            });
        }
    }
}
