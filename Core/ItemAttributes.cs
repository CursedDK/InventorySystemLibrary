using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Core
{
    public class ItemAttributes(string attributeName, float attributeValue)
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; } = attributeName;
        public float AttributeValue { get; set; } = attributeValue;
    }
}
