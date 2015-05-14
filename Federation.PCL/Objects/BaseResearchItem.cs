using System.Runtime.Serialization;

namespace Federation.PCL.Objects {
    [DataContract]
    public class BaseResearchItem {
        [DataMember]
        public int TurnsRemaining { get; set; }

        [DataMember]
        public BaseObject Object { get; set; }
    }
}