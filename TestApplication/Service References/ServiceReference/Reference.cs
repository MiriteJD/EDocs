﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestApplication.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Dossier", Namespace="http://schemas.datacontract.org/2004/07/Server.Model")]
    [System.SerializableAttribute()]
    public partial class Dossier : TestApplication.ServiceReference.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CounterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDateField;
        
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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestApplication.ServiceReference.Document))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestApplication.ServiceReference.Keyword))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestApplication.ServiceReference.Dossier))]
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
    public partial class Document : TestApplication.ServiceReference.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DossierIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FilenameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestApplication.ServiceReference.Keyword[] KeywordsField;
        
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
        public TestApplication.ServiceReference.Keyword[] Keywords {
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
    public partial class Keyword : TestApplication.ServiceReference.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IDocumentService")]
    public interface IDocumentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllDossiers", ReplyAction="http://tempuri.org/IDocumentService/GetAllDossiersResponse")]
        TestApplication.ServiceReference.Dossier[] GetAllDossiers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllDossiers", ReplyAction="http://tempuri.org/IDocumentService/GetAllDossiersResponse")]
        System.Threading.Tasks.Task<TestApplication.ServiceReference.Dossier[]> GetAllDossiersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddNewDossier", ReplyAction="http://tempuri.org/IDocumentService/AddNewDossierResponse")]
        TestApplication.ServiceReference.Dossier AddNewDossier();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddNewDossier", ReplyAction="http://tempuri.org/IDocumentService/AddNewDossierResponse")]
        System.Threading.Tasks.Task<TestApplication.ServiceReference.Dossier> AddNewDossierAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditDossier", ReplyAction="http://tempuri.org/IDocumentService/EditDossierResponse")]
        TestApplication.ServiceReference.Dossier EditDossier(TestApplication.ServiceReference.Dossier dossier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditDossier", ReplyAction="http://tempuri.org/IDocumentService/EditDossierResponse")]
        System.Threading.Tasks.Task<TestApplication.ServiceReference.Dossier> EditDossierAsync(TestApplication.ServiceReference.Dossier dossier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteDossier", ReplyAction="http://tempuri.org/IDocumentService/DeleteDossierResponse")]
        bool DeleteDossier(TestApplication.ServiceReference.Dossier dossier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteDossier", ReplyAction="http://tempuri.org/IDocumentService/DeleteDossierResponse")]
        System.Threading.Tasks.Task<bool> DeleteDossierAsync(TestApplication.ServiceReference.Dossier dossier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddDocumentToDossier", ReplyAction="http://tempuri.org/IDocumentService/AddDocumentToDossierResponse")]
        TestApplication.ServiceReference.Document AddDocumentToDossier(TestApplication.ServiceReference.Dossier dossier, TestApplication.ServiceReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddDocumentToDossier", ReplyAction="http://tempuri.org/IDocumentService/AddDocumentToDossierResponse")]
        System.Threading.Tasks.Task<TestApplication.ServiceReference.Document> AddDocumentToDossierAsync(TestApplication.ServiceReference.Dossier dossier, TestApplication.ServiceReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditDocument", ReplyAction="http://tempuri.org/IDocumentService/EditDocumentResponse")]
        TestApplication.ServiceReference.Document EditDocument(TestApplication.ServiceReference.Dossier dossier, TestApplication.ServiceReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditDocument", ReplyAction="http://tempuri.org/IDocumentService/EditDocumentResponse")]
        System.Threading.Tasks.Task<TestApplication.ServiceReference.Document> EditDocumentAsync(TestApplication.ServiceReference.Dossier dossier, TestApplication.ServiceReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteDocument", ReplyAction="http://tempuri.org/IDocumentService/DeleteDocumentResponse")]
        bool DeleteDocument(TestApplication.ServiceReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteDocument", ReplyAction="http://tempuri.org/IDocumentService/DeleteDocumentResponse")]
        System.Threading.Tasks.Task<bool> DeleteDocumentAsync(TestApplication.ServiceReference.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllKeywords", ReplyAction="http://tempuri.org/IDocumentService/GetAllKeywordsResponse")]
        TestApplication.ServiceReference.Keyword[] GetAllKeywords();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/GetAllKeywords", ReplyAction="http://tempuri.org/IDocumentService/GetAllKeywordsResponse")]
        System.Threading.Tasks.Task<TestApplication.ServiceReference.Keyword[]> GetAllKeywordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddNewKeyword", ReplyAction="http://tempuri.org/IDocumentService/AddNewKeywordResponse")]
        TestApplication.ServiceReference.Keyword AddNewKeyword(TestApplication.ServiceReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/AddNewKeyword", ReplyAction="http://tempuri.org/IDocumentService/AddNewKeywordResponse")]
        System.Threading.Tasks.Task<TestApplication.ServiceReference.Keyword> AddNewKeywordAsync(TestApplication.ServiceReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditKeyword", ReplyAction="http://tempuri.org/IDocumentService/EditKeywordResponse")]
        TestApplication.ServiceReference.Keyword EditKeyword(TestApplication.ServiceReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/EditKeyword", ReplyAction="http://tempuri.org/IDocumentService/EditKeywordResponse")]
        System.Threading.Tasks.Task<TestApplication.ServiceReference.Keyword> EditKeywordAsync(TestApplication.ServiceReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteKeyword", ReplyAction="http://tempuri.org/IDocumentService/DeleteKeywordResponse")]
        bool DeleteKeyword(TestApplication.ServiceReference.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/DeleteKeyword", ReplyAction="http://tempuri.org/IDocumentService/DeleteKeywordResponse")]
        System.Threading.Tasks.Task<bool> DeleteKeywordAsync(TestApplication.ServiceReference.Keyword keyword);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDocumentServiceChannel : TestApplication.ServiceReference.IDocumentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocumentServiceClient : System.ServiceModel.ClientBase<TestApplication.ServiceReference.IDocumentService>, TestApplication.ServiceReference.IDocumentService {
        
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
        
        public TestApplication.ServiceReference.Dossier[] GetAllDossiers() {
            return base.Channel.GetAllDossiers();
        }
        
        public System.Threading.Tasks.Task<TestApplication.ServiceReference.Dossier[]> GetAllDossiersAsync() {
            return base.Channel.GetAllDossiersAsync();
        }
        
        public TestApplication.ServiceReference.Dossier AddNewDossier() {
            return base.Channel.AddNewDossier();
        }
        
        public System.Threading.Tasks.Task<TestApplication.ServiceReference.Dossier> AddNewDossierAsync() {
            return base.Channel.AddNewDossierAsync();
        }
        
        public TestApplication.ServiceReference.Dossier EditDossier(TestApplication.ServiceReference.Dossier dossier) {
            return base.Channel.EditDossier(dossier);
        }
        
        public System.Threading.Tasks.Task<TestApplication.ServiceReference.Dossier> EditDossierAsync(TestApplication.ServiceReference.Dossier dossier) {
            return base.Channel.EditDossierAsync(dossier);
        }
        
        public bool DeleteDossier(TestApplication.ServiceReference.Dossier dossier) {
            return base.Channel.DeleteDossier(dossier);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteDossierAsync(TestApplication.ServiceReference.Dossier dossier) {
            return base.Channel.DeleteDossierAsync(dossier);
        }
        
        public TestApplication.ServiceReference.Document AddDocumentToDossier(TestApplication.ServiceReference.Dossier dossier, TestApplication.ServiceReference.Document document) {
            return base.Channel.AddDocumentToDossier(dossier, document);
        }
        
        public System.Threading.Tasks.Task<TestApplication.ServiceReference.Document> AddDocumentToDossierAsync(TestApplication.ServiceReference.Dossier dossier, TestApplication.ServiceReference.Document document) {
            return base.Channel.AddDocumentToDossierAsync(dossier, document);
        }
        
        public TestApplication.ServiceReference.Document EditDocument(TestApplication.ServiceReference.Dossier dossier, TestApplication.ServiceReference.Document document) {
            return base.Channel.EditDocument(dossier, document);
        }
        
        public System.Threading.Tasks.Task<TestApplication.ServiceReference.Document> EditDocumentAsync(TestApplication.ServiceReference.Dossier dossier, TestApplication.ServiceReference.Document document) {
            return base.Channel.EditDocumentAsync(dossier, document);
        }
        
        public bool DeleteDocument(TestApplication.ServiceReference.Document document) {
            return base.Channel.DeleteDocument(document);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteDocumentAsync(TestApplication.ServiceReference.Document document) {
            return base.Channel.DeleteDocumentAsync(document);
        }
        
        public TestApplication.ServiceReference.Keyword[] GetAllKeywords() {
            return base.Channel.GetAllKeywords();
        }
        
        public System.Threading.Tasks.Task<TestApplication.ServiceReference.Keyword[]> GetAllKeywordsAsync() {
            return base.Channel.GetAllKeywordsAsync();
        }
        
        public TestApplication.ServiceReference.Keyword AddNewKeyword(TestApplication.ServiceReference.Keyword keyword) {
            return base.Channel.AddNewKeyword(keyword);
        }
        
        public System.Threading.Tasks.Task<TestApplication.ServiceReference.Keyword> AddNewKeywordAsync(TestApplication.ServiceReference.Keyword keyword) {
            return base.Channel.AddNewKeywordAsync(keyword);
        }
        
        public TestApplication.ServiceReference.Keyword EditKeyword(TestApplication.ServiceReference.Keyword keyword) {
            return base.Channel.EditKeyword(keyword);
        }
        
        public System.Threading.Tasks.Task<TestApplication.ServiceReference.Keyword> EditKeywordAsync(TestApplication.ServiceReference.Keyword keyword) {
            return base.Channel.EditKeywordAsync(keyword);
        }
        
        public bool DeleteKeyword(TestApplication.ServiceReference.Keyword keyword) {
            return base.Channel.DeleteKeyword(keyword);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteKeywordAsync(TestApplication.ServiceReference.Keyword keyword) {
            return base.Channel.DeleteKeywordAsync(keyword);
        }
    }
}