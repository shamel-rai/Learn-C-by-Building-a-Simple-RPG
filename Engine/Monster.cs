using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature  //Inheritance
    {
        public int ID { get; set; }
        public string Name { get; set; }
       
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints {  get; set; }
        public int RewardGold { get; set; }

        public Monster(int id,string name, int maxDmg, int rewardExperiencePoints, int rewardGold, int maxHitPoints, int currentHitPoints ): base(maxHitPoints, currentHitPoints) { 
            ID = id;
            Name = name;
            MaximumDamage = maxDmg;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }

    }
}
