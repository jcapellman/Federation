using Federation.UWP.Common;
using Federation.UWP.Enums;

namespace Federation.UWP.Objects.Game
{
    public class FactionStateGameItem
    {
        public Faction Faction { get; set; }

        public int DilithiumCrystals { get; set; }

        public int Credits { get; set; }

        public int ResearchLevel { get; set; }
        
        public FactionStateGameItem(Faction faction)
        {
            Faction = Faction;
            Credits = Constants.DEFAULT_NEW_GAME_CREDITS;
            DilithiumCrystals = Constants.DEFAULT_NEW_GAME_DILITHIUM;
            ResearchLevel = Constants.DEFAULT_NEW_GAME_RESEARCH_LEVEL;
        }
    }
}