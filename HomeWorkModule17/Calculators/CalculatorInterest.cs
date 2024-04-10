using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule17.Calculators
{
    /// <summary>
    /// Абстрактный класс, от которого наследуются конкретные реализации калькуляторов под каждый тип аккаунта
    /// </summary>
    public abstract class CalculatorInterest
    {
        public static double InterestCalculation(double balance) { return 0; }
    }
}
