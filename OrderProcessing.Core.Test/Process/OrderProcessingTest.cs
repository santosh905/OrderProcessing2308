using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingUnit;

namespace OrderProcessing.Core.Process
{
    [TestClass]
    public class OrderProcessingTest
    {
        private OrderProcessingUnit.OrderProcessingUnit orderProcessingUnit = new OrderProcessingUnit.OrderProcessingUnit();
        [TestMethod]
        public void If_the_payment_is_for_a_physical_product_generate_a_packing_slip_for_shipping()
        {
            var result = orderProcessingUnit.Process(ProductType.physical_product);
            Assert.AreEqual(ProcessResult.physical_Product_result, result);
        }
        [TestMethod]
        public void If_the_payment_is_for_a_book_create_duplicate_packing_slip_for_the_royalty_department()
        {
            var result = orderProcessingUnit.Process(ProductType.book);
            Assert.AreEqual(ProcessResult.book_result, result);
        }

        [TestMethod]
        public void If_the_payment_is_for_a_membership_activate_that_membership()
        {
            var result = orderProcessingUnit.Process(ProductType.membership);
            Assert.AreEqual(ProcessResult.Membership_result, result);
        }

        [TestMethod]
        public void If_the_payment_is_an_upgrade_to_a_membership_apply_theupgrade()
        {
            var result = orderProcessingUnit.Process(ProductType.membershipUpgrade);
            Assert.AreEqual(ProcessResult.Membership_Upgrade_Result, result);
        }

    }
}
