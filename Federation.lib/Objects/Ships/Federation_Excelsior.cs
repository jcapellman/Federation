using System.Runtime.Serialization;

namespace Federation.lib.Objects.Ships {
    [DataContract]
    public class Federation_Excelsior : BaseShip {
        [DataMember]
        public override RACE RaceType => RACE.FEDERATION;


        [DataMember]
        public override int Attack => 4;

        [DataMember]
        public override int Defense => 4;

        [DataMember]
        public override int DilithiumCostPerTurn => 5;

        [DataMember]
        public override string Description => "Excelsior Class";

        [DataMember]
        public override string TextureName => GetTextureName("Excelsior");
    }
}