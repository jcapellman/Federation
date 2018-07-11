using System.Runtime.Serialization;

namespace Federation.lib.Objects {
    [DataContract]
    public class BaseEvent {
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string EventIconImageString { get; set; }
    }
}