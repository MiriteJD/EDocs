using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Server.Model;

namespace Server
{
    using System;
    public class DocumentService : IDocumentService
    {

        private readonly DossierRepository _dossierRepository;

        private readonly DocumentRepository _documentRepository;

        private readonly KeywordRepository _keywordRepository;

        public DocumentService()
        {
            var relativePath = @"Database\DocManager.db3";
            //
            string currentPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            var absolutePath = Path.Combine(currentPath, relativePath);

            _dossierRepository = new DossierRepository(absolutePath);
            _documentRepository = new DocumentRepository(absolutePath);
            _keywordRepository = new KeywordRepository(absolutePath);
        }

        #region DOSSIERS
        public IList<Dossier> GetAllDossiers()
        {
            try
            {
                return _dossierRepository.GetAll();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
            return new List<Dossier>();
        }

        public Dossier GetDossierbyId(int id)
        {
            try
            {
                return _dossierRepository.GetById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return new Dossier();
        }

        public Dossier AddNewDossier(Dossier akte)
        {
            try
            {
                var counter = GetMaxCounterNumber() + 1;
                var year = DateTime.Now.Year;
                var dossier = new Dossier()
                {
                    CreationDate = DateTime.Now,
                    Name = akte.Name,
                    Year = year,
                    Nr = counter + @"/" + year,
                    Counter = counter
                };
                return _dossierRepository.Save(dossier);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }

        }

        public int GetMaxCounterNumber()
        {
            try
            {
                var allDossiers = GetAllDossiers();
                var counter = 0;
                if (allDossiers.Count == counter) return counter;
                foreach (var dos in allDossiers)
                {
                    if (dos.Year == DateTime.Now.Year && dos.Counter > counter)
                    {
                        counter = dos.Counter;
                    }
                }
                return counter;
                //using (var session = NHibernateHelper.OpenSession())
                //{
                //    maxcreationDate = session.CreateCriteria<Dossier>()
                //        .SetProjection(Projections.ProjectionList()
                //        .Add(Projections.Max("Year")));

                //    maxvalue = session.CreateCriteria<Dossier>()
                //        .SetProjection(Projections.ProjectionList()
                //            .Add(Projections.Max("Year")))
                //            .Add(Restrictions.EqProperty(
                //                Projections.Max("Counter"),
                //                Projections.Property("outer.Year")))         // compare inner MAX with outer current
                //            .Add(Restrictions.EqProperty("Year", "outer.Year"));    // inner and outer must fit
                //}
                //return maxvalue == null ? 1 : Convert.ToInt32(maxvalue);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                return -1;
            }
        }

        public Dossier EditDossier(Dossier dossier, string name, string comment)
        {
            try
            {
                dossier.Version++;
                dossier.Name = name;
                dossier.Comment = comment;
                foreach (var doc in dossier.Documents)
                {
                    doc.DossierId = dossier.Id;
                }
                return _dossierRepository.Update(dossier);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Dossier();
        }

        public bool DeleteDossier(Dossier dossier)
        {
            try
            {
                return _dossierRepository.Delete(dossier);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return false;
            }
        }
        #endregion

        #region DOCS

        public IList<Document> GetAllDocuments()
        {
            try
            {
                return _documentRepository.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public Document AddDocumentToDossier(Dossier dossier, Document document)
        {
            try
            {
                dossier.AddDocument(document);
                _dossierRepository.Update(dossier);
                return document;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Document();
        }

        public Document EditDocument(Dossier dossier, Document doc)
        {
            try
            {
                doc.DossierId = dossier.Id;
                return _documentRepository.Update(doc);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Document();
        }

        public bool DeleteDocument(Document doc)
        {
            try
            {
                return _documentRepository.Delete(doc);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return false;
            }
        }

        public IList<Document> GetAllDocumentsByDosId(int dosId)
        {
            try
            {
                var targetedDocs = new List<Document>();
                var documents = _documentRepository.GetAll();
                foreach (Document doc in documents)
                {
                    if (doc.DossierId == dosId) targetedDocs.Add(doc);
                }
                return targetedDocs;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new List<Document>();
        }

        #endregion

        #region KEYWORDS
        public IList<Keyword> GetAllKeywords()
        {
            try
            {
                return _keywordRepository.GetAll();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new List<Keyword>();
        }

        public Keyword AddNewKeyword(Keyword keyword)
        {
            try
            {
                return _keywordRepository.Save(keyword);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Keyword();
        }

        public Keyword EditKeyword(Keyword keyword)
        {
            try
            {
                return _keywordRepository.Update(keyword);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Keyword();

        }

        public bool DeleteKeyword(Keyword keyword)
        {
            try
            {
                return _keywordRepository.Delete(keyword);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return false;
            }
        }

        public IList<Keyword> GetAllKeywordsByDocId(int docId)
        {
            try
            {
                var targetedKWs = new List<Keyword>();
                var keywords = _keywordRepository.GetAll();
                foreach (Keyword kw in keywords)
                {
                    foreach (var doc in kw.Documents)
                    {
                        if (doc.Id == docId) targetedKWs.Add(kw);
                    }
                }

                return targetedKWs;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new List<Keyword>();
        }

        public Keyword GetKeywordbyId(int id)
        {
            try
            {
                return _keywordRepository.GetById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return new Keyword();
        }

        #endregion
    }
}
