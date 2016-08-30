using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server.Model;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDocumentService" in both code and config file together.
    [ServiceContract]
    public interface IDocumentService
    {
        [OperationContract]
        IList<Dossier> GetAllDossiers();

        [OperationContract]
        Dossier AddNewDossier();

        [OperationContract]
        Dossier ImportDossier(Dossier dossier);

        [OperationContract]
        Dossier EditDossier(Dossier dossier);

        [OperationContract]
        bool DeleteDossier(Dossier dossier);

        [OperationContract]
        Document AddDocumentToDossier(Dossier dossier, Document document);

        [OperationContract]
        Document EditDocument(Dossier dossier, Document document);

        [OperationContract]
        bool DeleteDocument(Document document);

        [OperationContract]
        IList<Keyword> GetAllKeywords();

        [OperationContract]
        Keyword AddNewKeyword(Keyword keyword);

        [OperationContract]
        Keyword EditKeyword(Keyword keyword);

        [OperationContract]
        bool DeleteKeyword(Keyword keyword);


    }
}
