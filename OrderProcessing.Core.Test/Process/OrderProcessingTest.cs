using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingUnit;
using OrderProcessingUnit.Common;
using OrderProcessingUnit.Abstract;
using OrderProcessingUnit.Message;
using OrderProcessingUnit.Interfaces;

namespace OrderProcessing.Core.Process
{
    [TestClass]
    public class OrderProcessingTest
    {
        IMessageSender sender = null;
        ICommision commision = null;
        OrderProcessingBaseFactory factory;


        public OrderProcessingTest()
        {
            sender = new EmailSender();
            commision = new CommisionCalculator();
            factory = new OrderProcessingUnit.OrderProcessingUnit(sender, commision);
        }

        [TestMethod]
        public void If_the_payment_is_for_a_physical_product_generate_a_packing_slip_for_shipping()
        {
            bool isEmail = false;
            var ProcessA = factory.CreateProcess(ProductType.physical_product);
            var result = ProcessA.process();
            Assert.AreEqual(ProcessResult.physical_Product_result, result[0]);
            foreach (string eventname in factory.RecievedEvents)
            {
                if (eventname == ProcessResult.Physical_Product_Commision_Generated_Toagent)
                    isEmail = true;
            }

            if (isEmail) Assert.IsTrue(true);
            else Assert.Fail();
        }
        [TestMethod]
        public void If_the_payment_is_for_a_book_create_duplicate_packing_slip_for_the_royalty_department()
        {
            bool isEmail = false;
            var ProcessBook = factory.CreateProcess(ProductType.book);
            var result = ProcessBook.process();
            Assert.AreEqual(ProcessResult.book_result, result[0]);
            foreach (string eventname in factory.RecievedEvents)
            {
                if (eventname == ProcessResult.Book_Commision_Generated_Toagent)
                    isEmail = true;
            }

            if (isEmail) Assert.IsTrue(true);
            else Assert.Fail();
        }

        [TestMethod]
        public void If_the_payment_is_for_a_membership_activate_that_membership()
        {
            bool isEmail = false;
            var ProcessMemberShip = factory.CreateProcess(ProductType.membership);
            var result = ProcessMemberShip.process();
            Assert.AreEqual(ProcessResult.Membership_result, result[0]);
            foreach (string eventname in factory.RecievedEvents)
            {
                if (eventname == ProcessResult.Membership_EmailSentTo_Owner)
                    isEmail = true;
            }

            if (isEmail) Assert.IsTrue(true);
            else Assert.Fail();
        }

        [TestMethod]
        public void If_the_payment_is_an_upgrade_to_a_membership_apply_theupgrade()
        {
            bool isEmail = false;
            var ProcessMemberShipUpgrade = factory.CreateProcess(ProductType.membershipUpgrade);
            var result = ProcessMemberShipUpgrade.process();
            Assert.AreEqual(ProcessResult.Membership_Upgrade_Result, result[0]);
            foreach(string eventname in factory.RecievedEvents)
            {
                if (eventname == ProcessResult.UpgradeMembership_EmailSentTo_Owner)
                    isEmail = true;
            }

            if (isEmail) Assert.IsTrue(true);
            else Assert.Fail();
            
        }

    }
}
