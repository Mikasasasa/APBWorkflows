﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Workflow.TrainingMeetingService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveDietAndTrainingPlanRequest", Namespace="http://schemas.datacontract.org/2004/07/TrainingMeetingService.Models")]
    [System.SerializableAttribute()]
    public partial class SaveDietAndTrainingPlanRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DietField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrainingPlanField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Diet {
            get {
                return this.DietField;
            }
            set {
                if ((object.ReferenceEquals(this.DietField, value) != true)) {
                    this.DietField = value;
                    this.RaisePropertyChanged("Diet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TrainingPlan {
            get {
                return this.TrainingPlanField;
            }
            set {
                if ((object.ReferenceEquals(this.TrainingPlanField, value) != true)) {
                    this.TrainingPlanField = value;
                    this.RaisePropertyChanged("TrainingPlan");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveDietAndTrainingPlanResponse", Namespace="http://schemas.datacontract.org/2004/07/TrainingMeetingService.Models")]
    [System.SerializableAttribute()]
    public partial class SaveDietAndTrainingPlanResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ResultField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SendClientNotificationRequest", Namespace="http://schemas.datacontract.org/2004/07/TrainingMeetingService.Models")]
    [System.SerializableAttribute()]
    public partial class SendClientNotificationRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReceiverField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Receiver {
            get {
                return this.ReceiverField;
            }
            set {
                if ((object.ReferenceEquals(this.ReceiverField, value) != true)) {
                    this.ReceiverField = value;
                    this.RaisePropertyChanged("Receiver");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SendClientNotificationResponse", Namespace="http://schemas.datacontract.org/2004/07/TrainingMeetingService.Models")]
    [System.SerializableAttribute()]
    public partial class SendClientNotificationResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ResultField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProposeDatesRequest", Namespace="http://schemas.datacontract.org/2004/07/TrainingMeetingService.Models")]
    [System.SerializableAttribute()]
    public partial class ProposeDatesRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProposeDatesResponse", Namespace="http://schemas.datacontract.org/2004/07/TrainingMeetingService.Models")]
    [System.SerializableAttribute()]
    public partial class ProposeDatesResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime[] ProposedDateTimesField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime[] ProposedDateTimes {
            get {
                return this.ProposedDateTimesField;
            }
            set {
                if ((object.ReferenceEquals(this.ProposedDateTimesField, value) != true)) {
                    this.ProposedDateTimesField = value;
                    this.RaisePropertyChanged("ProposedDateTimes");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveChosenDateRequest", Namespace="http://schemas.datacontract.org/2004/07/TrainingMeetingService.Models")]
    [System.SerializableAttribute()]
    public partial class SaveChosenDateRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AcceptedDateField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AcceptedDate {
            get {
                return this.AcceptedDateField;
            }
            set {
                if ((this.AcceptedDateField.Equals(value) != true)) {
                    this.AcceptedDateField = value;
                    this.RaisePropertyChanged("AcceptedDate");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveChosenDateResponse", Namespace="http://schemas.datacontract.org/2004/07/TrainingMeetingService.Models")]
    [System.SerializableAttribute()]
    public partial class SaveChosenDateResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ResultField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveChangesToDietRequest", Namespace="http://schemas.datacontract.org/2004/07/TrainingMeetingService.Models")]
    [System.SerializableAttribute()]
    public partial class SaveChangesToDietRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NewDietTextField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NewDietText {
            get {
                return this.NewDietTextField;
            }
            set {
                if ((object.ReferenceEquals(this.NewDietTextField, value) != true)) {
                    this.NewDietTextField = value;
                    this.RaisePropertyChanged("NewDietText");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveChangesToDietResponse", Namespace="http://schemas.datacontract.org/2004/07/TrainingMeetingService.Models")]
    [System.SerializableAttribute()]
    public partial class SaveChangesToDietResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ResultField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TrainingMeetingService.ITrainingMeetingService")]
    public interface ITrainingMeetingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingMeetingService/SaveDietAndTrainingPlan", ReplyAction="http://tempuri.org/ITrainingMeetingService/SaveDietAndTrainingPlanResponse")]
        Workflow.TrainingMeetingService.SaveDietAndTrainingPlanResponse1 SaveDietAndTrainingPlan(Workflow.TrainingMeetingService.SaveDietAndTrainingPlanRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingMeetingService/SaveDietAndTrainingPlan", ReplyAction="http://tempuri.org/ITrainingMeetingService/SaveDietAndTrainingPlanResponse")]
        System.Threading.Tasks.Task<Workflow.TrainingMeetingService.SaveDietAndTrainingPlanResponse1> SaveDietAndTrainingPlanAsync(Workflow.TrainingMeetingService.SaveDietAndTrainingPlanRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingMeetingService/SendClientNotification", ReplyAction="http://tempuri.org/ITrainingMeetingService/SendClientNotificationResponse")]
        Workflow.TrainingMeetingService.SendClientNotificationResponse1 SendClientNotification(Workflow.TrainingMeetingService.SendClientNotificationRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingMeetingService/SendClientNotification", ReplyAction="http://tempuri.org/ITrainingMeetingService/SendClientNotificationResponse")]
        System.Threading.Tasks.Task<Workflow.TrainingMeetingService.SendClientNotificationResponse1> SendClientNotificationAsync(Workflow.TrainingMeetingService.SendClientNotificationRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingMeetingService/ProposeDates", ReplyAction="http://tempuri.org/ITrainingMeetingService/ProposeDatesResponse")]
        Workflow.TrainingMeetingService.ProposeDatesResponse1 ProposeDates(Workflow.TrainingMeetingService.ProposeDatesRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingMeetingService/ProposeDates", ReplyAction="http://tempuri.org/ITrainingMeetingService/ProposeDatesResponse")]
        System.Threading.Tasks.Task<Workflow.TrainingMeetingService.ProposeDatesResponse1> ProposeDatesAsync(Workflow.TrainingMeetingService.ProposeDatesRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingMeetingService/SaveChosenDate", ReplyAction="http://tempuri.org/ITrainingMeetingService/SaveChosenDateResponse")]
        Workflow.TrainingMeetingService.SaveChosenDateResponse1 SaveChosenDate(Workflow.TrainingMeetingService.SaveChosenDateRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingMeetingService/SaveChosenDate", ReplyAction="http://tempuri.org/ITrainingMeetingService/SaveChosenDateResponse")]
        System.Threading.Tasks.Task<Workflow.TrainingMeetingService.SaveChosenDateResponse1> SaveChosenDateAsync(Workflow.TrainingMeetingService.SaveChosenDateRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingMeetingService/SaveChangesToDiet", ReplyAction="http://tempuri.org/ITrainingMeetingService/SaveChangesToDietResponse")]
        Workflow.TrainingMeetingService.SaveChangesToDietResponse1 SaveChangesToDiet(Workflow.TrainingMeetingService.SaveChangesToDietRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingMeetingService/SaveChangesToDiet", ReplyAction="http://tempuri.org/ITrainingMeetingService/SaveChangesToDietResponse")]
        System.Threading.Tasks.Task<Workflow.TrainingMeetingService.SaveChangesToDietResponse1> SaveChangesToDietAsync(Workflow.TrainingMeetingService.SaveChangesToDietRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveDietAndTrainingPlan", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveDietAndTrainingPlanRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.TrainingMeetingService.SaveDietAndTrainingPlanRequest request;
        
        public SaveDietAndTrainingPlanRequest1() {
        }
        
        public SaveDietAndTrainingPlanRequest1(Workflow.TrainingMeetingService.SaveDietAndTrainingPlanRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveDietAndTrainingPlanResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveDietAndTrainingPlanResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.TrainingMeetingService.SaveDietAndTrainingPlanResponse SaveDietAndTrainingPlanResult;
        
        public SaveDietAndTrainingPlanResponse1() {
        }
        
        public SaveDietAndTrainingPlanResponse1(Workflow.TrainingMeetingService.SaveDietAndTrainingPlanResponse SaveDietAndTrainingPlanResult) {
            this.SaveDietAndTrainingPlanResult = SaveDietAndTrainingPlanResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendClientNotification", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendClientNotificationRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.TrainingMeetingService.SendClientNotificationRequest request;
        
        public SendClientNotificationRequest1() {
        }
        
        public SendClientNotificationRequest1(Workflow.TrainingMeetingService.SendClientNotificationRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendClientNotificationResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendClientNotificationResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.TrainingMeetingService.SendClientNotificationResponse SendClientNotificationResult;
        
        public SendClientNotificationResponse1() {
        }
        
        public SendClientNotificationResponse1(Workflow.TrainingMeetingService.SendClientNotificationResponse SendClientNotificationResult) {
            this.SendClientNotificationResult = SendClientNotificationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProposeDates", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ProposeDatesRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.TrainingMeetingService.ProposeDatesRequest request;
        
        public ProposeDatesRequest1() {
        }
        
        public ProposeDatesRequest1(Workflow.TrainingMeetingService.ProposeDatesRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProposeDatesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ProposeDatesResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.TrainingMeetingService.ProposeDatesResponse ProposeDatesResult;
        
        public ProposeDatesResponse1() {
        }
        
        public ProposeDatesResponse1(Workflow.TrainingMeetingService.ProposeDatesResponse ProposeDatesResult) {
            this.ProposeDatesResult = ProposeDatesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveChosenDate", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveChosenDateRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.TrainingMeetingService.SaveChosenDateRequest request;
        
        public SaveChosenDateRequest1() {
        }
        
        public SaveChosenDateRequest1(Workflow.TrainingMeetingService.SaveChosenDateRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveChosenDateResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveChosenDateResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.TrainingMeetingService.SaveChosenDateResponse SaveChosenDateResult;
        
        public SaveChosenDateResponse1() {
        }
        
        public SaveChosenDateResponse1(Workflow.TrainingMeetingService.SaveChosenDateResponse SaveChosenDateResult) {
            this.SaveChosenDateResult = SaveChosenDateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveChangesToDiet", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveChangesToDietRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.TrainingMeetingService.SaveChangesToDietRequest request;
        
        public SaveChangesToDietRequest1() {
        }
        
        public SaveChangesToDietRequest1(Workflow.TrainingMeetingService.SaveChangesToDietRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveChangesToDietResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveChangesToDietResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.TrainingMeetingService.SaveChangesToDietResponse SaveChangesToDietResult;
        
        public SaveChangesToDietResponse1() {
        }
        
        public SaveChangesToDietResponse1(Workflow.TrainingMeetingService.SaveChangesToDietResponse SaveChangesToDietResult) {
            this.SaveChangesToDietResult = SaveChangesToDietResult;
        }
    }
}
