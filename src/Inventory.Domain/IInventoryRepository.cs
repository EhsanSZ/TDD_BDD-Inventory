namespace Inventory.Domain
{
    public interface IInventoryRepository
    {
        void Create(Inventory entity);
        void Save();
    }
}

