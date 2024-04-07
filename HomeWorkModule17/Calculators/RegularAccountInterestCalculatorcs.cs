using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkModule17.Accounts;

namespace HomeWorkModule17.Calculators
{
    public class RegularAccountInterestCalculatorcs : ICalculatorInterest
    {
        public static void InterestCalculation(Account account)
        {
            if (account is RegularAccount)
            {
                account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                   account.Interest -= account.Balance * 0.2;
                else
                  account.Interest -= account.Balance * 0.3;
            }
            else
            {
                Console.WriteLine("Неверный тип аккаунта");
               account.Interest = 0;
            }
        }
    }
}
