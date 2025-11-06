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
        public Attribute Attribute { get; set; }

        public override string ToString()
        {
            return $"Item: {Name}, Rarity: {Rarity}, Type: {ItemType}, Group: {ItemGroup}, Stackable: {IsStackable}, Count: {ItemCount}";
        }

    }

    // Create a Default itemList for testing
    public class ItemDatabase
    {
        public static List<Item> DefaultItems =
        [
            new() { Name = "Health Potion", Rarity = ItemRarity.Common, IsStackable = true, ItemGroup = ItemGroup.Combat, ItemType = ItemType.Potion },
            new() { Name = "Mana Potion", Rarity = ItemRarity.Common, IsStackable = true, ItemGroup = ItemGroup.Combat, ItemType = ItemType.Potion },
            new() { Name = "Iron Sword", Rarity = ItemRarity.Uncommon, IsStackable = false, ItemGroup = ItemGroup.Combat, ItemType = ItemType.Weapon },
            new() { Name = "Steel Shield", Rarity = ItemRarity.Rare, IsStackable = false, ItemGroup = ItemGroup.Combat, ItemType = ItemType.Weapon },
            new() { Name = "Golden Apple", Rarity = ItemRarity.Epic, IsStackable = true, ItemGroup = ItemGroup.Utility, ItemType = ItemType.Food }
        ];
    }





}
