using OrderProcessingUnit.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit
{
    public class Product
    {
        private string _shippingAddress;
        private string _name;
        private readonly string _productCode;
        private ProductType _productType;

        public Product(string name)
        {
            this._name = name;
            _productCode = Guid.NewGuid().ToString("N");
        }

        public void SetShippingAddress(string shippingAddress)
        {
            this._shippingAddress = shippingAddress;
        }

        public string GetShippingAddress()
        {
            return _shippingAddress;
        }

        public string GetProductCode()
        {
            return _productCode;
        }

        public void SetProductType(ProductType productType)
        {
            this._productType = productType;
        }

        public ProductType GetProductType()
        {
            return this._productType;
        }
    }
}
