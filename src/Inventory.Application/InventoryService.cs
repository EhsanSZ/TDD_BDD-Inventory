using Inventory.Application.Contract;
using Inventory.Domain;

namespace Inventory.Application
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public bool Define(DefineInventory command)
        {
            var inventory = new Domain.Inventory(command.Product, command.UnitPrice);

            _inventoryRepository.Create(inventory);

            return true;
        }
    }
}
