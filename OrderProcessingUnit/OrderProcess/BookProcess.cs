using OrderProcessingUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit.Orders
{
    public class BookProcess : IProcess
    {
        IList<string> results = null;
        private string name = "Book";

        public BookProcess()
        {
            results = new List<string>();
        }
        protected virtual void OnGenerateCommision(BookProcess bookProcess, EventArgs e)
        {
            EventHandler handler = GenerateCommision;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        IList<string> IProcess.process()
        {
            Console.WriteLine("Create A Duplicate Packing Slip For The Royalty Department");
            OnGenerateCommision(this,EventArgs.Empty);
            results.Add(ProcessResult.book_result);
            return results;
        }

        public event EventHandler GenerateCommision;
    }
}
