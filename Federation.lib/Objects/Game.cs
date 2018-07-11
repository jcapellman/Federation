using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Federation.lib.Enums;
using Federation.lib.Objects.Ships;

namespace Federation.lib.Objects {
    [DataContract]
    public class Game {
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public Difficulty GameDifficulty { get; set; }

        [DataMember]
        public string PlayerName { get; set; }

        [DataMember]
        public int TurnNumber { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public int AlloyTotal { get; set; }

        [DataMember]
        public int LatinumTotal { get; set; }

        [DataMember]
        public int DilithiumTotal { get; set; }

        [DataMember]
        public ObservableCollection<Planets> PlayerPlanets { get; set; }

        [DataMember]
        public ObservableCollection<BaseShip> PlayerShips { get; set; }

        [DataMember]
        public ObservableCollection<BaseEvent> EventSummary { get; set; }

        [DataMember]
        public ObservableCollection<BaseResearchItem> ResearchItems { get; set; }

        [DataMember]
        public ObservableCollection<BaseConstructionItem> ConstructionItems { get; set; }

        public Game() { }

        public Game(string playerName, Difficulty gameDifficulty) {
            PlayerName = playerName;
            GameDifficulty = gameDifficulty;

            TurnNumber = 1;
            Year = 2245;

            DilithiumTotal = 5;
            LatinumTotal = 5;
            AlloyTotal = 5;

            PlayerShips = new ObservableCollection<BaseShip>();
            PlayerPlanets = new ObservableCollection<Planets>();
            EventSummary = new ObservableCollection<BaseEvent>();
            ResearchItems = new ObservableCollection<BaseResearchItem>();
            ConstructionItems = new ObservableCollection<BaseConstructionItem>();

#if DEBUG
            PlayerPlanets = new ObservableCollection<Planets> {
                new Planets {Description = "Earth", PlanetTexture = "/Assets/Planets/Cool_Large.png", AlloyPerTurn = 0, DilithiumPerTurn = 10, LatinumPerTurn = 3},
                new Planets { Description = "Mars", PlanetTexture = "/Assets/Planets/Red_Large.png", AlloyPerTurn = 1, DilithiumPerTurn = 0, LatinumPerTurn = 10},
                new Planets { Description = "Jupiter", PlanetTexture = "/Assets/Planets/Sepia_Large.png", AlloyPerTurn = 5, DilithiumPerTurn = 3, LatinumPerTurn = 5}
            };

            PlayerShips = new ObservableCollection<BaseShip> {
                new Federation_ConstitutionRefit(),
                new Federation_Reliant(),
                new Federation_Nebula(),
                new Federation_Runabout(),
                new Federation_Oberth(),
                new Federation_NX01(),
                new Federation_Excelsior()
            };

            ConstructionItems = new ObservableCollection<BaseConstructionItem> { 
                new BaseConstructionItem { Object = new Federation_Reliant(), TurnsRemaining = 2 }
            };

            ResearchItems = new ObservableCollection<BaseResearchItem> { 
                new BaseResearchItem { Object = new Federation_ConstitutionRefit(), TurnsRemaining = 5 }
            };


#endif

        }
    }
}
