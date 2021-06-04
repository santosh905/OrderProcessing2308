using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit
{
    public class OrderProcessingUnit
    {
        public void Process(ProductType productType)
        {
            if(productType == ProductType.physical_product)
            {
                Console.WriteLine("packing slip for shipping");
            }
            else if (productType == ProductType.book)
            {
                Console.WriteLine("create a duplicate packing slip for the royalty department.");
            }
            else if (productType == ProductType.membership)
            {
                Console.WriteLine("Activate that membership");
            }
            else if (productType == ProductType.membershipUpgrade)
            {
                Console.WriteLine("apply theupgrade");
            }
            else if (productType == ProductType.video)
            {
                Console.WriteLine("packing slip for shipping");
            }
        }
    }
}
