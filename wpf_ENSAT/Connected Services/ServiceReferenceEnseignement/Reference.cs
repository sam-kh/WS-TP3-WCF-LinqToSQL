﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpf_ENSAT.ServiceReferenceEnseignement {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Eleve", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Eleve : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CNEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_EleveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private wpf_ENSAT.ServiceReferenceEnseignement.Binary PhotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrenomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelField;
        
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
        public string CNE {
            get {
                return this.CNEField;
            }
            set {
                if ((object.ReferenceEquals(this.CNEField, value) != true)) {
                    this.CNEField = value;
                    this.RaisePropertyChanged("CNE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Eleve {
            get {
                return this.ID_EleveField;
            }
            set {
                if ((this.ID_EleveField.Equals(value) != true)) {
                    this.ID_EleveField = value;
                    this.RaisePropertyChanged("ID_Eleve");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public wpf_ENSAT.ServiceReferenceEnseignement.Binary Photo {
            get {
                return this.PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoField, value) != true)) {
                    this.PhotoField = value;
                    this.RaisePropertyChanged("Photo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom {
            get {
                return this.PrenomField;
            }
            set {
                if ((object.ReferenceEquals(this.PrenomField, value) != true)) {
                    this.PrenomField = value;
                    this.RaisePropertyChanged("Prenom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tel {
            get {
                return this.TelField;
            }
            set {
                if ((object.ReferenceEquals(this.TelField, value) != true)) {
                    this.TelField = value;
                    this.RaisePropertyChanged("Tel");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Binary", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Linq")]
    [System.SerializableAttribute()]
    public partial class Binary : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] BytesField;
        
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
        public byte[] Bytes {
            get {
                return this.BytesField;
            }
            set {
                if ((object.ReferenceEquals(this.BytesField, value) != true)) {
                    this.BytesField = value;
                    this.RaisePropertyChanged("Bytes");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceEnseignement.IServiceEnseignement")]
    public interface IServiceEnseignement {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEnseignement/getByCNE", ReplyAction="http://tempuri.org/IServiceEnseignement/getByCNEResponse")]
        wpf_ENSAT.ServiceReferenceEnseignement.Eleve[] getByCNE(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEnseignement/getByCNE", ReplyAction="http://tempuri.org/IServiceEnseignement/getByCNEResponse")]
        System.Threading.Tasks.Task<wpf_ENSAT.ServiceReferenceEnseignement.Eleve[]> getByCNEAsync(string s);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceEnseignementChannel : wpf_ENSAT.ServiceReferenceEnseignement.IServiceEnseignement, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceEnseignementClient : System.ServiceModel.ClientBase<wpf_ENSAT.ServiceReferenceEnseignement.IServiceEnseignement>, wpf_ENSAT.ServiceReferenceEnseignement.IServiceEnseignement {
        
        public ServiceEnseignementClient() {
        }
        
        public ServiceEnseignementClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceEnseignementClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEnseignementClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEnseignementClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public wpf_ENSAT.ServiceReferenceEnseignement.Eleve[] getByCNE(string s) {
            return base.Channel.getByCNE(s);
        }
        
        public System.Threading.Tasks.Task<wpf_ENSAT.ServiceReferenceEnseignement.Eleve[]> getByCNEAsync(string s) {
            return base.Channel.getByCNEAsync(s);
        }
    }
}
