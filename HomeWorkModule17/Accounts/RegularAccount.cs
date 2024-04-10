using HomeWorkModule17.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule17.Accounts
{
    /// <summary>
    /// Класс обычного аккаунта
    /// </summary>
    public class RegularAccount : Account
    {
        public double Balance { get; set; }
        public double Interest { get; set; }
    }
}
