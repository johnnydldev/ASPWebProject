﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSClient.ServiceRecipe {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VO_Recipe", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class VO_Recipe : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdRecipeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamePatientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MedicalConditionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TreatmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TestResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MedicamentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DoctorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegisterDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WSClient.ServiceRecipe.VO_Patient PatientField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int IdRecipe {
            get {
                return this.IdRecipeField;
            }
            set {
                if ((this.IdRecipeField.Equals(value) != true)) {
                    this.IdRecipeField = value;
                    this.RaisePropertyChanged("IdRecipe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string NamePatient {
            get {
                return this.NamePatientField;
            }
            set {
                if ((object.ReferenceEquals(this.NamePatientField, value) != true)) {
                    this.NamePatientField = value;
                    this.RaisePropertyChanged("NamePatient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string MedicalCondition {
            get {
                return this.MedicalConditionField;
            }
            set {
                if ((object.ReferenceEquals(this.MedicalConditionField, value) != true)) {
                    this.MedicalConditionField = value;
                    this.RaisePropertyChanged("MedicalCondition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Treatment {
            get {
                return this.TreatmentField;
            }
            set {
                if ((object.ReferenceEquals(this.TreatmentField, value) != true)) {
                    this.TreatmentField = value;
                    this.RaisePropertyChanged("Treatment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Test {
            get {
                return this.TestField;
            }
            set {
                if ((object.ReferenceEquals(this.TestField, value) != true)) {
                    this.TestField = value;
                    this.RaisePropertyChanged("Test");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string TestResult {
            get {
                return this.TestResultField;
            }
            set {
                if ((object.ReferenceEquals(this.TestResultField, value) != true)) {
                    this.TestResultField = value;
                    this.RaisePropertyChanged("TestResult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Medicament {
            get {
                return this.MedicamentField;
            }
            set {
                if ((object.ReferenceEquals(this.MedicamentField, value) != true)) {
                    this.MedicamentField = value;
                    this.RaisePropertyChanged("Medicament");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Doctor {
            get {
                return this.DoctorField;
            }
            set {
                if ((object.ReferenceEquals(this.DoctorField, value) != true)) {
                    this.DoctorField = value;
                    this.RaisePropertyChanged("Doctor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string RegisterDate {
            get {
                return this.RegisterDateField;
            }
            set {
                if ((object.ReferenceEquals(this.RegisterDateField, value) != true)) {
                    this.RegisterDateField = value;
                    this.RaisePropertyChanged("RegisterDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public WSClient.ServiceRecipe.VO_Patient Patient {
            get {
                return this.PatientField;
            }
            set {
                if ((object.ReferenceEquals(this.PatientField, value) != true)) {
                    this.PatientField = value;
                    this.RaisePropertyChanged("Patient");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="VO_Patient", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class VO_Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdPatientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamePatientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelephoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WSClient.ServiceRecipe.VO_Address AddressField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int IdPatient {
            get {
                return this.IdPatientField;
            }
            set {
                if ((this.IdPatientField.Equals(value) != true)) {
                    this.IdPatientField = value;
                    this.RaisePropertyChanged("IdPatient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string NamePatient {
            get {
                return this.NamePatientField;
            }
            set {
                if ((object.ReferenceEquals(this.NamePatientField, value) != true)) {
                    this.NamePatientField = value;
                    this.RaisePropertyChanged("NamePatient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((object.ReferenceEquals(this.BirthDateField, value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Telephone {
            get {
                return this.TelephoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephoneField, value) != true)) {
                    this.TelephoneField = value;
                    this.RaisePropertyChanged("Telephone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public WSClient.ServiceRecipe.VO_Address Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="VO_Address", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class VO_Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuburbField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int IdAddress {
            get {
                return this.IdAddressField;
            }
            set {
                if ((this.IdAddressField.Equals(value) != true)) {
                    this.IdAddressField = value;
                    this.RaisePropertyChanged("IdAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Suburb {
            get {
                return this.SuburbField;
            }
            set {
                if ((object.ReferenceEquals(this.SuburbField, value) != true)) {
                    this.SuburbField = value;
                    this.RaisePropertyChanged("Suburb");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRecipe.RecipeServiceSoap")]
    public interface RecipeServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento recipe del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateRecipe", ReplyAction="*")]
        WSClient.ServiceRecipe.CreateRecipeResponse CreateRecipe(WSClient.ServiceRecipe.CreateRecipeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateRecipe", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.ServiceRecipe.CreateRecipeResponse> CreateRecipeAsync(WSClient.ServiceRecipe.CreateRecipeRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetAllRecipesResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllRecipes", ReplyAction="*")]
        WSClient.ServiceRecipe.GetAllRecipesResponse GetAllRecipes(WSClient.ServiceRecipe.GetAllRecipesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllRecipes", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.ServiceRecipe.GetAllRecipesResponse> GetAllRecipesAsync(WSClient.ServiceRecipe.GetAllRecipesRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetByIdRecipeResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetByIdRecipe", ReplyAction="*")]
        WSClient.ServiceRecipe.GetByIdRecipeResponse GetByIdRecipe(WSClient.ServiceRecipe.GetByIdRecipeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetByIdRecipe", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.ServiceRecipe.GetByIdRecipeResponse> GetByIdRecipeAsync(WSClient.ServiceRecipe.GetByIdRecipeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateRecipeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateRecipe", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceRecipe.CreateRecipeRequestBody Body;
        
        public CreateRecipeRequest() {
        }
        
        public CreateRecipeRequest(WSClient.ServiceRecipe.CreateRecipeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateRecipeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WSClient.ServiceRecipe.VO_Recipe recipe;
        
        public CreateRecipeRequestBody() {
        }
        
        public CreateRecipeRequestBody(WSClient.ServiceRecipe.VO_Recipe recipe) {
            this.recipe = recipe;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateRecipeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateRecipeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceRecipe.CreateRecipeResponseBody Body;
        
        public CreateRecipeResponse() {
        }
        
        public CreateRecipeResponse(WSClient.ServiceRecipe.CreateRecipeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateRecipeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int CreateRecipeResult;
        
        public CreateRecipeResponseBody() {
        }
        
        public CreateRecipeResponseBody(int CreateRecipeResult) {
            this.CreateRecipeResult = CreateRecipeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRecipesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllRecipes", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceRecipe.GetAllRecipesRequestBody Body;
        
        public GetAllRecipesRequest() {
        }
        
        public GetAllRecipesRequest(WSClient.ServiceRecipe.GetAllRecipesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRecipesRequestBody {
        
        public GetAllRecipesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRecipesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllRecipesResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceRecipe.GetAllRecipesResponseBody Body;
        
        public GetAllRecipesResponse() {
        }
        
        public GetAllRecipesResponse(WSClient.ServiceRecipe.GetAllRecipesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllRecipesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WSClient.ServiceRecipe.VO_Recipe[] GetAllRecipesResult;
        
        public GetAllRecipesResponseBody() {
        }
        
        public GetAllRecipesResponseBody(WSClient.ServiceRecipe.VO_Recipe[] GetAllRecipesResult) {
            this.GetAllRecipesResult = GetAllRecipesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetByIdRecipeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetByIdRecipe", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceRecipe.GetByIdRecipeRequestBody Body;
        
        public GetByIdRecipeRequest() {
        }
        
        public GetByIdRecipeRequest(WSClient.ServiceRecipe.GetByIdRecipeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetByIdRecipeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idRecipe;
        
        public GetByIdRecipeRequestBody() {
        }
        
        public GetByIdRecipeRequestBody(int idRecipe) {
            this.idRecipe = idRecipe;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetByIdRecipeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetByIdRecipeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceRecipe.GetByIdRecipeResponseBody Body;
        
        public GetByIdRecipeResponse() {
        }
        
        public GetByIdRecipeResponse(WSClient.ServiceRecipe.GetByIdRecipeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetByIdRecipeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WSClient.ServiceRecipe.VO_Recipe GetByIdRecipeResult;
        
        public GetByIdRecipeResponseBody() {
        }
        
        public GetByIdRecipeResponseBody(WSClient.ServiceRecipe.VO_Recipe GetByIdRecipeResult) {
            this.GetByIdRecipeResult = GetByIdRecipeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RecipeServiceSoapChannel : WSClient.ServiceRecipe.RecipeServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RecipeServiceSoapClient : System.ServiceModel.ClientBase<WSClient.ServiceRecipe.RecipeServiceSoap>, WSClient.ServiceRecipe.RecipeServiceSoap {
        
        public RecipeServiceSoapClient() {
        }
        
        public RecipeServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RecipeServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecipeServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecipeServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.ServiceRecipe.CreateRecipeResponse WSClient.ServiceRecipe.RecipeServiceSoap.CreateRecipe(WSClient.ServiceRecipe.CreateRecipeRequest request) {
            return base.Channel.CreateRecipe(request);
        }
        
        public int CreateRecipe(WSClient.ServiceRecipe.VO_Recipe recipe) {
            WSClient.ServiceRecipe.CreateRecipeRequest inValue = new WSClient.ServiceRecipe.CreateRecipeRequest();
            inValue.Body = new WSClient.ServiceRecipe.CreateRecipeRequestBody();
            inValue.Body.recipe = recipe;
            WSClient.ServiceRecipe.CreateRecipeResponse retVal = ((WSClient.ServiceRecipe.RecipeServiceSoap)(this)).CreateRecipe(inValue);
            return retVal.Body.CreateRecipeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.ServiceRecipe.CreateRecipeResponse> WSClient.ServiceRecipe.RecipeServiceSoap.CreateRecipeAsync(WSClient.ServiceRecipe.CreateRecipeRequest request) {
            return base.Channel.CreateRecipeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.ServiceRecipe.CreateRecipeResponse> CreateRecipeAsync(WSClient.ServiceRecipe.VO_Recipe recipe) {
            WSClient.ServiceRecipe.CreateRecipeRequest inValue = new WSClient.ServiceRecipe.CreateRecipeRequest();
            inValue.Body = new WSClient.ServiceRecipe.CreateRecipeRequestBody();
            inValue.Body.recipe = recipe;
            return ((WSClient.ServiceRecipe.RecipeServiceSoap)(this)).CreateRecipeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.ServiceRecipe.GetAllRecipesResponse WSClient.ServiceRecipe.RecipeServiceSoap.GetAllRecipes(WSClient.ServiceRecipe.GetAllRecipesRequest request) {
            return base.Channel.GetAllRecipes(request);
        }
        
        public WSClient.ServiceRecipe.VO_Recipe[] GetAllRecipes() {
            WSClient.ServiceRecipe.GetAllRecipesRequest inValue = new WSClient.ServiceRecipe.GetAllRecipesRequest();
            inValue.Body = new WSClient.ServiceRecipe.GetAllRecipesRequestBody();
            WSClient.ServiceRecipe.GetAllRecipesResponse retVal = ((WSClient.ServiceRecipe.RecipeServiceSoap)(this)).GetAllRecipes(inValue);
            return retVal.Body.GetAllRecipesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.ServiceRecipe.GetAllRecipesResponse> WSClient.ServiceRecipe.RecipeServiceSoap.GetAllRecipesAsync(WSClient.ServiceRecipe.GetAllRecipesRequest request) {
            return base.Channel.GetAllRecipesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.ServiceRecipe.GetAllRecipesResponse> GetAllRecipesAsync() {
            WSClient.ServiceRecipe.GetAllRecipesRequest inValue = new WSClient.ServiceRecipe.GetAllRecipesRequest();
            inValue.Body = new WSClient.ServiceRecipe.GetAllRecipesRequestBody();
            return ((WSClient.ServiceRecipe.RecipeServiceSoap)(this)).GetAllRecipesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.ServiceRecipe.GetByIdRecipeResponse WSClient.ServiceRecipe.RecipeServiceSoap.GetByIdRecipe(WSClient.ServiceRecipe.GetByIdRecipeRequest request) {
            return base.Channel.GetByIdRecipe(request);
        }
        
        public WSClient.ServiceRecipe.VO_Recipe GetByIdRecipe(int idRecipe) {
            WSClient.ServiceRecipe.GetByIdRecipeRequest inValue = new WSClient.ServiceRecipe.GetByIdRecipeRequest();
            inValue.Body = new WSClient.ServiceRecipe.GetByIdRecipeRequestBody();
            inValue.Body.idRecipe = idRecipe;
            WSClient.ServiceRecipe.GetByIdRecipeResponse retVal = ((WSClient.ServiceRecipe.RecipeServiceSoap)(this)).GetByIdRecipe(inValue);
            return retVal.Body.GetByIdRecipeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.ServiceRecipe.GetByIdRecipeResponse> WSClient.ServiceRecipe.RecipeServiceSoap.GetByIdRecipeAsync(WSClient.ServiceRecipe.GetByIdRecipeRequest request) {
            return base.Channel.GetByIdRecipeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.ServiceRecipe.GetByIdRecipeResponse> GetByIdRecipeAsync(int idRecipe) {
            WSClient.ServiceRecipe.GetByIdRecipeRequest inValue = new WSClient.ServiceRecipe.GetByIdRecipeRequest();
            inValue.Body = new WSClient.ServiceRecipe.GetByIdRecipeRequestBody();
            inValue.Body.idRecipe = idRecipe;
            return ((WSClient.ServiceRecipe.RecipeServiceSoap)(this)).GetByIdRecipeAsync(inValue);
        }
    }
}