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
        IList<string> results = null;
        string name = "MemberShip";

        public MembershipProcess()
        {
            results = new List<string>();
        }
        
        protected virtual void OnMembershipOrUpgrade(MembershipProcess membershipProcess, EventArgs e)
        {
            EventHandler handler = MembershipOrUpgrade;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        IList<string> IProcess.process()
        {
            Console.WriteLine("Activate that membership");
            OnMembershipOrUpgrade(this,EventArgs.Empty);
            results.Add(ProcessResult.Membership_result);
            return results;
        }

        public event EventHandler MembershipOrUpgrade;
    }
}
