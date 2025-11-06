using InventorySystem.Core;

namespace InventorySystem
{
    public interface IInventory
    {
        InventorySettings Settings { get; set; }
        List<InventorySlot> Slots { get; set; }
        InventorySlot GetSlot(int slot);
        InventorySlot GetSlot(InventorySlot slot);

    }
}
