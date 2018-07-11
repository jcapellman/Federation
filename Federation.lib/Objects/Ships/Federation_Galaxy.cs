using System.Runtime.Serialization;

namespace Federation.lib.Objects.Ships {
    [DataContract]
    public class Federation_Galaxy : BaseShip {
        [DataMember]
        public override RACE RaceType => RACE.FEDERATION;

        [DataMember]
        public override int Attack => 8;

        [DataMember]
        public override int Defense => 6;

        [DataMember]
        public override int DilithiumCostPerTurn => 8;

        [DataMember]
        public override string Description => "Galaxy Class";

        [DataMember]
        public override string TextureName => GetTextureName("Galaxy");
    }
}