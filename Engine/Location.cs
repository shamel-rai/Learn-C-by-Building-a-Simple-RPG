using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; }
        public string Name { get; }
        public string Description { get; }
        public Monster MonsterLivingHere { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToWest { get; set; }
        public Item RequiredItem { get; }
        public object ItemRequiredToEnter { get; set; }

        public Location(int id, string name, string description, Item requiredItem = null)
        {
            ID = id;
            Name = name;
            Description = description;
            RequiredItem = requiredItem;
        }
    }
}
