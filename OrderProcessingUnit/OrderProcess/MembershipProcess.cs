using OrderProcessingUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit.OrderProcess
{
    public class MembershipProcess : IProcess
    {
        public void process()
        {
            Console.WriteLine("Activate that membership");
            OnMembershipOrUpgrade(EventArgs.Empty);
        }

        protected virtual void OnMembershipOrUpgrade(EventArgs e)
        {
            EventHandler handler = MembershipOrUpgrade;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        IList<string> IProcess.process()
        {
            throw new NotImplementedException();
        }

        public event EventHandler MembershipOrUpgrade;
    }
}
