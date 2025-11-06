using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Core
{
    public class InventorySlot
    {
        public int SlotIndex { get; set; }
        public bool IsOccupied => StoredItem != null && !string.IsNullOrEmpty(StoredItem.Name);
        public Item StoredItem { get; set; } 

        public InventorySlot(int slotIndex)
        {
            if (slotIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(slotIndex), "SlotIndex cannot be negative.");
            SlotIndex = slotIndex;
            StoredItem = new Item();
        }

        public override string ToString()
        {
            return $"SlotIndex: {SlotIndex}, StoredItem: {StoredItem.Name} ({StoredItem.Rarity})";
        }
    }
}
