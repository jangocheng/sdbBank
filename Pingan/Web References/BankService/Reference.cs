﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace Pingan.BankService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BankServiceSoap11Binding", Namespace="http://webservice.bank.com")]
    public partial class BankService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback sayHelloOperationCompleted;
        
        private System.Threading.SendOrPostCallback JavaRsaVerifyDecodeOperationCompleted;
        
        private System.Threading.SendOrPostCallback JavaRsaVerifyOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BankService() {
            this.Url = global::Pingan.Properties.Settings.Default.Pingan_BankService_BankService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event sayHelloCompletedEventHandler sayHelloCompleted;
        
        /// <remarks/>
        public event JavaRsaVerifyDecodeCompletedEventHandler JavaRsaVerifyDecodeCompleted;
        
        /// <remarks/>
        public event JavaRsaVerifyCompletedEventHandler JavaRsaVerifyCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sayHello", RequestNamespace="http://webservice.bank.com", ResponseNamespace="http://webservice.bank.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string sayHello([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string name) {
            object[] results = this.Invoke("sayHello", new object[] {
                        name});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void sayHelloAsync(string name) {
            this.sayHelloAsync(name, null);
        }
        
        /// <remarks/>
        public void sayHelloAsync(string name, object userState) {
            if ((this.sayHelloOperationCompleted == null)) {
                this.sayHelloOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsayHelloOperationCompleted);
            }
            this.InvokeAsync("sayHello", new object[] {
                        name}, this.sayHelloOperationCompleted, userState);
        }
        
        private void OnsayHelloOperationCompleted(object arg) {
            if ((this.sayHelloCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sayHelloCompleted(this, new sayHelloCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:JavaRsaVerifyDecode", RequestNamespace="http://webservice.bank.com", ResponseNamespace="http://webservice.bank.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public bool JavaRsaVerifyDecode([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string orig, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string sign) {
            object[] results = this.Invoke("JavaRsaVerifyDecode", new object[] {
                        orig,
                        sign});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void JavaRsaVerifyDecodeAsync(string orig, string sign) {
            this.JavaRsaVerifyDecodeAsync(orig, sign, null);
        }
        
        /// <remarks/>
        public void JavaRsaVerifyDecodeAsync(string orig, string sign, object userState) {
            if ((this.JavaRsaVerifyDecodeOperationCompleted == null)) {
                this.JavaRsaVerifyDecodeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnJavaRsaVerifyDecodeOperationCompleted);
            }
            this.InvokeAsync("JavaRsaVerifyDecode", new object[] {
                        orig,
                        sign}, this.JavaRsaVerifyDecodeOperationCompleted, userState);
        }
        
        private void OnJavaRsaVerifyDecodeOperationCompleted(object arg) {
            if ((this.JavaRsaVerifyDecodeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.JavaRsaVerifyDecodeCompleted(this, new JavaRsaVerifyDecodeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:JavaRsaVerify", RequestNamespace="http://webservice.bank.com", ResponseNamespace="http://webservice.bank.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public bool JavaRsaVerify([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string orig, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string sign) {
            object[] results = this.Invoke("JavaRsaVerify", new object[] {
                        orig,
                        sign});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void JavaRsaVerifyAsync(string orig, string sign) {
            this.JavaRsaVerifyAsync(orig, sign, null);
        }
        
        /// <remarks/>
        public void JavaRsaVerifyAsync(string orig, string sign, object userState) {
            if ((this.JavaRsaVerifyOperationCompleted == null)) {
                this.JavaRsaVerifyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnJavaRsaVerifyOperationCompleted);
            }
            this.InvokeAsync("JavaRsaVerify", new object[] {
                        orig,
                        sign}, this.JavaRsaVerifyOperationCompleted, userState);
        }
        
        private void OnJavaRsaVerifyOperationCompleted(object arg) {
            if ((this.JavaRsaVerifyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.JavaRsaVerifyCompleted(this, new JavaRsaVerifyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void sayHelloCompletedEventHandler(object sender, sayHelloCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sayHelloCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sayHelloCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void JavaRsaVerifyDecodeCompletedEventHandler(object sender, JavaRsaVerifyDecodeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class JavaRsaVerifyDecodeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal JavaRsaVerifyDecodeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void JavaRsaVerifyCompletedEventHandler(object sender, JavaRsaVerifyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class JavaRsaVerifyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal JavaRsaVerifyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591