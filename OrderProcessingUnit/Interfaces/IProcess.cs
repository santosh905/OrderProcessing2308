using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit.Interfaces
{
    public interface IProcess
    {
        IList<string> process();
    }
}
