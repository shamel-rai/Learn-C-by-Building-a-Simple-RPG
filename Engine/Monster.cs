using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster
    {
        public int ID { get; }
        public string Name { get; }
        public int Health { get; }
        public int Damage { get; }
        public int Experience { get; }
        public int Gold { get; }
        public int LootTableChance { get; }
        public List<LootItem> LootTable { get; } = new List<LootItem>();

        public Monster(int id, string name, int health, int damage, int experience, int gold, int lootTableChance)
        {
            ID = id;
            Name = name;
            Health = health;
            Damage = damage;
            Experience = experience;
            Gold = gold;
            LootTableChance = lootTableChance;
        }
    }
}
