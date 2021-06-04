using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit
{
    public class Payment
    {
        private readonly Product _product;
        private decimal _amount;
        private IShippingSlipService _shippingSlipService;
        private string _shippingAddress;

        public Payment(Product product, string shippingAddress)
        {
            if (_product == null) throw new ArgumentNullException("product");
            if (shippingAddress == null) throw new ArgumentNullException("shippingAddress");

            this._product = product;
            this._shippingAddress = shippingAddress;
        }

        public virtual void CompletePayment(decimal amount)
        {
            _amount = amount;
            if (_product != null) _shippingSlipService.GenerateShippingSlipForAddress(_product.GetShippingAddress());
        }

        public void SetShippingService(IShippingSlipService shippingSlipService)
        {
            _shippingSlipService = shippingSlipService;
        }
    }

}
