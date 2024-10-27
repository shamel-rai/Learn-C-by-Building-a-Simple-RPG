using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootItem
    {
        public Item Item { get; }
        public int Chance { get; }
        public bool IsAlwaysDropped { get; }

        public LootItem(Item item, int chance, bool isAlwaysDropped)
        {
            Item = item;
            Chance = chance;
            IsAlwaysDropped = isAlwaysDropped;
        }
    }
}
