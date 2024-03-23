namespace Mod17FinPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account regularAccount = new Account { Type = "Обычный", Balance = 70000 };
            Account salaryAccount = new Account { Type = "Зарплатный", Balance = 10000 };

            Calculator calculator = new Calculator();

            
            ICalculator ordinaryCalculator = new OrdinaryCalculator();
            ICalculator salaryCalculator = new SalaryCalculator();

            
            calculator.CalcType(regularAccount, ordinaryCalculator);
            calculator.CalcType(salaryAccount, salaryCalculator);

            
            Console.WriteLine($"Regular account interest: {regularAccount.Interest}");
            Console.WriteLine($"Salary account interest: {salaryAccount.Interest}");
        }
    }
}
