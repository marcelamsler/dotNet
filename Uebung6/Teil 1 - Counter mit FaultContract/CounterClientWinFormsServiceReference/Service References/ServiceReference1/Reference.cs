﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36323
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CounterClientWinFormsServiceReference.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CounterState", Namespace="http://schemas.datacontract.org/2004/07/CounterServiceCommon")]
    [System.SerializableAttribute()]
    public partial class CounterState : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CounterIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxCountValueField;
        
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
        public int CountValue {
            get {
                return this.CountValueField;
            }
            set {
                if ((this.CountValueField.Equals(value) != true)) {
                    this.CountValueField = value;
                    this.RaisePropertyChanged("CountValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CounterId {
            get {
                return this.CounterIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CounterIdField, value) != true)) {
                    this.CounterIdField = value;
                    this.RaisePropertyChanged("CounterId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxCountValue {
            get {
                return this.MaxCountValueField;
            }
            set {
                if ((this.MaxCountValueField.Equals(value) != true)) {
                    this.MaxCountValueField = value;
                    this.RaisePropertyChanged("MaxCountValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CounterFaultContract", Namespace="http://schemas.datacontract.org/2004/07/CounterServiceCommon")]
    [System.SerializableAttribute()]
    public partial class CounterFaultContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public int CountValue {
            get {
                return this.CountValueField;
            }
            set {
                if ((this.CountValueField.Equals(value) != true)) {
                    this.CountValueField = value;
                    this.RaisePropertyChanged("CountValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICounterService")]
    public interface ICounterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/get_CountValue", ReplyAction="http://tempuri.org/ICounterService/get_CountValueResponse")]
        int get_CountValue();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/set_CountValue", ReplyAction="http://tempuri.org/ICounterService/set_CountValueResponse")]
        void set_CountValue(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/get_MaxCountValue", ReplyAction="http://tempuri.org/ICounterService/get_MaxCountValueResponse")]
        int get_MaxCountValue();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/set_MaxCountValue", ReplyAction="http://tempuri.org/ICounterService/set_MaxCountValueResponse")]
        void set_MaxCountValue(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/get_CounterId", ReplyAction="http://tempuri.org/ICounterService/get_CounterIdResponse")]
        string get_CounterId();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/set_CounterId", ReplyAction="http://tempuri.org/ICounterService/set_CounterIdResponse")]
        void set_CounterId(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/get_CounterState", ReplyAction="http://tempuri.org/ICounterService/get_CounterStateResponse")]
        CounterClientWinFormsServiceReference.ServiceReference1.CounterState get_CounterState();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/set_CounterState", ReplyAction="http://tempuri.org/ICounterService/set_CounterStateResponse")]
        void set_CounterState(CounterClientWinFormsServiceReference.ServiceReference1.CounterState value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/increment", ReplyAction="http://tempuri.org/ICounterService/incrementResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(CounterClientWinFormsServiceReference.ServiceReference1.CounterFaultContract), Action="http://tempuri.org/ICounterService/incrementCounterFaultContractFault", Name="CounterFaultContract", Namespace="http://schemas.datacontract.org/2004/07/CounterServiceCommon")]
        void increment();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/decrement", ReplyAction="http://tempuri.org/ICounterService/decrementResponse")]
        void decrement();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICounterServiceChannel : CounterClientWinFormsServiceReference.ServiceReference1.ICounterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CounterServiceClient : System.ServiceModel.ClientBase<CounterClientWinFormsServiceReference.ServiceReference1.ICounterService>, CounterClientWinFormsServiceReference.ServiceReference1.ICounterService {
        
        public CounterServiceClient() {
        }
        
        public CounterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CounterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CounterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CounterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int get_CountValue() {
            return base.Channel.get_CountValue();
        }
        
        public void set_CountValue(int value) {
            base.Channel.set_CountValue(value);
        }
        
        public int get_MaxCountValue() {
            return base.Channel.get_MaxCountValue();
        }
        
        public void set_MaxCountValue(int value) {
            base.Channel.set_MaxCountValue(value);
        }
        
        public string get_CounterId() {
            return base.Channel.get_CounterId();
        }
        
        public void set_CounterId(string value) {
            base.Channel.set_CounterId(value);
        }
        
        public CounterClientWinFormsServiceReference.ServiceReference1.CounterState get_CounterState() {
            return base.Channel.get_CounterState();
        }
        
        public void set_CounterState(CounterClientWinFormsServiceReference.ServiceReference1.CounterState value) {
            base.Channel.set_CounterState(value);
        }
        
        public void increment() {
            base.Channel.increment();
        }
        
        public void decrement() {
            base.Channel.decrement();
        }
    }
}
