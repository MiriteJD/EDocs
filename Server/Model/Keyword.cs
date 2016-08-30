using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Server.Model
{
    [DataContract]
    public class Keyword : BaseModel
    {
        [DataMember]
        public string Name { get; set; }

        public IList<Document> Documents { get; set; }

    }
}



