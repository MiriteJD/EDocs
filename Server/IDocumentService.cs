using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server.Model;

namespace Server
{
    [ServiceContract]
    public interface IDocumentService
    {
        #region DOSSIERS
        [OperationContract]
        IList<Dossier> GetAllDossiers();

        [OperationContract]
        Dossier AddNewDossier(Dossier dossier);

        [OperationContract]
        Dossier EditDossier(Dossier dossier, string name, string comment);

        [OperationContract]
        bool DeleteDossier(Dossier dossier);

        [OperationContract]
        Dossier GetDossierbyId(int dossierId);
        #endregion

        #region DOCUMENTS

        [OperationContract]
        Document AddDocumentToDossier(Dossier dossier, Document document);

        [OperationContract]
        Document EditDocument(Dossier dossier, Document document);

        [OperationContract]
        bool DeleteDocument(Document document);

        [OperationContract]
        IList<Document> GetAllDocuments();

        [OperationContract]
        IList<Document> GetAllDocumentsByDosId(int dosId);
        
        #endregion

        #region KEYWORDS
        [OperationContract]
        IList<Keyword> GetAllKeywords();

        [OperationContract]
        Keyword AddNewKeyword(Keyword keyword);

        [OperationContract]
        Keyword EditKeyword(Keyword keyword);

        [OperationContract]
        bool DeleteKeyword(Keyword keyword);

        [OperationContract]
        IList<Keyword> GetAllKeywordsByDocId(int docId);

        [OperationContract]
        Keyword GetKeywordbyId(int id);

        #endregion

    }
}
