namespace InventorySystem.Core
{
    public class InventorySettings
    {
        // Default Settings
        public const int DefaultMaxCapacity = 30;
        public const float DefaultWeightLimit = 50f;
        public const bool DefaultIsStackable = true;


        // Inventory Settings for normal Inventory
        public bool IsStackable { get; set; } = DefaultIsStackable;
        public int MaxCapacity { get; set; } = DefaultMaxCapacity;
        public float WeightLimit { get; set; } = DefaultWeightLimit;
        public InventoryStyle InventoryStyle { get; set; }
        public InventoryType InventoryType { get; set; }

        public InventorySettings(InventoryStyle inventoryStyle, InventoryType inventoryType)
        {
            InventoryStyle = inventoryStyle;
            InventoryType = inventoryType;

            if (inventoryType == InventoryType.None || inventoryType == InventoryType.Default)
            {
                IsStackable = DefaultIsStackable;
                MaxCapacity = DefaultMaxCapacity;
                WeightLimit = DefaultWeightLimit;
            }
            else if (inventoryType == InventoryType.Container)
            {
                IsStackable = false;
                MaxCapacity = 50;
                WeightLimit = 300f;
            }
            else if (inventoryType == InventoryType.NPC)
            {
                IsStackable = true;
                MaxCapacity = 80;
                WeightLimit = 400f;
            }
            else if (inventoryType == InventoryType.Player)
            {
                IsStackable = true;
                MaxCapacity = 100;
                WeightLimit = 500f;
            }
        }
    }
}
