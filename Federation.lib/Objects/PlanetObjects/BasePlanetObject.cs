using System;
using System.Runtime.Serialization;

namespace Federation.lib.Objects.PlanetObjects {
    [DataContract]
    public class BasePlanetObject : BaseObject {
        public override int DilithiumCostPerTurn {
            get { throw new NotImplementedException(); }
        }

        public override string Description {
            get { throw new NotImplementedException(); }
        }

        public override string TextureName {
            get { throw new NotImplementedException(); }
        }

        [DataMember]
        public int InitialAlloyCost { get; set; }

        [DataMember]
        public int IntitialLatinumCost { get; set; }

        [DataMember]
        public int InititalDilithiumCost { get; set; }

        [DataMember]
        public int DilithiumProductionPerTurn { get; set; }

        public override int Defense {
            get { throw new NotImplementedException(); }
        }

        [DataMember]
        public int LatinumProductionPerTurn { get; set; }

        [DataMember]
        public int LatinumCostPerTurn { get; set; }

        [DataMember]
        public int AlloyProductionPerTurn { get; set; }

        [DataMember]
        public int AlloyCostPerTurn { get; set; }

        [DataMember]
        public int Research { get; set; }

        public override RACE RaceType {
            get { throw new NotImplementedException(); }
        }

        public override BaseObject.OBJECT ObjectType { get { return BaseObject.OBJECT.PLANET; } }

        public override int Attack {
            get { throw new NotImplementedException(); }
        }
    }
}