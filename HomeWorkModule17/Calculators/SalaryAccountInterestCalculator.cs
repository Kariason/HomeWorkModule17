using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkModule17.Accounts;

namespace HomeWorkModule17.Calculators
{
    public class SalaryAccountInterestCalculator : ICalculatorInterest
    {
        public static void InterestCalculation(Account account)
        {
            if (account is SalaryAccount)
                 account.Interest = account.Balance * 0.5;
            else
            {
                Console.WriteLine("Неверный тип аккаунта");
                account.Interest = 0;
            }

        }
    }
}
