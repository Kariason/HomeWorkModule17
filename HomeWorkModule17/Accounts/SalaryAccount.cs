using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkModule17.Calculators;

namespace HomeWorkModule17.Accounts
{
    /// <summary>
    /// Класс зарплатного аккаунта
    /// </summary>
    public class SalaryAccount : Account
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

    }
}
