﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LemonWayTest.WinFormApp.ServiceReferenceLemonWay {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceLemonWay.LemonWayServiceSoap")]
    public interface LemonWayServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        int Fibonacci(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FibonacciAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FibonacciWithSleep", ReplyAction="*")]
        int FibonacciWithSleep(int n, int sleep);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FibonacciWithSleep", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FibonacciWithSleepAsync(int n, int sleep);
        
        // CODEGEN: Generating message contract since element name xml from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonResponse XmlToJson(LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        System.Threading.Tasks.Task<LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonResponse> XmlToJsonAsync(LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://tempuri.org/", Order=0)]
        public LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LemonWayServiceSoapChannel : LemonWayTest.WinFormApp.ServiceReferenceLemonWay.LemonWayServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LemonWayServiceSoapClient : System.ServiceModel.ClientBase<LemonWayTest.WinFormApp.ServiceReferenceLemonWay.LemonWayServiceSoap>, LemonWayTest.WinFormApp.ServiceReferenceLemonWay.LemonWayServiceSoap {
        
        public LemonWayServiceSoapClient() {
        }
        
        public LemonWayServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LemonWayServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LemonWayServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LemonWayServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Fibonacci(int n) {
            return base.Channel.Fibonacci(n);
        }
        
        public System.Threading.Tasks.Task<int> FibonacciAsync(int n) {
            return base.Channel.FibonacciAsync(n);
        }
        
        public int FibonacciWithSleep(int n, int sleep) {
            return base.Channel.FibonacciWithSleep(n, sleep);
        }
        
        public System.Threading.Tasks.Task<int> FibonacciWithSleepAsync(int n, int sleep) {
            return base.Channel.FibonacciWithSleepAsync(n, sleep);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonResponse LemonWayTest.WinFormApp.ServiceReferenceLemonWay.LemonWayServiceSoap.XmlToJson(LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string xml) {
            LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequest inValue = new LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequest();
            inValue.Body = new LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonResponse retVal = ((LemonWayTest.WinFormApp.ServiceReferenceLemonWay.LemonWayServiceSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonResponse> LemonWayTest.WinFormApp.ServiceReferenceLemonWay.LemonWayServiceSoap.XmlToJsonAsync(LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequest request) {
            return base.Channel.XmlToJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonResponse> XmlToJsonAsync(string xml) {
            LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequest inValue = new LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequest();
            inValue.Body = new LemonWayTest.WinFormApp.ServiceReferenceLemonWay.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            return ((LemonWayTest.WinFormApp.ServiceReferenceLemonWay.LemonWayServiceSoap)(this)).XmlToJsonAsync(inValue);
        }
    }
}
