﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebDataSetClient.localhost_insert {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceDataSetSoap", Namespace="http://tempuri.org/")]
    public partial class WebServiceDataSet : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetDataSetOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateDataSetOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertDataSetOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebServiceDataSet() {
            this.Url = global::WebDataSetClient.Properties.Settings.Default.WebDataSetClient_localhost_WebServiceDataSet;
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
        public event GetDataSetCompletedEventHandler GetDataSetCompleted;
        
        /// <remarks/>
        public event UpdateDataSetCompletedEventHandler UpdateDataSetCompleted;
        
        /// <remarks/>
        public event InsertDataSetCompletedEventHandler InsertDataSetCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDataSet", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetDataSet() {
            object[] results = this.Invoke("GetDataSet", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataSetAsync() {
            this.GetDataSetAsync(null);
        }
        
        /// <remarks/>
        public void GetDataSetAsync(object userState) {
            if ((this.GetDataSetOperationCompleted == null)) {
                this.GetDataSetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataSetOperationCompleted);
            }
            this.InvokeAsync("GetDataSet", new object[0], this.GetDataSetOperationCompleted, userState);
        }
        
        private void OnGetDataSetOperationCompleted(object arg) {
            if ((this.GetDataSetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataSetCompleted(this, new GetDataSetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateDataSet", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateDataSet(System.Data.DataSet ds) {
            this.Invoke("UpdateDataSet", new object[] {
                        ds});
        }
        
        /// <remarks/>
        public void UpdateDataSetAsync(System.Data.DataSet ds) {
            this.UpdateDataSetAsync(ds, null);
        }
        
        /// <remarks/>
        public void UpdateDataSetAsync(System.Data.DataSet ds, object userState) {
            if ((this.UpdateDataSetOperationCompleted == null)) {
                this.UpdateDataSetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateDataSetOperationCompleted);
            }
            this.InvokeAsync("UpdateDataSet", new object[] {
                        ds}, this.UpdateDataSetOperationCompleted, userState);
        }
        
        private void OnUpdateDataSetOperationCompleted(object arg) {
            if ((this.UpdateDataSetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateDataSetCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertDataSet", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void InsertDataSet(System.Data.DataSet ds) {
            this.Invoke("InsertDataSet", new object[] {
                        ds});
        }
        
        /// <remarks/>
        public void InsertDataSetAsync(System.Data.DataSet ds) {
            this.InsertDataSetAsync(ds, null);
        }
        
        /// <remarks/>
        public void InsertDataSetAsync(System.Data.DataSet ds, object userState) {
            if ((this.InsertDataSetOperationCompleted == null)) {
                this.InsertDataSetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertDataSetOperationCompleted);
            }
            this.InvokeAsync("InsertDataSet", new object[] {
                        ds}, this.InsertDataSetOperationCompleted, userState);
        }
        
        private void OnInsertDataSetOperationCompleted(object arg) {
            if ((this.InsertDataSetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertDataSetCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void GetDataSetCompletedEventHandler(object sender, GetDataSetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataSetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataSetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void UpdateDataSetCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void InsertDataSetCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591