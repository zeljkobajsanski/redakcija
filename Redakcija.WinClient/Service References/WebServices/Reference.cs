﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Redakcija.WinClient.WebServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Clanak", Namespace="http://schemas.datacontract.org/2004/07/Redakcija.Web.Models")]
    [System.SerializableAttribute()]
    public partial class Clanak : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DatumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KreatorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NaslovField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PublikacijaIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] RawField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RubrikaIDField;
        
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
        public System.DateTime Datum {
            get {
                return this.DatumField;
            }
            set {
                if ((this.DatumField.Equals(value) != true)) {
                    this.DatumField = value;
                    this.RaisePropertyChanged("Datum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int KreatorID {
            get {
                return this.KreatorIDField;
            }
            set {
                if ((this.KreatorIDField.Equals(value) != true)) {
                    this.KreatorIDField = value;
                    this.RaisePropertyChanged("KreatorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Naslov {
            get {
                return this.NaslovField;
            }
            set {
                if ((object.ReferenceEquals(this.NaslovField, value) != true)) {
                    this.NaslovField = value;
                    this.RaisePropertyChanged("Naslov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PublikacijaID {
            get {
                return this.PublikacijaIDField;
            }
            set {
                if ((this.PublikacijaIDField.Equals(value) != true)) {
                    this.PublikacijaIDField = value;
                    this.RaisePropertyChanged("PublikacijaID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Raw {
            get {
                return this.RawField;
            }
            set {
                if ((object.ReferenceEquals(this.RawField, value) != true)) {
                    this.RawField = value;
                    this.RaisePropertyChanged("Raw");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RubrikaID {
            get {
                return this.RubrikaIDField;
            }
            set {
                if ((this.RubrikaIDField.Equals(value) != true)) {
                    this.RubrikaIDField = value;
                    this.RaisePropertyChanged("RubrikaID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Publikacija", Namespace="http://schemas.datacontract.org/2004/07/Redakcija.Web.Models")]
    [System.SerializableAttribute()]
    public partial class Publikacija : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Redakcija.WinClient.WebServices.Rubrika> RubrikeField;
        
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
        public string Naziv {
            get {
                return this.NazivField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivField, value) != true)) {
                    this.NazivField = value;
                    this.RaisePropertyChanged("Naziv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Redakcija.WinClient.WebServices.Rubrika> Rubrike {
            get {
                return this.RubrikeField;
            }
            set {
                if ((object.ReferenceEquals(this.RubrikeField, value) != true)) {
                    this.RubrikeField = value;
                    this.RaisePropertyChanged("Rubrike");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Rubrika", Namespace="http://schemas.datacontract.org/2004/07/Redakcija.Web.Models")]
    [System.SerializableAttribute()]
    public partial class Rubrika : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivField;
        
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
        public string Naziv {
            get {
                return this.NazivField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivField, value) != true)) {
                    this.NazivField = value;
                    this.RaisePropertyChanged("Naziv");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://zeks.co.uk/redakcija", ConfigurationName="WebServices.TestService")]
    public interface TestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zeks.co.uk/redakcija/TestService/PosaljiClanak", ReplyAction="http://zeks.co.uk/redakcija/TestService/PosaljiClanakResponse")]
        void PosaljiClanak(Redakcija.WinClient.WebServices.Clanak clanak);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://zeks.co.uk/redakcija/TestService/PosaljiClanak", ReplyAction="http://zeks.co.uk/redakcija/TestService/PosaljiClanakResponse")]
        System.IAsyncResult BeginPosaljiClanak(Redakcija.WinClient.WebServices.Clanak clanak, System.AsyncCallback callback, object asyncState);
        
        void EndPosaljiClanak(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zeks.co.uk/redakcija/TestService/VratiPublikacije", ReplyAction="http://zeks.co.uk/redakcija/TestService/VratiPublikacijeResponse")]
        System.Collections.Generic.List<Redakcija.WinClient.WebServices.Publikacija> VratiPublikacije();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://zeks.co.uk/redakcija/TestService/VratiPublikacije", ReplyAction="http://zeks.co.uk/redakcija/TestService/VratiPublikacijeResponse")]
        System.IAsyncResult BeginVratiPublikacije(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<Redakcija.WinClient.WebServices.Publikacija> EndVratiPublikacije(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TestServiceChannel : Redakcija.WinClient.WebServices.TestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VratiPublikacijeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public VratiPublikacijeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<Redakcija.WinClient.WebServices.Publikacija> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<Redakcija.WinClient.WebServices.Publikacija>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestServiceClient : System.ServiceModel.ClientBase<Redakcija.WinClient.WebServices.TestService>, Redakcija.WinClient.WebServices.TestService {
        
        private BeginOperationDelegate onBeginPosaljiClanakDelegate;
        
        private EndOperationDelegate onEndPosaljiClanakDelegate;
        
        private System.Threading.SendOrPostCallback onPosaljiClanakCompletedDelegate;
        
        private BeginOperationDelegate onBeginVratiPublikacijeDelegate;
        
        private EndOperationDelegate onEndVratiPublikacijeDelegate;
        
        private System.Threading.SendOrPostCallback onVratiPublikacijeCompletedDelegate;
        
        public TestServiceClient() {
        }
        
        public TestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> PosaljiClanakCompleted;
        
        public event System.EventHandler<VratiPublikacijeCompletedEventArgs> VratiPublikacijeCompleted;
        
        public void PosaljiClanak(Redakcija.WinClient.WebServices.Clanak clanak) {
            base.Channel.PosaljiClanak(clanak);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginPosaljiClanak(Redakcija.WinClient.WebServices.Clanak clanak, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginPosaljiClanak(clanak, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndPosaljiClanak(System.IAsyncResult result) {
            base.Channel.EndPosaljiClanak(result);
        }
        
        private System.IAsyncResult OnBeginPosaljiClanak(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Redakcija.WinClient.WebServices.Clanak clanak = ((Redakcija.WinClient.WebServices.Clanak)(inValues[0]));
            return this.BeginPosaljiClanak(clanak, callback, asyncState);
        }
        
        private object[] OnEndPosaljiClanak(System.IAsyncResult result) {
            this.EndPosaljiClanak(result);
            return null;
        }
        
        private void OnPosaljiClanakCompleted(object state) {
            if ((this.PosaljiClanakCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.PosaljiClanakCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void PosaljiClanakAsync(Redakcija.WinClient.WebServices.Clanak clanak) {
            this.PosaljiClanakAsync(clanak, null);
        }
        
        public void PosaljiClanakAsync(Redakcija.WinClient.WebServices.Clanak clanak, object userState) {
            if ((this.onBeginPosaljiClanakDelegate == null)) {
                this.onBeginPosaljiClanakDelegate = new BeginOperationDelegate(this.OnBeginPosaljiClanak);
            }
            if ((this.onEndPosaljiClanakDelegate == null)) {
                this.onEndPosaljiClanakDelegate = new EndOperationDelegate(this.OnEndPosaljiClanak);
            }
            if ((this.onPosaljiClanakCompletedDelegate == null)) {
                this.onPosaljiClanakCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnPosaljiClanakCompleted);
            }
            base.InvokeAsync(this.onBeginPosaljiClanakDelegate, new object[] {
                        clanak}, this.onEndPosaljiClanakDelegate, this.onPosaljiClanakCompletedDelegate, userState);
        }
        
        public System.Collections.Generic.List<Redakcija.WinClient.WebServices.Publikacija> VratiPublikacije() {
            return base.Channel.VratiPublikacije();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginVratiPublikacije(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginVratiPublikacije(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.List<Redakcija.WinClient.WebServices.Publikacija> EndVratiPublikacije(System.IAsyncResult result) {
            return base.Channel.EndVratiPublikacije(result);
        }
        
        private System.IAsyncResult OnBeginVratiPublikacije(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginVratiPublikacije(callback, asyncState);
        }
        
        private object[] OnEndVratiPublikacije(System.IAsyncResult result) {
            System.Collections.Generic.List<Redakcija.WinClient.WebServices.Publikacija> retVal = this.EndVratiPublikacije(result);
            return new object[] {
                    retVal};
        }
        
        private void OnVratiPublikacijeCompleted(object state) {
            if ((this.VratiPublikacijeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.VratiPublikacijeCompleted(this, new VratiPublikacijeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void VratiPublikacijeAsync() {
            this.VratiPublikacijeAsync(null);
        }
        
        public void VratiPublikacijeAsync(object userState) {
            if ((this.onBeginVratiPublikacijeDelegate == null)) {
                this.onBeginVratiPublikacijeDelegate = new BeginOperationDelegate(this.OnBeginVratiPublikacije);
            }
            if ((this.onEndVratiPublikacijeDelegate == null)) {
                this.onEndVratiPublikacijeDelegate = new EndOperationDelegate(this.OnEndVratiPublikacije);
            }
            if ((this.onVratiPublikacijeCompletedDelegate == null)) {
                this.onVratiPublikacijeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnVratiPublikacijeCompleted);
            }
            base.InvokeAsync(this.onBeginVratiPublikacijeDelegate, null, this.onEndVratiPublikacijeDelegate, this.onVratiPublikacijeCompletedDelegate, userState);
        }
    }
}
