using System.Runtime.Serialization;

namespace Federation.lib.Objects.Ships {
    [DataContract]
    public class Federation_NX01 : BaseShip {
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
            get { return 2; }
        }

        [DataMember]
        public override int DilithiumCostPerTurn {
            get { return 2; }
        }

        [DataMember]
        public override string Description { get { return "NX01 Class"; } }

        [DataMember]
        public override string TextureName {
            get { return GetTextureName("NX01"); }
        }
    }
}