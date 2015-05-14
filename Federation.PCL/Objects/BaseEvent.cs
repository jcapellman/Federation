using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Federation.PCL.Objects {
    [DataContract]
    public class BaseEvent {
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string EventIconImageString { get; set; }
    }
}