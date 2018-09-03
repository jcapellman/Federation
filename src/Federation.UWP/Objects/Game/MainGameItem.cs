﻿using System.Collections.Generic;

using Federation.UWP.Common;
using Federation.UWP.Enums;

namespace Federation.UWP.Objects.Game
{
    public class MainGameItem
    {
        public GameSize GameSize { get; set; }

        public Faction PlayerFaction { get; set; }

        public List<GalaxyMapItem> GalaxyMapItems { get; set; }

        public List<FactionStateGameItem> FactionStates { get; set; }

        public int TurnNumber { get; set; }

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

            foreach (var faction in ExtensionMethods.RaceList)
            {
                var factionStateItem = new FactionStateGameItem
                {
                    Credits = 1000,
                    DilithiumCrystals = 100,
                    Faction = faction,
                    ResearchLevel = 1
                };

                FactionStates.Add(factionStateItem);
            }
        }
    }
}