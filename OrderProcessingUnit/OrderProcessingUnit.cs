using OrderProcessingUnit.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit
{
    public class OrderProcessingUnit
    {
        private IList<string> results = new List<string>();
        public IList<string> Process(ProductType productType)
        {
            if (productType == ProductType.physical_product)
            {
                Console.WriteLine("Packing Slip For Shipping");
                results.Add(ProcessResult.physical_Product_result);
                results.Add(ProcessResult.Commision_Generated_Toagent);
                return results;
            }
            else if (productType == ProductType.book)
            {
                Console.WriteLine("Create A Duplicate Packing Slip For The Royalty Department.");
                results.Add(ProcessResult.book_result);
                results.Add(ProcessResult.Commision_Generated_Toagent);
                return results;
            }
            else if (productType == ProductType.membership)
            {
                Console.WriteLine("Activate that membership");
                results.Add(ProcessResult.Membership_result);
                results.Add(ProcessResult.EmailSentTo_Owner);
                return results;
            }
            else if (productType == ProductType.membershipUpgrade)
            {
                Console.WriteLine("Applied The Upgrade");
                results.Add(ProcessResult.Membership_Upgrade_Result);
                results.Add(ProcessResult.EmailSentTo_Owner);
                return results;
            }
            else if (productType == ProductType.video)
            {
                Console.WriteLine("Add a free “First Aid” video to the packing slip (the result of a court decision in 1997)");
                results.Add(ProcessResult.Video_Result);
                return results;
            }
            else return null; ;
        }
    }
}
