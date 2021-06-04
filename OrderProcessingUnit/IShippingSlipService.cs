namespace OrderProcessingUnit
{
    public interface IShippingSlipService
    {
        void GenerateShippingSlipForAddress(string shippingAddress);
    }
}