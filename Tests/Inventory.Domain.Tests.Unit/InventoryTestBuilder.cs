namespace Inventory.Domain.Tests.Unit
{
    public class InventoryTestBuilder
    {
        private string _product = "Iphone";
        private double _unitPrice = 1100;

        public InventoryTestBuilder WithProduct(string product)
        {
            _product = product;
            return this;
        }

        public InventoryTestBuilder WithUnitPrice(double unitPrice)
        {
            _unitPrice = unitPrice;
            return this;
        }

        public Inventory Build()
        {
            return new Inventory(_product, _unitPrice);
        }
    }
}
