﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIndividual.Pruebas.PrimerServicio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PrimerServicio.PrimerServicioSoap")]
    public interface PrimerServicioSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        PIndividual.Pruebas.PrimerServicio.HelloWorldResponse HelloWorld(PIndividual.Pruebas.PrimerServicio.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<PIndividual.Pruebas.PrimerServicio.HelloWorldResponse> HelloWorldAsync(PIndividual.Pruebas.PrimerServicio.HelloWorldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public PIndividual.Pruebas.PrimerServicio.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(PIndividual.Pruebas.PrimerServicio.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public PIndividual.Pruebas.PrimerServicio.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(PIndividual.Pruebas.PrimerServicio.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PrimerServicioSoapChannel : PIndividual.Pruebas.PrimerServicio.PrimerServicioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrimerServicioSoapClient : System.ServiceModel.ClientBase<PIndividual.Pruebas.PrimerServicio.PrimerServicioSoap>, PIndividual.Pruebas.PrimerServicio.PrimerServicioSoap {
        
        public PrimerServicioSoapClient() {
        }
        
        public PrimerServicioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrimerServicioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrimerServicioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrimerServicioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PIndividual.Pruebas.PrimerServicio.HelloWorldResponse PIndividual.Pruebas.PrimerServicio.PrimerServicioSoap.HelloWorld(PIndividual.Pruebas.PrimerServicio.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            PIndividual.Pruebas.PrimerServicio.HelloWorldRequest inValue = new PIndividual.Pruebas.PrimerServicio.HelloWorldRequest();
            inValue.Body = new PIndividual.Pruebas.PrimerServicio.HelloWorldRequestBody();
            PIndividual.Pruebas.PrimerServicio.HelloWorldResponse retVal = ((PIndividual.Pruebas.PrimerServicio.PrimerServicioSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PIndividual.Pruebas.PrimerServicio.HelloWorldResponse> PIndividual.Pruebas.PrimerServicio.PrimerServicioSoap.HelloWorldAsync(PIndividual.Pruebas.PrimerServicio.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<PIndividual.Pruebas.PrimerServicio.HelloWorldResponse> HelloWorldAsync() {
            PIndividual.Pruebas.PrimerServicio.HelloWorldRequest inValue = new PIndividual.Pruebas.PrimerServicio.HelloWorldRequest();
            inValue.Body = new PIndividual.Pruebas.PrimerServicio.HelloWorldRequestBody();
            return ((PIndividual.Pruebas.PrimerServicio.PrimerServicioSoap)(this)).HelloWorldAsync(inValue);
        }
    }
}
