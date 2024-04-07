using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkModule17.Accounts;
using HomeWorkModule17.Calculators;

namespace HomeWorkModule17.Calculators
{
    public static class Calculator
    {
        public static void InterestCalculation(SalaryAccount account)
        {
          
        }

        public static void InterestCalculation(RegularAccount account, RegularAccountInterestCalculatorcs calculator)
        {
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;
            else
                account.Interest -= account.Balance * 0.3;
        }
    }
}
