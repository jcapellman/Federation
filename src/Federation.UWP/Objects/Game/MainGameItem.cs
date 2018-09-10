using System;
using System.Collections.Generic;
using System.Linq;

using Federation.UWP.Common;
using Federation.UWP.Enums;

using LiteDB;

namespace Federation.UWP.Objects.Game
{
    public class MainGameItem
    {
        [BsonId]
        public int GameID { get; set; }

        public GameSize GameSize { get; set; }

        public Faction PlayerFaction { get; set; }

        public List<GalaxyMapItem> GalaxyMapItems { get; set; }

        public List<FactionStateGameItem> FactionStates { get; set; }

        public int TurnNumber { get; set; }

        public DateTime SaveDate { get; set; }

        public MainGameItem(GameSize gameSize, Faction playerFaction)
        {
            PlayerFaction = playerFaction;

            TurnNumber = 1;

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

            FactionStates = new List<FactionStateGameItem>();

            FactionStates = ExtensionMethods.FactionList.Select(a => new FactionStateGameItem(a)).ToList();
        }
    }
}