﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Serwer {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pokoj", Namespace="http://schemas.datacontract.org/2004/07/HotelService")]
    [System.SerializableAttribute()]
    public partial class Pokoj : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LiczbaOsobField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OpisField;
        
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
        public int LiczbaOsob {
            get {
                return this.LiczbaOsobField;
            }
            set {
                if ((this.LiczbaOsobField.Equals(value) != true)) {
                    this.LiczbaOsobField = value;
                    this.RaisePropertyChanged("LiczbaOsob");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Opis {
            get {
                return this.OpisField;
            }
            set {
                if ((object.ReferenceEquals(this.OpisField, value) != true)) {
                    this.OpisField = value;
                    this.RaisePropertyChanged("Opis");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Rezerwacja", Namespace="http://schemas.datacontract.org/2004/07/HotelService")]
    [System.SerializableAttribute()]
    public partial class Rezerwacja : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AkceptacjaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LiczbaOsobField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazwiskoField;
        
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
        public bool Akceptacja {
            get {
                return this.AkceptacjaField;
            }
            set {
                if ((this.AkceptacjaField.Equals(value) != true)) {
                    this.AkceptacjaField = value;
                    this.RaisePropertyChanged("Akceptacja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data {
            get {
                return this.DataField;
            }
            set {
                if ((this.DataField.Equals(value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LiczbaOsob {
            get {
                return this.LiczbaOsobField;
            }
            set {
                if ((this.LiczbaOsobField.Equals(value) != true)) {
                    this.LiczbaOsobField = value;
                    this.RaisePropertyChanged("LiczbaOsob");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nazwisko {
            get {
                return this.NazwiskoField;
            }
            set {
                if ((object.ReferenceEquals(this.NazwiskoField, value) != true)) {
                    this.NazwiskoField = value;
                    this.RaisePropertyChanged("Nazwisko");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Serwer.IHotelService")]
    public interface IHotelService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/WolnePokoje", ReplyAction="http://tempuri.org/IHotelService/WolnePokojeResponse")]
        WebApplication1.Serwer.Pokoj[] WolnePokoje(System.DateTime data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/WolnePokoje", ReplyAction="http://tempuri.org/IHotelService/WolnePokojeResponse")]
        System.Threading.Tasks.Task<WebApplication1.Serwer.Pokoj[]> WolnePokojeAsync(System.DateTime data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/RezerwujPokoj", ReplyAction="http://tempuri.org/IHotelService/RezerwujPokojResponse")]
        WebApplication1.Serwer.Rezerwacja RezerwujPokoj(WebApplication1.Serwer.Rezerwacja dane);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/RezerwujPokoj", ReplyAction="http://tempuri.org/IHotelService/RezerwujPokojResponse")]
        System.Threading.Tasks.Task<WebApplication1.Serwer.Rezerwacja> RezerwujPokojAsync(WebApplication1.Serwer.Rezerwacja dane);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHotelServiceChannel : WebApplication1.Serwer.IHotelService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HotelServiceClient : System.ServiceModel.ClientBase<WebApplication1.Serwer.IHotelService>, WebApplication1.Serwer.IHotelService {
        
        public HotelServiceClient() {
        }
        
        public HotelServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication1.Serwer.Pokoj[] WolnePokoje(System.DateTime data) {
            return base.Channel.WolnePokoje(data);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.Serwer.Pokoj[]> WolnePokojeAsync(System.DateTime data) {
            return base.Channel.WolnePokojeAsync(data);
        }
        
        public WebApplication1.Serwer.Rezerwacja RezerwujPokoj(WebApplication1.Serwer.Rezerwacja dane) {
            return base.Channel.RezerwujPokoj(dane);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.Serwer.Rezerwacja> RezerwujPokojAsync(WebApplication1.Serwer.Rezerwacja dane) {
            return base.Channel.RezerwujPokojAsync(dane);
        }
    }
}