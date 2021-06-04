namespace OrderProcessingUnit.Interfaces
{
    public interface IShippingSlipService
    {
        void GenerateShippingSlipForAddress(string shippingAddress);
    }
}