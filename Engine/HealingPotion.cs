using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int HealAmount { get; }

        public HealingPotion(int id, string name, string description, int healAmount)
            : base(id, name, description)
        {
            HealAmount = healAmount;
        }
    }
}
