using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using HomeWorkModule17.Accounts;

namespace HomeWorkModule17.Calculators
{
    public class RegularAccountInterestCalculatorcs : CalculatorInterest
    {
        /// <summary>
        /// Класс для работы с обычным аккаунтом
        /// </summary>
        public static double InterestCalculation(RegularAccount account)
        {
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                return account.Interest -= account.Balance * 0.2;
            else
                return account.Interest -= account.Balance * 0.3;

        }
    }
}
