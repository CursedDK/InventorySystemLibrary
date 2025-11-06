using InventorySystem.Helper;

namespace InventorySystem
{
    public enum ItemType
    {
        [ItemGroup(ItemGroup.Miscellaneous)] None,
        [ItemGroup(ItemGroup.Miscellaneous)] Miscellaneous,
        [ItemGroup(ItemGroup.Utility)] Tool,
        [ItemGroup(ItemGroup.Utility)] Food,
        [ItemGroup(ItemGroup.Utility)] CraftingMaterial,
        [ItemGroup(ItemGroup.Utility)] Consumable,
        [ItemGroup(ItemGroup.Economy)] Currency,
        [ItemGroup(ItemGroup.Companions)] Pet,
        [ItemGroup(ItemGroup.Companions)] Vehicle,
        [ItemGroup(ItemGroup.Companions)] Mount,
        [ItemGroup(ItemGroup.Combat)] Potion,
        [ItemGroup(ItemGroup.Combat)] Scroll,
        [ItemGroup(ItemGroup.Combat)] Gem,
        [ItemGroup(ItemGroup.Combat)] Accessory,
        [ItemGroup(ItemGroup.Combat)] Spellbook,
        [ItemGroup(ItemGroup.Combat)] MagicItem,
        [ItemGroup(ItemGroup.Combat)] Weapon,
        [ItemGroup(ItemGroup.Combat)] Armor,
        [ItemGroup(ItemGroup.World)] Artifact,
        [ItemGroup(ItemGroup.World)] Trophy,
        [ItemGroup(ItemGroup.World)] Decoration,
        [ItemGroup(ItemGroup.World)] Clothing,
        [ItemGroup(ItemGroup.World)] Furniture,
        [ItemGroup(ItemGroup.World)] QuestItem,
        [ItemGroup(ItemGroup.Utility)] KeyItem,
        [ItemGroup(ItemGroup.Utility)] Resource,
        [ItemGroup(ItemGroup.Utility)] Ingredient,
        [ItemGroup(ItemGroup.Utility)] Container
    }

    public enum ItemGroup
    {
        Combat,
        Utility,
        Economy,
        World,
        Companions,
        Miscellaneous
    }

    public enum ItemRarity
    {
        None,
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }

    public enum InventoryType
    {
        None,
        Default,
        Player,
        NPC,
        Container
    }

    public enum InventoryStyle
    {
        None,
        Default,
        Grid,
        List,
        DragAndDrop,
        SlotBased,
        Stacked,
        Categorized,
        Custom
    }
}
