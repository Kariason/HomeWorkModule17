using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkModule17.Calculators;

namespace HomeWorkModule17
{
    public abstract class Account
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void InterestCalculation(ICalculatorInterest calculator) { }

    }
}
