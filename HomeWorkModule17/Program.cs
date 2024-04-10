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
            var salaryAcc = new SalaryAccount { Balance = 200 };
            salaryAcc.Interest = SalaryAccountInterestCalculator.InterestCalculation(salaryAcc);
            Console.WriteLine("Процентная ставка зарплатного аккаунта - " + salaryAcc.Interest + "%");


            var regulAcc = new RegularAccount { Balance = 1001 };
            regulAcc.Interest = RegularAccountInterestCalculatorcs.InterestCalculation(regulAcc);
            Console.WriteLine("Процентная ставка обычного аккаунта - " + regulAcc.Interest + "%");

        }
    }
}
