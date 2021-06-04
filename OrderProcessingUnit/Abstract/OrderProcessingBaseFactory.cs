using OrderProcessingUnit.Common;
using OrderProcessingUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit.Abstract
{
    /// <summary>
    /// Abtract Class
    /// </summary>
    public abstract class OrderProcessingBaseFactory
    {
        public abstract IProcess CreateProcess(ProductType productType);
    }
}
