using OrderProcessingUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit.OrderProcess
{
    public class PhysicalProductProcess : IProcess
    {
        private IList<string> results = null;
        private string name = "PhysicalProduct";

        public PhysicalProductProcess()
        {
            results = new List<string>();
        }
        protected virtual void OnGenerateCommision(EventArgs e)
        {
            EventHandler handler = GenerateCommision;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        IList<string> IProcess.process()
        {
            Console.WriteLine("generate a packing slip for shipping.");
            results.Add(ProcessResult.physical_Product_result);
            OnGenerateCommision(EventArgs.Empty);
            return results;
        }

        public event EventHandler GenerateCommision;
    }
}
