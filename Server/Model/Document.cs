using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Server.Model
{
    [DataContract]
    public class Document:BaseModel
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Comment { get; set; }

        [DataMember]
        public DateTime  CreationDate { get; set; }

        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public string Filename { get; set; }

        [DataMember]
        public int DossierId { get; set; }

        public Dossier DossierList { get; set; }

        [DataMember]
        public IList<Keyword> Keywords { get; set; }




    }
}
