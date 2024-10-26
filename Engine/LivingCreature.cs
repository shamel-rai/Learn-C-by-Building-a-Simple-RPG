using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        public int MaximumHitPoints { get; set; } // Corrected name
        public int CurrentHitPoints { get; set; }

        public LivingCreature(int maxHitPoints, int currentHitPoints)
        {
            MaximumHitPoints = maxHitPoints;
            CurrentHitPoints = currentHitPoints;
        }
    }
}
