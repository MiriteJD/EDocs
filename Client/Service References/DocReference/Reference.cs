﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.DocReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Dossier", Namespace="http://schemas.datacontract.org/2004/07/Server.Model")]
    [System.SerializableAttribute()]
    public partial class Dossier : Client.DocReference.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CounterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.DocReference.Document[] DocumentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Counter {
            get {
                return this.CounterField;
            }
            set {
                if ((this.CounterField.Equals(value) != true)) {
                    this.CounterField = value;
                    this.RaisePropertyChanged("Counter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.DocReference.Document[] Documents {
            get {
                return this.DocumentsField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentsField, value) != true)) {
                    this.DocumentsField = value;
                    this.RaisePropertyChanged("Documents");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nr {
            get {
                return this.NrField;
            }
            set {
                if ((object.ReferenceEquals(this.NrField, value) != true)) {
                    this.NrField = value;
                    this.RaisePropertyChanged("Nr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseModel", Namespace="http://schemas.datacontract.org/2004/07/Server.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.DocReference.Document))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.DocReference.Keyword))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.DocReference.Dossier))]
    public partial class BaseModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VersionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Version {
            get {
                return this.VersionField;
            }
            set {
                if ((this.VersionField.Equals(value) != true)) {
                    this.VersionField = value;
                    this.RaisePropertyChanged("Version");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Document", Namespace="http://schemas.datacontract.org/2004/07/Server.Model")]
    [System.SerializableAttribute()]
    public partial class Document : Client.DocReference.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DossierIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FilenameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.DocReference.Keyword[] KeywordsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DossierId {
            get {
                return this.DossierIdField;
            }
            set {
                if ((this.DossierIdField.Equals(value) != true)) {
                    this.DossierIdField = value;
                    this.RaisePropertyChanged("DossierId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Filename {
            get {
                return this.FilenameField;
            }
            set {
                if ((object.ReferenceEquals(this.FilenameField, value) != true)) {
                    this.FilenameField = value;
                    this.RaisePropertyChanged("Filename");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.DocReference.Keyword[] Keywords {
            get {
                return this.KeywordsField;
            }
            set {
                if ((object.ReferenceEquals(this.KeywordsField, value) != true)) {
                    this.KeywordsField = value;
                    this.RaisePropertyChanged("Keywords");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path {
            get {
                return this.PathField;
            }
            set {
                if ((object.ReferenceEquals(this.PathField, value) != true)) {
                    this.PathField = value;
                    this.RaisePropertyChanged("Path");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Keyword", Namespace="http://schemas.datacontract.org/2004/07/Server.Model")]
    [System.SerializableAttribute()]
    public partial class Keyword : Client.DocReference.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DocReference.IDocumentService")]
    public interface IDocumentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllDossiers", ReplyAction="http://tempuri.org/IDocumentService/GetAllDossiersResponse")]
        Client.DocReference.Dossier[] GetAllDossiers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllDossiers", ReplyAction="http://tempuri.org/IDocumentService/GetAllDossiersResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Dossier[]> GetAllDossiersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddNewDossier", ReplyAction="http://tempuri.org/IDocumentService/AddNewDossierResponse")]
        Client.DocReference.Dossier AddNewDossier(Client.DocReference.Dossier dossier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddNewDossier", ReplyAction="http://tempuri.org/IDocumentService/AddNewDossierResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Dossier> AddNewDossierAsync(Client.DocReference.Dossier dossier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditDossier", ReplyAction="http://tempuri.org/IDocumentService/EditDossierResponse")]
        Client.DocReference.Dossier EditDossier(Client.DocReference.Dossier dossier, string name, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditDossier", ReplyAction="http://tempuri.org/IDocumentService/EditDossierResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Dossier> EditDossierAsync(Client.DocReference.Dossier dossier, string name, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteDossier", ReplyAction="http://tempuri.org/IDocumentService/DeleteDossierResponse")]
        bool DeleteDossier(Client.DocReference.Dossier dossier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteDossier", ReplyAction="http://tempuri.org/IDocumentService/DeleteDossierResponse")]
        System.Threading.Tasks.Task<bool> DeleteDossierAsync(Client.DocReference.Dossier dossier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetDossierbyId", ReplyAction="http://tempuri.org/IDocumentService/GetDossierbyIdResponse")]
        Client.DocReference.Dossier GetDossierbyId(int dossierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetDossierbyId", ReplyAction="http://tempuri.org/IDocumentService/GetDossierbyIdResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Dossier> GetDossierbyIdAsync(int dossierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddDocumentToDossier", ReplyAction="http://tempuri.org/IDocumentService/AddDocumentToDossierResponse")]
        Client.DocReference.Document AddDocumentToDossier(Client.DocReference.Dossier dossier, Client.DocReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddDocumentToDossier", ReplyAction="http://tempuri.org/IDocumentService/AddDocumentToDossierResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Document> AddDocumentToDossierAsync(Client.DocReference.Dossier dossier, Client.DocReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditDocument", ReplyAction="http://tempuri.org/IDocumentService/EditDocumentResponse")]
        Client.DocReference.Document EditDocument(Client.DocReference.Dossier dossier, Client.DocReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditDocument", ReplyAction="http://tempuri.org/IDocumentService/EditDocumentResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Document> EditDocumentAsync(Client.DocReference.Dossier dossier, Client.DocReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteDocument", ReplyAction="http://tempuri.org/IDocumentService/DeleteDocumentResponse")]
        bool DeleteDocument(Client.DocReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteDocument", ReplyAction="http://tempuri.org/IDocumentService/DeleteDocumentResponse")]
        System.Threading.Tasks.Task<bool> DeleteDocumentAsync(Client.DocReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllDocuments", ReplyAction="http://tempuri.org/IDocumentService/GetAllDocumentsResponse")]
        Client.DocReference.Document[] GetAllDocuments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllDocuments", ReplyAction="http://tempuri.org/IDocumentService/GetAllDocumentsResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Document[]> GetAllDocumentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllDocumentsByDosId", ReplyAction="http://tempuri.org/IDocumentService/GetAllDocumentsByDosIdResponse")]
        Client.DocReference.Document[] GetAllDocumentsByDosId(int dosId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllDocumentsByDosId", ReplyAction="http://tempuri.org/IDocumentService/GetAllDocumentsByDosIdResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Document[]> GetAllDocumentsByDosIdAsync(int dosId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllKeywords", ReplyAction="http://tempuri.org/IDocumentService/GetAllKeywordsResponse")]
        Client.DocReference.Keyword[] GetAllKeywords();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllKeywords", ReplyAction="http://tempuri.org/IDocumentService/GetAllKeywordsResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Keyword[]> GetAllKeywordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddNewKeyword", ReplyAction="http://tempuri.org/IDocumentService/AddNewKeywordResponse")]
        Client.DocReference.Keyword AddNewKeyword(Client.DocReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddNewKeyword", ReplyAction="http://tempuri.org/IDocumentService/AddNewKeywordResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Keyword> AddNewKeywordAsync(Client.DocReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditKeyword", ReplyAction="http://tempuri.org/IDocumentService/EditKeywordResponse")]
        Client.DocReference.Keyword EditKeyword(Client.DocReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditKeyword", ReplyAction="http://tempuri.org/IDocumentService/EditKeywordResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Keyword> EditKeywordAsync(Client.DocReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteKeyword", ReplyAction="http://tempuri.org/IDocumentService/DeleteKeywordResponse")]
        bool DeleteKeyword(Client.DocReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteKeyword", ReplyAction="http://tempuri.org/IDocumentService/DeleteKeywordResponse")]
        System.Threading.Tasks.Task<bool> DeleteKeywordAsync(Client.DocReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllKeywordsByDocId", ReplyAction="http://tempuri.org/IDocumentService/GetAllKeywordsByDocIdResponse")]
        Client.DocReference.Keyword[] GetAllKeywordsByDocId(int docId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllKeywordsByDocId", ReplyAction="http://tempuri.org/IDocumentService/GetAllKeywordsByDocIdResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Keyword[]> GetAllKeywordsByDocIdAsync(int docId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetKeywordbyId", ReplyAction="http://tempuri.org/IDocumentService/GetKeywordbyIdResponse")]
        Client.DocReference.Keyword GetKeywordbyId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetKeywordbyId", ReplyAction="http://tempuri.org/IDocumentService/GetKeywordbyIdResponse")]
        System.Threading.Tasks.Task<Client.DocReference.Keyword> GetKeywordbyIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDocumentServiceChannel : Client.DocReference.IDocumentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocumentServiceClient : System.ServiceModel.ClientBase<Client.DocReference.IDocumentService>, Client.DocReference.IDocumentService {
        
        public DocumentServiceClient() {
        }
        
        public DocumentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DocumentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.DocReference.Dossier[] GetAllDossiers() {
            return base.Channel.GetAllDossiers();
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Dossier[]> GetAllDossiersAsync() {
            return base.Channel.GetAllDossiersAsync();
        }
        
        public Client.DocReference.Dossier AddNewDossier(Client.DocReference.Dossier dossier) {
            return base.Channel.AddNewDossier(dossier);
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Dossier> AddNewDossierAsync(Client.DocReference.Dossier dossier) {
            return base.Channel.AddNewDossierAsync(dossier);
        }
        
        public Client.DocReference.Dossier EditDossier(Client.DocReference.Dossier dossier, string name, string comment) {
            return base.Channel.EditDossier(dossier, name, comment);
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Dossier> EditDossierAsync(Client.DocReference.Dossier dossier, string name, string comment) {
            return base.Channel.EditDossierAsync(dossier, name, comment);
        }
        
        public bool DeleteDossier(Client.DocReference.Dossier dossier) {
            return base.Channel.DeleteDossier(dossier);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteDossierAsync(Client.DocReference.Dossier dossier) {
            return base.Channel.DeleteDossierAsync(dossier);
        }
        
        public Client.DocReference.Dossier GetDossierbyId(int dossierId) {
            return base.Channel.GetDossierbyId(dossierId);
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Dossier> GetDossierbyIdAsync(int dossierId) {
            return base.Channel.GetDossierbyIdAsync(dossierId);
        }
        
        public Client.DocReference.Document AddDocumentToDossier(Client.DocReference.Dossier dossier, Client.DocReference.Document document) {
            return base.Channel.AddDocumentToDossier(dossier, document);
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Document> AddDocumentToDossierAsync(Client.DocReference.Dossier dossier, Client.DocReference.Document document) {
            return base.Channel.AddDocumentToDossierAsync(dossier, document);
        }
        
        public Client.DocReference.Document EditDocument(Client.DocReference.Dossier dossier, Client.DocReference.Document document) {
            return base.Channel.EditDocument(dossier, document);
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Document> EditDocumentAsync(Client.DocReference.Dossier dossier, Client.DocReference.Document document) {
            return base.Channel.EditDocumentAsync(dossier, document);
        }
        
        public bool DeleteDocument(Client.DocReference.Document document) {
            return base.Channel.DeleteDocument(document);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteDocumentAsync(Client.DocReference.Document document) {
            return base.Channel.DeleteDocumentAsync(document);
        }
        
        public Client.DocReference.Document[] GetAllDocuments() {
            return base.Channel.GetAllDocuments();
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Document[]> GetAllDocumentsAsync() {
            return base.Channel.GetAllDocumentsAsync();
        }
        
        public Client.DocReference.Document[] GetAllDocumentsByDosId(int dosId) {
            return base.Channel.GetAllDocumentsByDosId(dosId);
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Document[]> GetAllDocumentsByDosIdAsync(int dosId) {
            return base.Channel.GetAllDocumentsByDosIdAsync(dosId);
        }
        
        public Client.DocReference.Keyword[] GetAllKeywords() {
            return base.Channel.GetAllKeywords();
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Keyword[]> GetAllKeywordsAsync() {
            return base.Channel.GetAllKeywordsAsync();
        }
        
        public Client.DocReference.Keyword AddNewKeyword(Client.DocReference.Keyword keyword) {
            return base.Channel.AddNewKeyword(keyword);
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Keyword> AddNewKeywordAsync(Client.DocReference.Keyword keyword) {
            return base.Channel.AddNewKeywordAsync(keyword);
        }
        
        public Client.DocReference.Keyword EditKeyword(Client.DocReference.Keyword keyword) {
            return base.Channel.EditKeyword(keyword);
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Keyword> EditKeywordAsync(Client.DocReference.Keyword keyword) {
            return base.Channel.EditKeywordAsync(keyword);
        }
        
        public bool DeleteKeyword(Client.DocReference.Keyword keyword) {
            return base.Channel.DeleteKeyword(keyword);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteKeywordAsync(Client.DocReference.Keyword keyword) {
            return base.Channel.DeleteKeywordAsync(keyword);
        }
        
        public Client.DocReference.Keyword[] GetAllKeywordsByDocId(int docId) {
            return base.Channel.GetAllKeywordsByDocId(docId);
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Keyword[]> GetAllKeywordsByDocIdAsync(int docId) {
            return base.Channel.GetAllKeywordsByDocIdAsync(docId);
        }
        
        public Client.DocReference.Keyword GetKeywordbyId(int id) {
            return base.Channel.GetKeywordbyId(id);
        }
        
        public System.Threading.Tasks.Task<Client.DocReference.Keyword> GetKeywordbyIdAsync(int id) {
            return base.Channel.GetKeywordbyIdAsync(id);
        }
    }
}
