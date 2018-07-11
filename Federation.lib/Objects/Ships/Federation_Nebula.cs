using System.Runtime.Serialization;

namespace Federation.lib.Objects.Ships {
    [DataContract]
    public class Federation_Nebula : BaseShip {
        [DataMember]
        public override RACE RaceType {
            get { return RACE.FEDERATION; }
        }


        [DataMember]
        public override int Attack {
            get { return 7; }
        }

        [DataMember]
        public override int Defense {
            get { return 5; }
        }

        [DataMember]
        public override int DilithiumCostPerTurn {
            get { return 7; }
        }
    
        [DataMember]
        public override string Description { get { return "Nebula Class"; } }

        [DataMember]
        public override string TextureName {
            get { return GetTextureName("Nebula"); }
        }
    }
}