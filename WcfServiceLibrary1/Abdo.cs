using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFProject
{
    [DataContract]
    public class Abdo
    {
        [DataMember]
        public string Name { get; set; }

        [OnDeserializing]
        public void OnDeserializing(StreamingContext context) { 
        }
    }
}
