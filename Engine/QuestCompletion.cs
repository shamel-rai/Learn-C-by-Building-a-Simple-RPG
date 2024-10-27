using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class QuestCompletionItem
    {
        public Item Item { get; }
        public int Quantity { get; }

        public QuestCompletionItem(Item item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
    }
}
