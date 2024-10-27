using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public int Damage { get; }
        public int AttackValue { get; }

        public Weapon(int id, string name, string description, int damage, int attackValue)
            : base(id, name, description)
        {
            Damage = damage;
            AttackValue = attackValue;
        }
    }
}

