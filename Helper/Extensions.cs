using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Helper
{
    public static class Extensions
    {
        private static readonly Dictionary<ItemType, ItemGroup> _itemGroupCache = new();
        private static readonly object _cacheLock = new();

        public static ItemGroup GetGroup(this ItemType type)
        {
            // Check cache first
            if (_itemGroupCache.TryGetValue(type, out var cachedGroup))
                return cachedGroup;

            // Use lock for thread-safe cache initialization
            lock (_cacheLock)
            {
                // Double-check pattern
                if (_itemGroupCache.TryGetValue(type, out cachedGroup))
                    return cachedGroup;

                var member = typeof(ItemType).GetMember(type.ToString()).FirstOrDefault();
                var attr = member?.GetCustomAttributes(typeof(ItemGroupAttribute), false)
                                  .Cast<ItemGroupAttribute>()
                                  .FirstOrDefault();
                var group = attr?.Group ?? ItemGroup.Miscellaneous;

                _itemGroupCache[type] = group;
                return group;
            }
        }
    }

}
