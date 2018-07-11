using System;
using System.Runtime.Serialization;

namespace Federation.lib.Objects {
    [DataContract]
    public class Planets {
        [DataMember]
        public Guid ID { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public long Population { get; set; }

        [DataMember]
        public int LatinumPerTurn { get; set; }

        [DataMember]
        public int DilithiumPerTurn { get; set; }

        [DataMember]
        public int AlloyPerTurn { get; set; }

        [DataMember]
        public string PlanetTexture { get; set; }
    }
}