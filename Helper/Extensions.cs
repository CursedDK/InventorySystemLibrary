using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Helper
{
    public static class Extensions
    {
        public static ItemGroup GetGroup(this ItemType type)
        {
            var member = typeof(ItemType).GetMember(type.ToString()).FirstOrDefault();
            var attr = member?.GetCustomAttributes(typeof(ItemGroupAttribute), false)
                              .Cast<ItemGroupAttribute>()
                              .FirstOrDefault();
            return attr?.Group ?? ItemGroup.Miscellaneous;
        }
    }

}
