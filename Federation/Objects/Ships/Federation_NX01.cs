using System.Runtime.Serialization;

namespace Federation.Objects.Ships {
    [DataContract]
    public class Federation_NX01 : BaseShip {
        [DataMember]
        public override RACE RaceType {
            get { return RACE.FEDERATION; }
        }

        [DataMember]
        public override string Description { get { return "NX01 Class"; } }

        [DataMember]
        public override string TextureName {
            get { return getTextureName("NX01"); }
        }
    }
}