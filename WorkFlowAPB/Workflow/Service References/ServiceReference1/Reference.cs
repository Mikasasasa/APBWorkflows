﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Workflow.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChooseBestSubscriptionRequest", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Models")]
    [System.SerializableAttribute()]
    public partial class ChooseBestSubscriptionRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsWeekendIncludedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsWholeDayImportantField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TrainingsInWeekField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsWeekendIncluded {
            get {
                return this.IsWeekendIncludedField;
            }
            set {
                if ((this.IsWeekendIncludedField.Equals(value) != true)) {
                    this.IsWeekendIncludedField = value;
                    this.RaisePropertyChanged("IsWeekendIncluded");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsWholeDayImportant {
            get {
                return this.IsWholeDayImportantField;
            }
            set {
                if ((this.IsWholeDayImportantField.Equals(value) != true)) {
                    this.IsWholeDayImportantField = value;
                    this.RaisePropertyChanged("IsWholeDayImportant");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TrainingsInWeek {
            get {
                return this.TrainingsInWeekField;
            }
            set {
                if ((this.TrainingsInWeekField.Equals(value) != true)) {
                    this.TrainingsInWeekField = value;
                    this.RaisePropertyChanged("TrainingsInWeek");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ChooseBestSubscriptionResponse", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Models")]
    [System.SerializableAttribute()]
    public partial class ChooseBestSubscriptionResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlanNameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlanName {
            get {
                return this.PlanNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PlanNameField, value) != true)) {
                    this.PlanNameField = value;
                    this.RaisePropertyChanged("PlanName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateClientAccountRequest", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Models")]
    [System.SerializableAttribute()]
    public partial class CreateClientAccountRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
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
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateClientAccountResponse", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Models")]
    [System.SerializableAttribute()]
    public partial class CreateClientAccountResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveClientSurveyRequest", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Models")]
    [System.SerializableAttribute()]
    public partial class SaveClientSurveyRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Workflow.ServiceReference1.ClientsSurveyQuestion[] AnswersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Workflow.ServiceReference1.ClientsSurveyQuestion[] Answers {
            get {
                return this.AnswersField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswersField, value) != true)) {
                    this.AnswersField = value;
                    this.RaisePropertyChanged("Answers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientId {
            get {
                return this.ClientIdField;
            }
            set {
                if ((this.ClientIdField.Equals(value) != true)) {
                    this.ClientIdField = value;
                    this.RaisePropertyChanged("ClientId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientsSurveyQuestion", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Models")]
    [System.SerializableAttribute()]
    public partial class ClientsSurveyQuestion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuestionField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Answer {
            get {
                return this.AnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswerField, value) != true)) {
                    this.AnswerField = value;
                    this.RaisePropertyChanged("Answer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Question {
            get {
                return this.QuestionField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionField, value) != true)) {
                    this.QuestionField = value;
                    this.RaisePropertyChanged("Question");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveClientSurveyResponse", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Models")]
    [System.SerializableAttribute()]
    public partial class SaveClientSurveyResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveSubscriptionRequest", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Models")]
    [System.SerializableAttribute()]
    public partial class SaveSubscriptionRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SubscriptionEndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SubscriptionStartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SubscriptionTypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientId {
            get {
                return this.ClientIdField;
            }
            set {
                if ((this.ClientIdField.Equals(value) != true)) {
                    this.ClientIdField = value;
                    this.RaisePropertyChanged("ClientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SubscriptionEnd {
            get {
                return this.SubscriptionEndField;
            }
            set {
                if ((this.SubscriptionEndField.Equals(value) != true)) {
                    this.SubscriptionEndField = value;
                    this.RaisePropertyChanged("SubscriptionEnd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SubscriptionStart {
            get {
                return this.SubscriptionStartField;
            }
            set {
                if ((this.SubscriptionStartField.Equals(value) != true)) {
                    this.SubscriptionStartField = value;
                    this.RaisePropertyChanged("SubscriptionStart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SubscriptionType {
            get {
                return this.SubscriptionTypeField;
            }
            set {
                if ((this.SubscriptionTypeField.Equals(value) != true)) {
                    this.SubscriptionTypeField = value;
                    this.RaisePropertyChanged("SubscriptionType");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveSubscriptionResponse", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Models")]
    [System.SerializableAttribute()]
    public partial class SaveSubscriptionResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChooseBestSubscription", ReplyAction="http://tempuri.org/IService1/ChooseBestSubscriptionResponse")]
        global::Workflow.ServiceReference1.ChooseBestSubscriptionResponse1 ChooseBestSubscription(global::Workflow.ServiceReference1.ChooseBestSubscriptionRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChooseBestSubscription", ReplyAction="http://tempuri.org/IService1/ChooseBestSubscriptionResponse")]
        System.Threading.Tasks.Task<global::Workflow.ServiceReference1.ChooseBestSubscriptionResponse1> ChooseBestSubscriptionAsync(global::Workflow.ServiceReference1.ChooseBestSubscriptionRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateClientAccount", ReplyAction="http://tempuri.org/IService1/CreateClientAccountResponse")]
        global::Workflow.ServiceReference1.CreateClientAccountResponse1 CreateClientAccount(global::Workflow.ServiceReference1.CreateClientAccountRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateClientAccount", ReplyAction="http://tempuri.org/IService1/CreateClientAccountResponse")]
        System.Threading.Tasks.Task<global::Workflow.ServiceReference1.CreateClientAccountResponse1> CreateClientAccountAsync(global::Workflow.ServiceReference1.CreateClientAccountRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveClientSurvey", ReplyAction="http://tempuri.org/IService1/SaveClientSurveyResponse")]
        global::Workflow.ServiceReference1.SaveClientSurveyResponse1 SaveClientSurvey(global::Workflow.ServiceReference1.SaveClientSurveyRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveClientSurvey", ReplyAction="http://tempuri.org/IService1/SaveClientSurveyResponse")]
        System.Threading.Tasks.Task<global::Workflow.ServiceReference1.SaveClientSurveyResponse1> SaveClientSurveyAsync(global::Workflow.ServiceReference1.SaveClientSurveyRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveSubscription", ReplyAction="http://tempuri.org/IService1/SaveSubscriptionResponse")]
        global::Workflow.ServiceReference1.SaveSubscriptionResponse1 SaveSubscription(global::Workflow.ServiceReference1.SaveSubscriptionRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveSubscription", ReplyAction="http://tempuri.org/IService1/SaveSubscriptionResponse")]
        System.Threading.Tasks.Task<global::Workflow.ServiceReference1.SaveSubscriptionResponse1> SaveSubscriptionAsync(global::Workflow.ServiceReference1.SaveSubscriptionRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ChooseBestSubscription", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ChooseBestSubscriptionRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.ServiceReference1.ChooseBestSubscriptionRequest request;
        
        public ChooseBestSubscriptionRequest1() {
        }
        
        public ChooseBestSubscriptionRequest1(Workflow.ServiceReference1.ChooseBestSubscriptionRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ChooseBestSubscriptionResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ChooseBestSubscriptionResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.ServiceReference1.ChooseBestSubscriptionResponse ChooseBestSubscriptionResult;
        
        public ChooseBestSubscriptionResponse1() {
        }
        
        public ChooseBestSubscriptionResponse1(Workflow.ServiceReference1.ChooseBestSubscriptionResponse ChooseBestSubscriptionResult) {
            this.ChooseBestSubscriptionResult = ChooseBestSubscriptionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateClientAccount", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateClientAccountRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.ServiceReference1.CreateClientAccountRequest request;
        
        public CreateClientAccountRequest1() {
        }
        
        public CreateClientAccountRequest1(Workflow.ServiceReference1.CreateClientAccountRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateClientAccountResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateClientAccountResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.ServiceReference1.CreateClientAccountResponse CreateClientAccountResult;
        
        public CreateClientAccountResponse1() {
        }
        
        public CreateClientAccountResponse1(Workflow.ServiceReference1.CreateClientAccountResponse CreateClientAccountResult) {
            this.CreateClientAccountResult = CreateClientAccountResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveClientSurvey", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveClientSurveyRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.ServiceReference1.SaveClientSurveyRequest request;
        
        public SaveClientSurveyRequest1() {
        }
        
        public SaveClientSurveyRequest1(Workflow.ServiceReference1.SaveClientSurveyRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveClientSurveyResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveClientSurveyResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.ServiceReference1.SaveClientSurveyResponse SaveClientSurveyResult;
        
        public SaveClientSurveyResponse1() {
        }
        
        public SaveClientSurveyResponse1(Workflow.ServiceReference1.SaveClientSurveyResponse SaveClientSurveyResult) {
            this.SaveClientSurveyResult = SaveClientSurveyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveSubscription", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveSubscriptionRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.ServiceReference1.SaveSubscriptionRequest request;
        
        public SaveSubscriptionRequest1() {
        }
        
        public SaveSubscriptionRequest1(Workflow.ServiceReference1.SaveSubscriptionRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveSubscriptionResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveSubscriptionResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Workflow.ServiceReference1.SaveSubscriptionResponse SaveSubscriptionResult;
        
        public SaveSubscriptionResponse1() {
        }
        
        public SaveSubscriptionResponse1(Workflow.ServiceReference1.SaveSubscriptionResponse SaveSubscriptionResult) {
            this.SaveSubscriptionResult = SaveSubscriptionResult;
        }
    }
}