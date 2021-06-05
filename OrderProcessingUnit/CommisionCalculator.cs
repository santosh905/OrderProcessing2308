using OrderProcessingUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit
{
    public class CommisionCalculator : ICommision
    {
        public double GetCommision()
        {
            return 10.0;
        }
    }
}
