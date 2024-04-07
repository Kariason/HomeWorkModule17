using HomeWorkModule17.Accounts;
using HomeWorkModule17.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solaracc = new SalaryAccount();
            solaracc.Balance = 100;

            solaracc.Interest = Calculator.InterestCalculation(solaracc);
            Console.WriteLine(solaracc.Interest);

            var regulacc = new RegularAccount();
            regulacc.Balance = 100;
           Calculator.InterestCalculation(regulacc, new RegularAccountInterestCalculatorcs());
            Console.WriteLine(regulacc.Interest);

           
        }
    }
}
