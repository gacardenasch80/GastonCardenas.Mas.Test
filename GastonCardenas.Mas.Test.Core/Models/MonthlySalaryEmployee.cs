namespace GastonCardenas.Mas.Test.Core.Models
{
    public class MonthlySalaryEmployee : Employee
    {
        /// <summary>
        /// funcion que calcula el salario Anual del Empleado Dependiendo de Valor del Mes
        /// </summary>
        public override void CalculateAnnualSalary()
        {
            AnnualSalary = (MonthlySalary * 12);
        }
    }
}
