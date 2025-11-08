using InventorySystem.Helper;

namespace InventorySystem.Core
{
    public class Item
    {
        public Guid ItemId { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";
        public ItemRarity Rarity { get; set; }
        public bool IsStackable { get; set; } = true;
        public ItemGroup ItemGroup { get; set; } = ItemGroup.Combat;
        public ItemType ItemType { get; set; }
        public int ItemCount { get; set; }
        public List<ItemAttributes> Attribute { get; set; }

        public Item(string name, ItemRarity rarity, bool isStackable, ItemGroup itemGroup, ItemType itemType, List<ItemAttributes> attributes, int itemCount = 1)
        {
            Name = name;
            Rarity = rarity;
            IsStackable = isStackable;
            ItemGroup = itemGroup;
            ItemType = itemType;
            ItemCount = itemCount;
            if (attributes != null && attributes.Count > 0)
            {
                Attribute = attributes;
            }
            else
            {
                Attribute = [];
            }
        }

        public override string ToString()
        {
            return $"Item: {Name}, Rarity: {Rarity}, Type: {ItemType}, Group: {ItemGroup}, Stackable: {IsStackable}, Count: {ItemCount}";
        }

    }
}
