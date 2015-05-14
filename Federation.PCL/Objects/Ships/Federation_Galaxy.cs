using System.Runtime.Serialization;

namespace Federation.PCL.Objects.Ships {
    [DataContract]
    public class Federation_Galaxy : BaseShip {
        [DataMember]
        public override RACE RaceType {
            get { return RACE.FEDERATION; }
        }


        [DataMember]
        public override int Attack {
            get { return 8; }
        }

        [DataMember]
        public override int Defense {
            get { return 6; }
        }

        [DataMember]
        public override int DilithiumCostPerTurn {
            get { return 8; }
        }

        [DataMember]
        public override string Description { get { return "Galaxy Class"; } }

        [DataMember]
        public override string TextureName {
            get { return GetTextureName("Galaxy"); }
        }
    }
}