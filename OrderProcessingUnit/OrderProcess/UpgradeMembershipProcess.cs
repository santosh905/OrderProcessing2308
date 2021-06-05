using OrderProcessingUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit.OrderProcess
{
    public class UpgradeMembershipProcess : IProcess
    {
        IList<string> results = null;
        string name = "UpgradeMemberShip";
        public UpgradeMembershipProcess()
        {
            results = new List<string>();
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
            Console.WriteLine("apply theupgrade.");
            OnMembershipOrUpgrade(EventArgs.Empty);
            results.Add(ProcessResult.Membership_Upgrade_Result);
            return results;
        }

        public event EventHandler MembershipOrUpgrade;
    }
}
