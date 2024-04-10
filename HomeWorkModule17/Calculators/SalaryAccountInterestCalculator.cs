using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkModule17.Accounts;

namespace HomeWorkModule17.Calculators
{
    /// <summary>
    /// Класс для работы с зарплатным аккаунтом
    /// </summary>
    public class SalaryAccountInterestCalculator : CalculatorInterest
    {
        public static double InterestCalculation(SalaryAccount account)
        {
            return account.Interest = account.Balance * 0.5;
        }
    }
}
