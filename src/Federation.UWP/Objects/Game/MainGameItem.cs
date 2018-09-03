using System.Collections.Generic;

using Federation.UWP.Enums;

namespace Federation.UWP.Objects.Game
{
    public class MainGameItem
    {
        public GameSize GameSize { get; set; }

        public Faction PlayerFaction { get; set; }

        public List<GalaxyMapItem> GalaxyMapItems { get; set; }

        public MainGameItem(GameSize gameSize, Faction playerFaction)
        {
            PlayerFaction = playerFaction;

            GalaxyMapItems = new List<GalaxyMapItem>
            {
                new GalaxyMapItem
                {
                    Faction = playerFaction,
                    SystemName = Common.Constants.FEDERATION_GAMESTART_SYSTEM
                }
            };
            
            for (var x = 1; x < (int) gameSize; x++)
            {
                GalaxyMapItems.Add(new GalaxyMapItem
                {
                    Faction = Faction.Unknown,
                    SystemName = Common.Constants.GAMESTART_UNKNOWN_SYSTEM
                });
            }
        }
    }
}