namespace InventorySystem.Core
{
    public class Inventory
    {
        public InventorySettings Settings { get; set; }
        public List<InventorySlot> Slots { get; set; } = [];

        public Inventory(InventorySettings settings) : this(InventoryStyle.Default, InventoryType.Default, 0, settings) { }

        public Inventory(InventoryStyle inventoryStyle, InventoryType inventoryType, InventorySettings settings) : this(inventoryStyle, inventoryType, 0, settings) { }

        public Inventory(InventoryStyle inventoryStyle, InventoryType inventoryType, int slotCapacity = 0, InventorySettings? settings = null)
        {
            if (settings != null)
                Settings = settings;
            else
                Settings = new InventorySettings(inventoryStyle, inventoryType);

            if (slotCapacity > 0 && Settings.MaxCapacity != slotCapacity)
                Settings.MaxCapacity = slotCapacity;

            for (int i = 0; i < Settings.MaxCapacity; i++)
            {
                Slots.Add(new InventorySlot(i));
            }
        }

        public Inventory AddItem(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Item cannot be null");
            var itemCount = item.ItemCount;
            // Check for available slots or stackable items
            foreach (var slot in Slots)
            {
                if (!slot.IsOccupied)
                {
                    slot.StoredItem = item;
                    return this;
                }
                else if (Settings.IsStackable && item.IsStackable && slot.StoredItem != null && slot.StoredItem.ItemId == item.ItemId)
                {
                    var storedItem = slot.StoredItem;

                    // Skip if the current slot is full
                    if (storedItem.ItemCount >= Settings.MaxCapacity)
                        continue;

                    // Add items to the slot, respecting max capacity
                    if (storedItem.ItemCount + itemCount <= Settings.MaxCapacity)
                    {
                        storedItem.ItemCount += itemCount;
                        return this;
                    }
                    else
                    {
                        // Partial stack: fill this slot and continue with remainder
                        var remainingCount = (storedItem.ItemCount + itemCount) - Settings.MaxCapacity;
                        storedItem.ItemCount = Settings.MaxCapacity;
                        item.ItemCount = remainingCount;
                        itemCount = remainingCount;
                        continue;
                    }
                }
            }
            throw new InvalidOperationException("No available slots to add the item");
        }

        public InventorySlot GetSlot(int slotIndex)
        {
            if (Slots.Count == 0)
                throw new ArgumentException("There is no Inventory");
            if (slotIndex < 0 || slotIndex >= Slots.Count)
                throw new ArgumentOutOfRangeException(nameof(slotIndex), "Slot index is out of range");
            return Slots[slotIndex];
        }
    }
}
