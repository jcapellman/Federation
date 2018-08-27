using System.Collections.Generic;

using Federation.UWP.Enums;

namespace Federation.UWP.Objects.Game
{
    public class MainGameItem
    {
        public GameSize GameSize { get; set; }

        public List<GalaxyMapItem> GalaxyMapItems { get; set; }

        public MainGameItem(GameSize gameSize)
        {
            GalaxyMapItems = new List<GalaxyMapItem>();

            for (var x = 0; x < (int) gameSize; x++)
            {
                GalaxyMapItems.Add(new GalaxyMapItem
                {
                    Race = Race.Federation,
                    SystemName = "SOL"
                });
            }
        }
    }
}