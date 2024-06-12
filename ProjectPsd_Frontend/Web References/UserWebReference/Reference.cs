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

namespace ProjectPsd_Frontend.UserWebReference {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="UserWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class UserWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAllUsersOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidateUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UserWebService() {
            this.Url = global::ProjectPsd_Frontend.Properties.Settings.Default.ProjectPsd_Frontend_UserWebReference_UserWebService;
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
        public event GetAllUsersCompletedEventHandler GetAllUsersCompleted;
        
        /// <remarks/>
        public event InsertUserCompletedEventHandler InsertUserCompleted;
        
        /// <remarks/>
        public event ValidateUserCompletedEventHandler ValidateUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllUsers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllUsers() {
            object[] results = this.Invoke("GetAllUsers", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllUsersAsync() {
            this.GetAllUsersAsync(null);
        }
        
        /// <remarks/>
        public void GetAllUsersAsync(object userState) {
            if ((this.GetAllUsersOperationCompleted == null)) {
                this.GetAllUsersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllUsersOperationCompleted);
            }
            this.InvokeAsync("GetAllUsers", new object[0], this.GetAllUsersOperationCompleted, userState);
        }
        
        private void OnGetAllUsersOperationCompleted(object arg) {
            if ((this.GetAllUsersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllUsersCompleted(this, new GetAllUsersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertUser(string username, string email, string gender, string password, System.DateTime birth) {
            object[] results = this.Invoke("InsertUser", new object[] {
                        username,
                        email,
                        gender,
                        password,
                        birth});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertUserAsync(string username, string email, string gender, string password, System.DateTime birth) {
            this.InsertUserAsync(username, email, gender, password, birth, null);
        }
        
        /// <remarks/>
        public void InsertUserAsync(string username, string email, string gender, string password, System.DateTime birth, object userState) {
            if ((this.InsertUserOperationCompleted == null)) {
                this.InsertUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertUserOperationCompleted);
            }
            this.InvokeAsync("InsertUser", new object[] {
                        username,
                        email,
                        gender,
                        password,
                        birth}, this.InsertUserOperationCompleted, userState);
        }
        
        private void OnInsertUserOperationCompleted(object arg) {
            if ((this.InsertUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertUserCompleted(this, new InsertUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ValidateUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ValidateUser(string username, string password) {
            object[] results = this.Invoke("ValidateUser", new object[] {
                        username,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ValidateUserAsync(string username, string password) {
            this.ValidateUserAsync(username, password, null);
        }
        
        /// <remarks/>
        public void ValidateUserAsync(string username, string password, object userState) {
            if ((this.ValidateUserOperationCompleted == null)) {
                this.ValidateUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidateUserOperationCompleted);
            }
            this.InvokeAsync("ValidateUser", new object[] {
                        username,
                        password}, this.ValidateUserOperationCompleted, userState);
        }
        
        private void OnValidateUserOperationCompleted(object arg) {
            if ((this.ValidateUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidateUserCompleted(this, new ValidateUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void GetAllUsersCompletedEventHandler(object sender, GetAllUsersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void InsertUserCompletedEventHandler(object sender, InsertUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void ValidateUserCompletedEventHandler(object sender, ValidateUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidateUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidateUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591