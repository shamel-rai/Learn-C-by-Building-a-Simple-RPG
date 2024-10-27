using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; }
        public string Name { get; }
        public string Description { get; }
        public int ExperienceReward { get; }
        public int GoldReward { get; }
        public List<QuestCompletionItem> QuestCompletionItems { get; } = new List<QuestCompletionItem>();
        public Item RewardItem { get; set; }

        public Quest(int id, string name, string description, int experienceReward, int goldReward)
        {
            ID = id;
            Name = name;
            Description = description;
            ExperienceReward = experienceReward;
            GoldReward = goldReward;
        }
    }
}
