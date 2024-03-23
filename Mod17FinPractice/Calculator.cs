using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod17FinPractice
{
    public class Calculator
    {
        public void CalcType(Account account, ICalculator calculator)
        {
            calculator.CalculateInterest(account);
        }
    }
}
