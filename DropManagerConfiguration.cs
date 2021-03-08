using Rocket.API;
using System.Collections.Generic;

namespace DropManager
{
    public class DropManagerConfiguration : IRocketPluginConfiguration
    {
        public bool ShowWarnings;
        public string LeftOtherDrop;

        public List<Item> Items;

        public string BlackListIds;

        public void LoadDefaults()
        {
            ShowWarnings = true;
            LeftOtherDrop = "100%";
            
            Items = new List<Item>
            {
                new Item("Box of Gun Parts", 36230, 1, 2)
                new Item("Standard Coin", 62626, 1, 3)
            };

            BlackListIds = "47132, 58950, 41829";
        }
    }
}
