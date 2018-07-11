using System.Runtime.Serialization;

namespace Federation.lib.Objects.Ships {
    [DataContract]
    public class Federation_Runabout : BaseShip {
        [DataMember]
        public override RACE RaceType {
            get { return RACE.FEDERATION; }
        }


        [DataMember]
        public override int Attack {
            get { return 1; }
        }

        [DataMember]
        public override int Defense {
            get { return 1; }
        }

        [DataMember]
        public override int DilithiumCostPerTurn {
            get { return 1; }
        }

        [DataMember]
        public override string Description { get { return "Runabout"; } }

        [DataMember]
        public override string TextureName {
            get { return GetTextureName("Runabout"); }
        }
    }
}