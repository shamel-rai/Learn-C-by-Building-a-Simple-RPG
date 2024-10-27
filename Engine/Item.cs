using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public int ID { get; }
        public string Name { get; }
        public string Description { get; }

        public Item(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
