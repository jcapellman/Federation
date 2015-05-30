using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Federation.WindowsUniversal.Controls;
using Federation.PCL.Enums;
using Federation.PCL.Objects;
using Federation.PCL.Objects.Ships;

namespace Federation.WindowsUniversal.Models {
    public class GameModel : INotifyPropertyChanged {
        private readonly Game _currentGame;

        public ObservableCollection<BaseEvent> EventSummary {
            get { return _currentGame.EventSummary; }

            set { _currentGame.EventSummary = value; OnPropertyChanged(); }
        }

        public int CurrentAlloyTotal { 
            get { return _currentGame.AlloyTotal; } 

            set { _currentGame.AlloyTotal = value; OnPropertyChanged(); } }

        public int CurrentLatinumTotal { 
            get { return _currentGame.LatinumTotal; } 

            set { _currentGame.LatinumTotal = value; OnPropertyChanged(); } 
        }

        public int CurrentDilithiumTotal { 
            get { return _currentGame.DilithiumTotal; } 

            set { _currentGame.DilithiumTotal = value; OnPropertyChanged(); } 
        }

        public int CurrentTurnNumber {
            get { return _currentGame.TurnNumber; }

            set { _currentGame.TurnNumber = value; OnPropertyChanged(); }
        }

        public int CurrentYear { get { return _currentGame.Year; } set { _currentGame.Year = value; OnPropertyChanged(); } }

        public ObservableCollection<Planets> Planets {
            get { return _currentGame.PlayerPlanets; }

            set { _currentGame.PlayerPlanets = value; OnPropertyChanged(); }
        }

        public ObservableCollection<BaseShip> Ships {
            get { return _currentGame.PlayerShips; } 
            set { _currentGame.PlayerShips = value; OnPropertyChanged(); }
        }

        public ObservableCollection<BaseResearchItem> ResearchItems {
            get { return _currentGame.ResearchItems; }
            set { _currentGame.ResearchItems = value; OnPropertyChanged(); }
        }

        public ObservableCollection<BaseConstructionItem> ConstructionItems {
            get { return _currentGame.ConstructionItems; }
            set { _currentGame.ConstructionItems = value; OnPropertyChanged(); }
        }

        private ObservableCollection<GalaxyPlanet> _galaxyPlanets;

        public ObservableCollection<GalaxyPlanet> GalaxyPlanets {
            get { return _galaxyPlanets; }
            set { _galaxyPlanets = value; OnPropertyChanged(); }
        }

        public GameModel() {
            _currentGame = new Game("Jarred Capellman", Difficulty.Easy);

            _galaxyPlanets = new ObservableCollection<GalaxyPlanet>();
        }

        public void SaveGame() {
            
        }

        #region property changed
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            var handler = PropertyChanged;

            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        public void NextTurn() {
            CurrentYear++;
            CurrentTurnNumber++;

            EventSummary = new ObservableCollection<BaseEvent>();

            foreach (var planet in Planets) {
                CurrentAlloyTotal += planet.AlloyPerTurn;
                CurrentDilithiumTotal += planet.DilithiumPerTurn;
                CurrentLatinumTotal += planet.LatinumPerTurn;
            }

            foreach (var ship in Ships) {
                CurrentDilithiumTotal -= ship.DilithiumCostPerTurn;
            }

            if (CurrentDilithiumTotal < 0) {
                CurrentDilithiumTotal = 0;

                EventSummary.Add(new BaseEvent { 
                    Description = "You are out of Dilithium - ships cannot move",
                    EventIconImageString = "/Assets/Misc/UFPLogo.png"
                });
            }

            for (var x = 0; x < ConstructionItems.Count; x++) {
                var constructionItem = ConstructionItems[x];

                constructionItem.TurnsRemaining--;

                ConstructionItems[x] = constructionItem;

                if (ConstructionItems[x].TurnsRemaining != 0) {
                    continue;
                }

                switch (ConstructionItems[x].Object.ObjectType) {
                    case BaseObject.OBJECT.SHIP:
                        EventSummary.Add(new BaseEvent {
                            Description = String.Format("{0} has been built", ConstructionItems[x].Object.Description),
                            EventIconImageString = ConstructionItems[x].Object.TextureName
                        });

                        Ships.Add((BaseShip)ConstructionItems[x].Object);
                        break;
                    case BaseObject.OBJECT.PLANET:
                        break;
                }

                ConstructionItems.RemoveAt(x);
            }

            for (var x = 0; x < ResearchItems.Count; x++) {
                var researchItem = ResearchItems[x];

                researchItem.TurnsRemaining--;

                ResearchItems[x] = researchItem;

                if (ResearchItems[x].TurnsRemaining != 0) {
                    continue;
                }

                EventSummary.Add(new BaseEvent {
                    Description = String.Format("{0} research is complete", ResearchItems[x].Object.Description),
                    EventIconImageString = ResearchItems[x].Object.TextureName
                });

                ResearchItems.RemoveAt(x);
            }

            GalaxyPlanets.Clear();

            foreach (var plant in Planets) {
                GalaxyPlanets.Add(new GalaxyPlanet {PlanetObject = plant, Race = BaseObject.RACE.FEDERATION});
            }
        }
    }
}