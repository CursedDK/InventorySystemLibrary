namespace InventorySystem.Core
{
    public class Inventory
    {
        public InventorySettings Settings { get; set; }
        public List<InventorySlot> Slots { get; set; }


        public Inventory(InventoryStyle inventoryStyle, InventoryType inventoryType)
        {
            Settings = new InventorySettings(inventoryStyle, inventoryType);
            Slots = [];
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
                var storedItem = slot.StoredItem;
                if (!slot.IsOccupied)
                {
                    slot.StoredItem = item;

                    return this;
                }
                else if (Settings.IsStackable && storedItem.ItemId == item.ItemId)
                {
                    if (!item.IsStackable)
                        // the item is not stackable
                        continue;

                    if (storedItem.ItemCount + itemCount > Settings.MaxCapacity)
                    {
                        //TODO: get next available slot for remaining items
                        var remainingCount = (storedItem.ItemCount + itemCount) - Settings.MaxCapacity;
                        storedItem.ItemCount = Settings.MaxCapacity;
                        item.ItemCount = remainingCount;
                        continue;
                    }



                    if (storedItem.ItemCount == Settings.MaxCapacity)
                        // the current slot is full
                        continue;

                    if (storedItem.ItemCount + itemCount <= Settings.MaxCapacity)
                        continue;

                    storedItem.ItemCount += itemCount;
                    return this;
                }
            }
            throw new InvalidOperationException("No available slots to add the item");
        }

        public InventorySlot GetSlot(int slotIndex)
        {
            if (Slots.Count == 0)
                throw new ArgumentException("There is no Inventory");
            var t = Slots.FirstOrDefault(s => s.SlotIndex == slotIndex) ?? new InventorySlot(-1);
            return t;
        }
    }
}
