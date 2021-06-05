using OrderProcessingUnit.Abstract;
using OrderProcessingUnit.Common;
using OrderProcessingUnit.Interfaces;
using OrderProcessingUnit.OrderProcess;
using OrderProcessingUnit.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit
{
    public class OrderProcessingUnit : OrderProcessingBaseFactory
    {
        private IList<string> results = new List<string>();
        List<string> receivedEvents = new List<string>();
        private readonly IMessageSender _message;
        private readonly ICommision _commison;

        public OrderProcessingUnit(IMessageSender message, ICommision commison)
        {
            _message = message;
            _commison = commison;
        }

        public override IProcess CreateProcess(ProductType productType)
        {
            if (productType == ProductType.physical_product)
            {
                var physicalProduct = new PhysicalProductProcess();
                physicalProduct.GenerateCommision += PhysicalProduct_GenerateCommision;
                return physicalProduct;
            }
            else if (productType == ProductType.book)
            {
                var book = new BookProcess();
                book.GenerateCommision += PhysicalProduct_GenerateCommision;
                return book;
            }
            else if (productType == ProductType.membership)
            {
                var membership = new MembershipProcess();
                membership.MembershipOrUpgrade += Membership_MembershipOrUpgrade;
                return membership;
            }
            else if (productType == ProductType.membershipUpgrade)
            {
                var upgrade = new UpgradeMembershipProcess();
                upgrade.MembershipOrUpgrade += Membership_MembershipOrUpgrade;
                return upgrade;
            }
            else if (productType == ProductType.video)
            {
                var video = new VideoProcess("Learning to Ski");
                return video;
            }
            else
                return null;
        }

        private void PhysicalProduct_GenerateCommision(object sender, EventArgs e)
        {
            Console.WriteLine("Commision {0} is generated to Agent", _commison.GetCommision());
            if (sender is PhysicalProductProcess)
                receivedEvents.Add(ProcessResult.Physical_Product_Commision_Generated_Toagent);
            else if (sender is BookProcess)
                receivedEvents.Add(ProcessResult.Book_Commision_Generated_Toagent);
        }

        private void Membership_MembershipOrUpgrade(object sender, EventArgs e)
        {
            _message.SendMessage("Member Or Upgrade", "Member is created or upgraded");
            if (sender is MembershipProcess)
                receivedEvents.Add(ProcessResult.Membership_EmailSentTo_Owner);
            else if (sender is UpgradeMembershipProcess)
                receivedEvents.Add(ProcessResult.UpgradeMembership_EmailSentTo_Owner);
        }

        public override List<string> RecievedEvents 
        {
            get { return receivedEvents; }
        }
    }
}
