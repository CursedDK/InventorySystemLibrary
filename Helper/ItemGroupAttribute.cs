using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Helper
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ItemGroupAttribute(ItemGroup group) : Attribute
    {
        public ItemGroup Group { get; } = group;
    }

}
