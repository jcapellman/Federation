using System;
using System.Runtime.Serialization;

namespace Federation.Objects {
    [DataContract]
    public class Game {
        [DataMember]
        public string Description { get; set; }

        [DataMember]

        [DataMember]
        public string PlayerName { get; set; }

        [DataMember]
        public int TurnNumber { get; set; }

        [DataMember]
        public int CurrentYear { get; set; }
        
    }
}
