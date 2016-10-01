using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Server.Model
{
    [DataContract]
    public class Dossier : BaseModel
    {
        [DataMember]
        public string Nr { get; set; }

        [DataMember]
        public int Counter { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Comment { get; set; }

        [DataMember]
        public DateTime CreationDate { get; set; }

        [DataMember]
        public IList<Document> Documents { get; set; } = new List<Document>();

        public void AddDocument(Document document)
        {
            if (Documents == null)
            {
                Documents = new List<Document>();
            }
            Documents.Add(document);

            var newList = new List<Document>();
            foreach (var doc in Documents)
            {
                doc.DossierId = this.Id;
                newList.Add(doc);
            }
            Documents = newList;
        }
    }
}
