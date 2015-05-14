using System.Runtime.Serialization;

namespace Federation.PCL.Objects.Ships {
    [DataContract]
    public class Federation_Reliant : BaseShip {
        [DataMember]
        public override RACE RaceType {
            get { return RACE.FEDERATION; }
        }

        [DataMember]
        public override int Attack {
            get { return 3; }
        }

        [DataMember]
        public override int Defense {
            get { return 2; }
        }

        [DataMember]
        public override int DilithiumCostPerTurn {
            get { return 3; }
        }

        [DataMember]
        public override string Description { get { return "Reliant Class"; } }

        [DataMember]
        public override string TextureName {
            get { return GetTextureName("Reliant"); }
        }
    }
}