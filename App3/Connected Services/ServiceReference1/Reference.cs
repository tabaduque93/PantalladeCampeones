﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 16.0.29728.190
// 
namespace App3.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.HistoricoPantallaSoap")]
    public interface HistoricoPantallaSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConectarDB", ReplyAction="*")]
        System.Threading.Tasks.Task<App3.ServiceReference1.ConectarDBResponse> ConectarDBAsync(App3.ServiceReference1.ConectarDBRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarHistorico", ReplyAction="*")]
        System.Threading.Tasks.Task<App3.ServiceReference1.InsertarHistoricoResponse> InsertarHistoricoAsync(App3.ServiceReference1.InsertarHistoricoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConectarDBRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConectarDB", Namespace="http://tempuri.org/", Order=0)]
        public App3.ServiceReference1.ConectarDBRequestBody Body;
        
        public ConectarDBRequest() {
        }
        
        public ConectarDBRequest(App3.ServiceReference1.ConectarDBRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ConectarDBRequestBody {
        
        public ConectarDBRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConectarDBResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConectarDBResponse", Namespace="http://tempuri.org/", Order=0)]
        public App3.ServiceReference1.ConectarDBResponseBody Body;
        
        public ConectarDBResponse() {
        }
        
        public ConectarDBResponse(App3.ServiceReference1.ConectarDBResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConectarDBResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConectarDBResult;
        
        public ConectarDBResponseBody() {
        }
        
        public ConectarDBResponseBody(string ConectarDBResult) {
            this.ConectarDBResult = ConectarDBResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarHistoricoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarHistorico", Namespace="http://tempuri.org/", Order=0)]
        public App3.ServiceReference1.InsertarHistoricoRequestBody Body;
        
        public InsertarHistoricoRequest() {
        }
        
        public InsertarHistoricoRequest(App3.ServiceReference1.InsertarHistoricoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarHistoricoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id_dispositivo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int id_jugador;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string correo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string pathimagen;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string pathvideo;
        
        public InsertarHistoricoRequestBody() {
        }
        
        public InsertarHistoricoRequestBody(int id_dispositivo, int id_jugador, string correo, string pathimagen, string pathvideo) {
            this.id_dispositivo = id_dispositivo;
            this.id_jugador = id_jugador;
            this.correo = correo;
            this.pathimagen = pathimagen;
            this.pathvideo = pathvideo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarHistoricoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarHistoricoResponse", Namespace="http://tempuri.org/", Order=0)]
        public App3.ServiceReference1.InsertarHistoricoResponseBody Body;
        
        public InsertarHistoricoResponse() {
        }
        
        public InsertarHistoricoResponse(App3.ServiceReference1.InsertarHistoricoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarHistoricoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertarHistoricoResult;
        
        public InsertarHistoricoResponseBody() {
        }
        
        public InsertarHistoricoResponseBody(string InsertarHistoricoResult) {
            this.InsertarHistoricoResult = InsertarHistoricoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HistoricoPantallaSoapChannel : App3.ServiceReference1.HistoricoPantallaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HistoricoPantallaSoapClient : System.ServiceModel.ClientBase<App3.ServiceReference1.HistoricoPantallaSoap>, App3.ServiceReference1.HistoricoPantallaSoap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public HistoricoPantallaSoapClient() : 
                base(HistoricoPantallaSoapClient.GetDefaultBinding(), HistoricoPantallaSoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.HistoricoPantallaSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HistoricoPantallaSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(HistoricoPantallaSoapClient.GetBindingForEndpoint(endpointConfiguration), HistoricoPantallaSoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HistoricoPantallaSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(HistoricoPantallaSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HistoricoPantallaSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(HistoricoPantallaSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HistoricoPantallaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<App3.ServiceReference1.ConectarDBResponse> App3.ServiceReference1.HistoricoPantallaSoap.ConectarDBAsync(App3.ServiceReference1.ConectarDBRequest request) {
            return base.Channel.ConectarDBAsync(request);
        }
        
        public System.Threading.Tasks.Task<App3.ServiceReference1.ConectarDBResponse> ConectarDBAsync() {
            App3.ServiceReference1.ConectarDBRequest inValue = new App3.ServiceReference1.ConectarDBRequest();
            inValue.Body = new App3.ServiceReference1.ConectarDBRequestBody();
            return ((App3.ServiceReference1.HistoricoPantallaSoap)(this)).ConectarDBAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<App3.ServiceReference1.InsertarHistoricoResponse> App3.ServiceReference1.HistoricoPantallaSoap.InsertarHistoricoAsync(App3.ServiceReference1.InsertarHistoricoRequest request) {
            return base.Channel.InsertarHistoricoAsync(request);
        }
        
        public System.Threading.Tasks.Task<App3.ServiceReference1.InsertarHistoricoResponse> InsertarHistoricoAsync(int id_dispositivo, int id_jugador, string correo, string pathimagen, string pathvideo) {
            App3.ServiceReference1.InsertarHistoricoRequest inValue = new App3.ServiceReference1.InsertarHistoricoRequest();
            inValue.Body = new App3.ServiceReference1.InsertarHistoricoRequestBody();
            inValue.Body.id_dispositivo = id_dispositivo;
            inValue.Body.id_jugador = id_jugador;
            inValue.Body.correo = correo;
            inValue.Body.pathimagen = pathimagen;
            inValue.Body.pathvideo = pathvideo;
            return ((App3.ServiceReference1.HistoricoPantallaSoap)(this)).InsertarHistoricoAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.HistoricoPantallaSoap)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.HistoricoPantallaSoap)) {
                return new System.ServiceModel.EndpointAddress("http://awserver1.sistra.com.co/wspantallajunior/HistoricoPantalla.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return HistoricoPantallaSoapClient.GetBindingForEndpoint(EndpointConfiguration.HistoricoPantallaSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return HistoricoPantallaSoapClient.GetEndpointAddress(EndpointConfiguration.HistoricoPantallaSoap);
        }
        
        public enum EndpointConfiguration {
            
            HistoricoPantallaSoap,
        }
    }
}
