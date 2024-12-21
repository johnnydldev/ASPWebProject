﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSClient.WSMedicament {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VO_Medicament", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class VO_Medicament : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdMedicamentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameMedicamentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DoseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UseInstructionField;
        
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
        public int IdMedicament {
            get {
                return this.IdMedicamentField;
            }
            set {
                if ((this.IdMedicamentField.Equals(value) != true)) {
                    this.IdMedicamentField = value;
                    this.RaisePropertyChanged("IdMedicament");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string NameMedicament {
            get {
                return this.NameMedicamentField;
            }
            set {
                if ((object.ReferenceEquals(this.NameMedicamentField, value) != true)) {
                    this.NameMedicamentField = value;
                    this.RaisePropertyChanged("NameMedicament");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Dose {
            get {
                return this.DoseField;
            }
            set {
                if ((object.ReferenceEquals(this.DoseField, value) != true)) {
                    this.DoseField = value;
                    this.RaisePropertyChanged("Dose");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string UseInstruction {
            get {
                return this.UseInstructionField;
            }
            set {
                if ((object.ReferenceEquals(this.UseInstructionField, value) != true)) {
                    this.UseInstructionField = value;
                    this.RaisePropertyChanged("UseInstruction");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSMedicament.MedicamentServiceSoap")]
    public interface MedicamentServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento medicament del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateMedicament", ReplyAction="*")]
        WSClient.WSMedicament.CreateMedicamentResponse CreateMedicament(WSClient.WSMedicament.CreateMedicamentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateMedicament", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.WSMedicament.CreateMedicamentResponse> CreateMedicamentAsync(WSClient.WSMedicament.CreateMedicamentRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ListMedicamentsResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListMedicaments", ReplyAction="*")]
        WSClient.WSMedicament.ListMedicamentsResponse ListMedicaments(WSClient.WSMedicament.ListMedicamentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListMedicaments", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.WSMedicament.ListMedicamentsResponse> ListMedicamentsAsync(WSClient.WSMedicament.ListMedicamentsRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento medicament del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateMedicament", ReplyAction="*")]
        WSClient.WSMedicament.UpdateMedicamentResponse UpdateMedicament(WSClient.WSMedicament.UpdateMedicamentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateMedicament", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.WSMedicament.UpdateMedicamentResponse> UpdateMedicamentAsync(WSClient.WSMedicament.UpdateMedicamentRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento DeleteMedicamentResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteMedicament", ReplyAction="*")]
        WSClient.WSMedicament.DeleteMedicamentResponse DeleteMedicament(WSClient.WSMedicament.DeleteMedicamentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteMedicament", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.WSMedicament.DeleteMedicamentResponse> DeleteMedicamentAsync(WSClient.WSMedicament.DeleteMedicamentRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetMedicamentByIdResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMedicamentById", ReplyAction="*")]
        WSClient.WSMedicament.GetMedicamentByIdResponse GetMedicamentById(WSClient.WSMedicament.GetMedicamentByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMedicamentById", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.WSMedicament.GetMedicamentByIdResponse> GetMedicamentByIdAsync(WSClient.WSMedicament.GetMedicamentByIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateMedicamentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateMedicament", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.WSMedicament.CreateMedicamentRequestBody Body;
        
        public CreateMedicamentRequest() {
        }
        
        public CreateMedicamentRequest(WSClient.WSMedicament.CreateMedicamentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateMedicamentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WSClient.WSMedicament.VO_Medicament medicament;
        
        public CreateMedicamentRequestBody() {
        }
        
        public CreateMedicamentRequestBody(WSClient.WSMedicament.VO_Medicament medicament) {
            this.medicament = medicament;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateMedicamentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateMedicamentResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.WSMedicament.CreateMedicamentResponseBody Body;
        
        public CreateMedicamentResponse() {
        }
        
        public CreateMedicamentResponse(WSClient.WSMedicament.CreateMedicamentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateMedicamentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CreateMedicamentResult;
        
        public CreateMedicamentResponseBody() {
        }
        
        public CreateMedicamentResponseBody(string CreateMedicamentResult) {
            this.CreateMedicamentResult = CreateMedicamentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListMedicamentsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListMedicaments", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.WSMedicament.ListMedicamentsRequestBody Body;
        
        public ListMedicamentsRequest() {
        }
        
        public ListMedicamentsRequest(WSClient.WSMedicament.ListMedicamentsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListMedicamentsRequestBody {
        
        public ListMedicamentsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListMedicamentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListMedicamentsResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.WSMedicament.ListMedicamentsResponseBody Body;
        
        public ListMedicamentsResponse() {
        }
        
        public ListMedicamentsResponse(WSClient.WSMedicament.ListMedicamentsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListMedicamentsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WSClient.WSMedicament.VO_Medicament[] ListMedicamentsResult;
        
        public ListMedicamentsResponseBody() {
        }
        
        public ListMedicamentsResponseBody(WSClient.WSMedicament.VO_Medicament[] ListMedicamentsResult) {
            this.ListMedicamentsResult = ListMedicamentsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateMedicamentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateMedicament", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.WSMedicament.UpdateMedicamentRequestBody Body;
        
        public UpdateMedicamentRequest() {
        }
        
        public UpdateMedicamentRequest(WSClient.WSMedicament.UpdateMedicamentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateMedicamentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WSClient.WSMedicament.VO_Medicament medicament;
        
        public UpdateMedicamentRequestBody() {
        }
        
        public UpdateMedicamentRequestBody(WSClient.WSMedicament.VO_Medicament medicament) {
            this.medicament = medicament;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateMedicamentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateMedicamentResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.WSMedicament.UpdateMedicamentResponseBody Body;
        
        public UpdateMedicamentResponse() {
        }
        
        public UpdateMedicamentResponse(WSClient.WSMedicament.UpdateMedicamentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateMedicamentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UpdateMedicamentResult;
        
        public UpdateMedicamentResponseBody() {
        }
        
        public UpdateMedicamentResponseBody(string UpdateMedicamentResult) {
            this.UpdateMedicamentResult = UpdateMedicamentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteMedicamentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteMedicament", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.WSMedicament.DeleteMedicamentRequestBody Body;
        
        public DeleteMedicamentRequest() {
        }
        
        public DeleteMedicamentRequest(WSClient.WSMedicament.DeleteMedicamentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteMedicamentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idMedicament;
        
        public DeleteMedicamentRequestBody() {
        }
        
        public DeleteMedicamentRequestBody(int idMedicament) {
            this.idMedicament = idMedicament;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteMedicamentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteMedicamentResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.WSMedicament.DeleteMedicamentResponseBody Body;
        
        public DeleteMedicamentResponse() {
        }
        
        public DeleteMedicamentResponse(WSClient.WSMedicament.DeleteMedicamentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteMedicamentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DeleteMedicamentResult;
        
        public DeleteMedicamentResponseBody() {
        }
        
        public DeleteMedicamentResponseBody(string DeleteMedicamentResult) {
            this.DeleteMedicamentResult = DeleteMedicamentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMedicamentByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMedicamentById", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.WSMedicament.GetMedicamentByIdRequestBody Body;
        
        public GetMedicamentByIdRequest() {
        }
        
        public GetMedicamentByIdRequest(WSClient.WSMedicament.GetMedicamentByIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMedicamentByIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetMedicamentByIdRequestBody() {
        }
        
        public GetMedicamentByIdRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMedicamentByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMedicamentByIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.WSMedicament.GetMedicamentByIdResponseBody Body;
        
        public GetMedicamentByIdResponse() {
        }
        
        public GetMedicamentByIdResponse(WSClient.WSMedicament.GetMedicamentByIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMedicamentByIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WSClient.WSMedicament.VO_Medicament GetMedicamentByIdResult;
        
        public GetMedicamentByIdResponseBody() {
        }
        
        public GetMedicamentByIdResponseBody(WSClient.WSMedicament.VO_Medicament GetMedicamentByIdResult) {
            this.GetMedicamentByIdResult = GetMedicamentByIdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MedicamentServiceSoapChannel : WSClient.WSMedicament.MedicamentServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MedicamentServiceSoapClient : System.ServiceModel.ClientBase<WSClient.WSMedicament.MedicamentServiceSoap>, WSClient.WSMedicament.MedicamentServiceSoap {
        
        public MedicamentServiceSoapClient() {
        }
        
        public MedicamentServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MedicamentServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MedicamentServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MedicamentServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.WSMedicament.CreateMedicamentResponse WSClient.WSMedicament.MedicamentServiceSoap.CreateMedicament(WSClient.WSMedicament.CreateMedicamentRequest request) {
            return base.Channel.CreateMedicament(request);
        }
        
        public string CreateMedicament(WSClient.WSMedicament.VO_Medicament medicament) {
            WSClient.WSMedicament.CreateMedicamentRequest inValue = new WSClient.WSMedicament.CreateMedicamentRequest();
            inValue.Body = new WSClient.WSMedicament.CreateMedicamentRequestBody();
            inValue.Body.medicament = medicament;
            WSClient.WSMedicament.CreateMedicamentResponse retVal = ((WSClient.WSMedicament.MedicamentServiceSoap)(this)).CreateMedicament(inValue);
            return retVal.Body.CreateMedicamentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.WSMedicament.CreateMedicamentResponse> WSClient.WSMedicament.MedicamentServiceSoap.CreateMedicamentAsync(WSClient.WSMedicament.CreateMedicamentRequest request) {
            return base.Channel.CreateMedicamentAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.WSMedicament.CreateMedicamentResponse> CreateMedicamentAsync(WSClient.WSMedicament.VO_Medicament medicament) {
            WSClient.WSMedicament.CreateMedicamentRequest inValue = new WSClient.WSMedicament.CreateMedicamentRequest();
            inValue.Body = new WSClient.WSMedicament.CreateMedicamentRequestBody();
            inValue.Body.medicament = medicament;
            return ((WSClient.WSMedicament.MedicamentServiceSoap)(this)).CreateMedicamentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.WSMedicament.ListMedicamentsResponse WSClient.WSMedicament.MedicamentServiceSoap.ListMedicaments(WSClient.WSMedicament.ListMedicamentsRequest request) {
            return base.Channel.ListMedicaments(request);
        }
        
        public WSClient.WSMedicament.VO_Medicament[] ListMedicaments() {
            WSClient.WSMedicament.ListMedicamentsRequest inValue = new WSClient.WSMedicament.ListMedicamentsRequest();
            inValue.Body = new WSClient.WSMedicament.ListMedicamentsRequestBody();
            WSClient.WSMedicament.ListMedicamentsResponse retVal = ((WSClient.WSMedicament.MedicamentServiceSoap)(this)).ListMedicaments(inValue);
            return retVal.Body.ListMedicamentsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.WSMedicament.ListMedicamentsResponse> WSClient.WSMedicament.MedicamentServiceSoap.ListMedicamentsAsync(WSClient.WSMedicament.ListMedicamentsRequest request) {
            return base.Channel.ListMedicamentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.WSMedicament.ListMedicamentsResponse> ListMedicamentsAsync() {
            WSClient.WSMedicament.ListMedicamentsRequest inValue = new WSClient.WSMedicament.ListMedicamentsRequest();
            inValue.Body = new WSClient.WSMedicament.ListMedicamentsRequestBody();
            return ((WSClient.WSMedicament.MedicamentServiceSoap)(this)).ListMedicamentsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.WSMedicament.UpdateMedicamentResponse WSClient.WSMedicament.MedicamentServiceSoap.UpdateMedicament(WSClient.WSMedicament.UpdateMedicamentRequest request) {
            return base.Channel.UpdateMedicament(request);
        }
        
        public string UpdateMedicament(WSClient.WSMedicament.VO_Medicament medicament) {
            WSClient.WSMedicament.UpdateMedicamentRequest inValue = new WSClient.WSMedicament.UpdateMedicamentRequest();
            inValue.Body = new WSClient.WSMedicament.UpdateMedicamentRequestBody();
            inValue.Body.medicament = medicament;
            WSClient.WSMedicament.UpdateMedicamentResponse retVal = ((WSClient.WSMedicament.MedicamentServiceSoap)(this)).UpdateMedicament(inValue);
            return retVal.Body.UpdateMedicamentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.WSMedicament.UpdateMedicamentResponse> WSClient.WSMedicament.MedicamentServiceSoap.UpdateMedicamentAsync(WSClient.WSMedicament.UpdateMedicamentRequest request) {
            return base.Channel.UpdateMedicamentAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.WSMedicament.UpdateMedicamentResponse> UpdateMedicamentAsync(WSClient.WSMedicament.VO_Medicament medicament) {
            WSClient.WSMedicament.UpdateMedicamentRequest inValue = new WSClient.WSMedicament.UpdateMedicamentRequest();
            inValue.Body = new WSClient.WSMedicament.UpdateMedicamentRequestBody();
            inValue.Body.medicament = medicament;
            return ((WSClient.WSMedicament.MedicamentServiceSoap)(this)).UpdateMedicamentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.WSMedicament.DeleteMedicamentResponse WSClient.WSMedicament.MedicamentServiceSoap.DeleteMedicament(WSClient.WSMedicament.DeleteMedicamentRequest request) {
            return base.Channel.DeleteMedicament(request);
        }
        
        public string DeleteMedicament(int idMedicament) {
            WSClient.WSMedicament.DeleteMedicamentRequest inValue = new WSClient.WSMedicament.DeleteMedicamentRequest();
            inValue.Body = new WSClient.WSMedicament.DeleteMedicamentRequestBody();
            inValue.Body.idMedicament = idMedicament;
            WSClient.WSMedicament.DeleteMedicamentResponse retVal = ((WSClient.WSMedicament.MedicamentServiceSoap)(this)).DeleteMedicament(inValue);
            return retVal.Body.DeleteMedicamentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.WSMedicament.DeleteMedicamentResponse> WSClient.WSMedicament.MedicamentServiceSoap.DeleteMedicamentAsync(WSClient.WSMedicament.DeleteMedicamentRequest request) {
            return base.Channel.DeleteMedicamentAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.WSMedicament.DeleteMedicamentResponse> DeleteMedicamentAsync(int idMedicament) {
            WSClient.WSMedicament.DeleteMedicamentRequest inValue = new WSClient.WSMedicament.DeleteMedicamentRequest();
            inValue.Body = new WSClient.WSMedicament.DeleteMedicamentRequestBody();
            inValue.Body.idMedicament = idMedicament;
            return ((WSClient.WSMedicament.MedicamentServiceSoap)(this)).DeleteMedicamentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.WSMedicament.GetMedicamentByIdResponse WSClient.WSMedicament.MedicamentServiceSoap.GetMedicamentById(WSClient.WSMedicament.GetMedicamentByIdRequest request) {
            return base.Channel.GetMedicamentById(request);
        }
        
        public WSClient.WSMedicament.VO_Medicament GetMedicamentById(int id) {
            WSClient.WSMedicament.GetMedicamentByIdRequest inValue = new WSClient.WSMedicament.GetMedicamentByIdRequest();
            inValue.Body = new WSClient.WSMedicament.GetMedicamentByIdRequestBody();
            inValue.Body.id = id;
            WSClient.WSMedicament.GetMedicamentByIdResponse retVal = ((WSClient.WSMedicament.MedicamentServiceSoap)(this)).GetMedicamentById(inValue);
            return retVal.Body.GetMedicamentByIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.WSMedicament.GetMedicamentByIdResponse> WSClient.WSMedicament.MedicamentServiceSoap.GetMedicamentByIdAsync(WSClient.WSMedicament.GetMedicamentByIdRequest request) {
            return base.Channel.GetMedicamentByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.WSMedicament.GetMedicamentByIdResponse> GetMedicamentByIdAsync(int id) {
            WSClient.WSMedicament.GetMedicamentByIdRequest inValue = new WSClient.WSMedicament.GetMedicamentByIdRequest();
            inValue.Body = new WSClient.WSMedicament.GetMedicamentByIdRequestBody();
            inValue.Body.id = id;
            return ((WSClient.WSMedicament.MedicamentServiceSoap)(this)).GetMedicamentByIdAsync(inValue);
        }
    }
}
