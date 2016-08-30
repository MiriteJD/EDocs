using System.Runtime.Serialization;

namespace Server.Model
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Version { get; set; }
    }
}





