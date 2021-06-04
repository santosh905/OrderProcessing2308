using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit
{
    public class OrderProcessingUnit
    {
        public string Process(ProductType productType)
        {
            if (productType == ProductType.physical_product)
            {
                Console.WriteLine("Packing Slip For Shipping");
                return ProcessResult.physical_Product_result;
            }
            else if (productType == ProductType.book)
            {
                Console.WriteLine("Create A Duplicate Packing Slip For The Royalty Department.");
                return ProcessResult.book_result;
            }
            else if (productType == ProductType.membership)
            {
                Console.WriteLine("Activate that membership");
                return ProcessResult.Membership_result;
            }
            else if (productType == ProductType.membershipUpgrade)
            {
                Console.WriteLine("Applied The Upgrade");
                return ProcessResult.Membership_Upgrade_Result;
            }
            else if (productType == ProductType.video)
            {
                Console.WriteLine("Add a free “First Aid” video to the packing slip (the result of a court decision in 1997)");
                return ProcessResult.Video_Result;
            }
            else return string.Empty;
        }
    }
}
