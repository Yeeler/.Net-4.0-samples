﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.20826.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrox.ProCSharp.WCF.RoomReservationService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StructuralObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wrox.ProCSharp.WCF.RoomReservationService.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wrox.ProCSharp.WCF.RoomReservationService.RoomReservation))]
    public partial class StructuralObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wrox.ProCSharp.WCF.RoomReservationService.RoomReservation))]
    public partial class EntityObject : Wrox.ProCSharp.WCF.RoomReservationService.StructuralObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Wrox.ProCSharp.WCF.RoomReservationService.EntityKey EntityKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Wrox.ProCSharp.WCF.RoomReservationService.EntityKey EntityKey {
            get {
                return this.EntityKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityKeyField, value) != true)) {
                    this.EntityKeyField = value;
                    this.RaisePropertyChanged("EntityKey");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomReservation", Namespace="http://schemas.datacontract.org/2004/07/Wrox.ProCSharp.WCF", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class RoomReservation : Wrox.ProCSharp.WCF.RoomReservationService.EntityObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EventField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contact {
            get {
                return this.ContactField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactField, value) != true)) {
                    this.ContactField = value;
                    this.RaisePropertyChanged("Contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event {
            get {
                return this.EventField;
            }
            set {
                if ((object.ReferenceEquals(this.EventField, value) != true)) {
                    this.EventField = value;
                    this.RaisePropertyChanged("Event");
                }
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
        public string RoomName {
            get {
                return this.RoomNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomNameField, value) != true)) {
                    this.RoomNameField = value;
                    this.RaisePropertyChanged("RoomName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityKey", Namespace="http://schemas.datacontract.org/2004/07/System.Data", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class EntityKey : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntityContainerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Wrox.ProCSharp.WCF.RoomReservationService.EntityKeyMember[] EntityKeyValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntitySetNameField;
        
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
        public string EntityContainerName {
            get {
                return this.EntityContainerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityContainerNameField, value) != true)) {
                    this.EntityContainerNameField = value;
                    this.RaisePropertyChanged("EntityContainerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Wrox.ProCSharp.WCF.RoomReservationService.EntityKeyMember[] EntityKeyValues {
            get {
                return this.EntityKeyValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityKeyValuesField, value) != true)) {
                    this.EntityKeyValuesField = value;
                    this.RaisePropertyChanged("EntityKeyValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntitySetName {
            get {
                return this.EntitySetNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntitySetNameField, value) != true)) {
                    this.EntitySetNameField = value;
                    this.RaisePropertyChanged("EntitySetName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityKeyMember", Namespace="http://schemas.datacontract.org/2004/07/System.Data")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wrox.ProCSharp.WCF.RoomReservationService.RoomReservation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wrox.ProCSharp.WCF.RoomReservationService.RoomReservationRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wrox.ProCSharp.WCF.RoomReservationService.RoomReservation[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wrox.ProCSharp.WCF.RoomReservationService.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wrox.ProCSharp.WCF.RoomReservationService.StructuralObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wrox.ProCSharp.WCF.RoomReservationService.EntityKey))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wrox.ProCSharp.WCF.RoomReservationService.EntityKeyMember[]))]
    public partial class EntityKeyMember : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ValueField;
        
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
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Value {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomReservationRequest", Namespace="http://schemas.datacontract.org/2004/07/Wrox.ProCSharp.WCF")]
    [System.SerializableAttribute()]
    public partial class RoomReservationRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FromDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ToDateField;
        
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
        public System.DateTime FromDate {
            get {
                return this.FromDateField;
            }
            set {
                if ((this.FromDateField.Equals(value) != true)) {
                    this.FromDateField = value;
                    this.RaisePropertyChanged("FromDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ToDate {
            get {
                return this.ToDateField;
            }
            set {
                if ((this.ToDateField.Equals(value) != true)) {
                    this.ToDateField = value;
                    this.RaisePropertyChanged("ToDate");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RoomReservationService.IRoomService")]
    public interface IRoomService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomService/ReserveRoom", ReplyAction="http://tempuri.org/IRoomService/ReserveRoomResponse")]
        bool ReserveRoom(Wrox.ProCSharp.WCF.RoomReservationService.RoomReservation roomReservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomService/GetRoomReservations", ReplyAction="http://tempuri.org/IRoomService/GetRoomReservationsResponse")]
        Wrox.ProCSharp.WCF.RoomReservationService.RoomReservation[] GetRoomReservations(Wrox.ProCSharp.WCF.RoomReservationService.RoomReservationRequest reservationRequest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRoomServiceChannel : Wrox.ProCSharp.WCF.RoomReservationService.IRoomService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RoomServiceClient : System.ServiceModel.ClientBase<Wrox.ProCSharp.WCF.RoomReservationService.IRoomService>, Wrox.ProCSharp.WCF.RoomReservationService.IRoomService {
        
        public RoomServiceClient() {
        }
        
        public RoomServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RoomServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoomServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoomServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ReserveRoom(Wrox.ProCSharp.WCF.RoomReservationService.RoomReservation roomReservation) {
            return base.Channel.ReserveRoom(roomReservation);
        }
        
        public Wrox.ProCSharp.WCF.RoomReservationService.RoomReservation[] GetRoomReservations(Wrox.ProCSharp.WCF.RoomReservationService.RoomReservationRequest reservationRequest) {
            return base.Channel.GetRoomReservations(reservationRequest);
        }
    }
}