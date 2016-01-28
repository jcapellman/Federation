using System.Runtime.Serialization;

namespace Federation.PCL.Objects.Ships {
    [DataContract]
    public class Federation_ConstitutionRefit : BaseShip {
        [DataMember]
        public override RACE RaceType => RACE.FEDERATION;

        [DataMember]
        public override int Attack => 2;

        [DataMember]
        public override int Defense => 3;

        [DataMember]
        public override int DilithiumCostPerTurn => 3;

        [DataMember]
        public override string Description => "Constituion (Refit) Class";

        [DataMember]
        public override string TextureName => GetTextureName("ConstitutionRefit");
    }
}