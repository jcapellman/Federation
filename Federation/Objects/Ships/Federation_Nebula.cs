using System.Runtime.Serialization;

namespace Federation.Objects.Ships {
    [DataContract]
    public class Federation_Nebula : BaseShip {
        [DataMember]
        public override RACE RaceType {
            get { return RACE.FEDERATION; }
        }

        [DataMember]
        public override string Description { get { return "Nebula Class"; } }

        [DataMember]
        public override string TextureName {
            get { return getTextureName("Nebula"); }
        }
    }
}