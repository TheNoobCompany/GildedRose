using System.Collections.Generic;

namespace GildedRose.Console
{
    public class InventoryManager
    {
        public static IList<Item> Inventory { get; set; }

        public static void UpdateQuality()
        {
            foreach (Item currentItem in Inventory)
            {
                UpdateItem(currentItem);
            }
        }

        private static void UpdateItem(Item currentItem)
        {
            if (currentItem is UpdateableItem updateableItem)
            {
                updateableItem.Update();
            }
        }
    }
}