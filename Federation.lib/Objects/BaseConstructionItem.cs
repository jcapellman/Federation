using System.Runtime.Serialization;

namespace Federation.lib.Objects {
    [DataContract]
    public class BaseConstructionItem {
        [DataMember]
        public int TurnsRemaining { get; set; }

        [DataMember]
        public BaseObject Object { get; set; }
    }
}