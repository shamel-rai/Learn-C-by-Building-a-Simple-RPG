using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Engine
{
    public class Player : LivingCreature
    {

        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public Location CurrentLocation { get; set; }

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int currentHitPoints, int maxHitPoints, int gold, int experiencePoints, int level)
            : base(currentHitPoints, maxHitPoints)
        {
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }

        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if (location.ItemRequiredToEnter == null) return true;   // There is no required item for this location, so return "true"
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == ((Item)location.ItemRequiredToEnter).ID) return true;  // We found the required item, so return "true"
            }
            return false;  // We didn't find the required item in their inventory, so return "false"
        }

        public bool HasThisQuest(Quest quest)
        {
            foreach (PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.ID == quest.ID) return true;
            }
            return false;
        }

        public bool CompletedThisQuest(Quest quest)
        {
            foreach (PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.ID == quest.ID) return playerQuest.IsCompleted;
            }
            return false;
        }
        public bool HasAllQuestCompletionItems(Quest quest)
        {
            //See if the player has all the item needed to complete the quest here
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                bool foundItemInPlayersInventory = false;

                //Check each item in the players inventory, to see if they have it and enough of it 
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        foundItemInPlayersInventory = true;
                        if(ii.Quantity < qci.Quantity) //the player doesnot have enough of the item to complete the quest
                        {
                            return false; 
                        }
                    }
                }
                //The player does not have any of the quest completion item in their inventory
                if (!foundItemInPlayersInventory)
                {
                    return false; 
                }
             }
            return false;
        }

        public void RemoveQuestCompletionItem (Quest quest)
        {
            foreach(QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                foreach(InventoryItem ii in Inventory)
                {
                    if(ii.Details.ID == qci.Details.ID)
                    {
                        ii.Quantity -= qci.Quantity;
                        break; 
                    }
                }
            }
        }
        public void AddItemToInventory(Item itemToAdd)
        {
            foreach(InventoryItem ii in Inventory)
            {
                if(ii.Details.ID == itemToAdd.ID)
                {
                    //They have the item in their inventory, so increate the quantity by one
                    ii.Quantity++;
                    return;
                }
            }
            Inventory.Add(new InventoryItem(itemToAdd,1)); 
        }

        public void MarkQuestCompleted(Quest quest)
        {
            //Find the quest in the players quest list
            foreach(PlayerQuest pq in Quests)
            {
                if(pq.Details.ID == quest.ID)
                {
                    //Mark it as complete
                    pq.IsCompleted = true;
                    return; //just to exit the method 
                }
            }
        }
       
    }
}
