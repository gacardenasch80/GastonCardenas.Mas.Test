namespace GastonCardenas.Mas.Test.Core.Models
{
    public class HourlySalaryEmployee : Employee
    {
        /// <summary>
        /// funcion que calcula el salario Anual del Empleado Dependiendo de Valor de la Hora
        /// </summary>
        public override void CalculateAnnualSalary()
        {
            AnnualSalary = (120 * HourlySalary) * 12;
        }
    }
}
