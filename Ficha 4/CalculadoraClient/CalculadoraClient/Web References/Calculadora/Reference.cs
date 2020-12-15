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

namespace CalculadoraClient.Calculadora {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CalculadoraSoap", Namespace="http://ficha_4_calculadora.pt/")]
    public partial class Calculadora : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AdicaoOperationCompleted;
        
        private System.Threading.SendOrPostCallback SubtracaoOperationCompleted;
        
        private System.Threading.SendOrPostCallback MultiplicacaoOperationCompleted;
        
        private System.Threading.SendOrPostCallback DivisaoOperationCompleted;
        
        private System.Threading.SendOrPostCallback FactorialOperationCompleted;
        
        private System.Threading.SendOrPostCallback PotenciaOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValorAbsolutoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Calculadora() {
            this.Url = global::CalculadoraClient.Properties.Settings.Default.CalculadoraClient_Calculadora_Calculadora;
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
        public event AdicaoCompletedEventHandler AdicaoCompleted;
        
        /// <remarks/>
        public event SubtracaoCompletedEventHandler SubtracaoCompleted;
        
        /// <remarks/>
        public event MultiplicacaoCompletedEventHandler MultiplicacaoCompleted;
        
        /// <remarks/>
        public event DivisaoCompletedEventHandler DivisaoCompleted;
        
        /// <remarks/>
        public event FactorialCompletedEventHandler FactorialCompleted;
        
        /// <remarks/>
        public event PotenciaCompletedEventHandler PotenciaCompleted;
        
        /// <remarks/>
        public event ValorAbsolutoCompletedEventHandler ValorAbsolutoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ficha_4_calculadora.pt/Adicao", RequestNamespace="http://ficha_4_calculadora.pt/", ResponseNamespace="http://ficha_4_calculadora.pt/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Adicao(int a, int b) {
            object[] results = this.Invoke("Adicao", new object[] {
                        a,
                        b});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AdicaoAsync(int a, int b) {
            this.AdicaoAsync(a, b, null);
        }
        
        /// <remarks/>
        public void AdicaoAsync(int a, int b, object userState) {
            if ((this.AdicaoOperationCompleted == null)) {
                this.AdicaoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAdicaoOperationCompleted);
            }
            this.InvokeAsync("Adicao", new object[] {
                        a,
                        b}, this.AdicaoOperationCompleted, userState);
        }
        
        private void OnAdicaoOperationCompleted(object arg) {
            if ((this.AdicaoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AdicaoCompleted(this, new AdicaoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ficha_4_calculadora.pt/Subtracao", RequestNamespace="http://ficha_4_calculadora.pt/", ResponseNamespace="http://ficha_4_calculadora.pt/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Subtracao(int a, int b) {
            object[] results = this.Invoke("Subtracao", new object[] {
                        a,
                        b});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SubtracaoAsync(int a, int b) {
            this.SubtracaoAsync(a, b, null);
        }
        
        /// <remarks/>
        public void SubtracaoAsync(int a, int b, object userState) {
            if ((this.SubtracaoOperationCompleted == null)) {
                this.SubtracaoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubtracaoOperationCompleted);
            }
            this.InvokeAsync("Subtracao", new object[] {
                        a,
                        b}, this.SubtracaoOperationCompleted, userState);
        }
        
        private void OnSubtracaoOperationCompleted(object arg) {
            if ((this.SubtracaoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubtracaoCompleted(this, new SubtracaoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ficha_4_calculadora.pt/Multiplicacao", RequestNamespace="http://ficha_4_calculadora.pt/", ResponseNamespace="http://ficha_4_calculadora.pt/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Multiplicacao(int a, int b) {
            object[] results = this.Invoke("Multiplicacao", new object[] {
                        a,
                        b});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void MultiplicacaoAsync(int a, int b) {
            this.MultiplicacaoAsync(a, b, null);
        }
        
        /// <remarks/>
        public void MultiplicacaoAsync(int a, int b, object userState) {
            if ((this.MultiplicacaoOperationCompleted == null)) {
                this.MultiplicacaoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMultiplicacaoOperationCompleted);
            }
            this.InvokeAsync("Multiplicacao", new object[] {
                        a,
                        b}, this.MultiplicacaoOperationCompleted, userState);
        }
        
        private void OnMultiplicacaoOperationCompleted(object arg) {
            if ((this.MultiplicacaoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MultiplicacaoCompleted(this, new MultiplicacaoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ficha_4_calculadora.pt/Divisao", RequestNamespace="http://ficha_4_calculadora.pt/", ResponseNamespace="http://ficha_4_calculadora.pt/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public float Divisao(int a, int b) {
            object[] results = this.Invoke("Divisao", new object[] {
                        a,
                        b});
            return ((float)(results[0]));
        }
        
        /// <remarks/>
        public void DivisaoAsync(int a, int b) {
            this.DivisaoAsync(a, b, null);
        }
        
        /// <remarks/>
        public void DivisaoAsync(int a, int b, object userState) {
            if ((this.DivisaoOperationCompleted == null)) {
                this.DivisaoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDivisaoOperationCompleted);
            }
            this.InvokeAsync("Divisao", new object[] {
                        a,
                        b}, this.DivisaoOperationCompleted, userState);
        }
        
        private void OnDivisaoOperationCompleted(object arg) {
            if ((this.DivisaoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DivisaoCompleted(this, new DivisaoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ficha_4_calculadora.pt/Factorial", RequestNamespace="http://ficha_4_calculadora.pt/", ResponseNamespace="http://ficha_4_calculadora.pt/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Factorial(int a) {
            object[] results = this.Invoke("Factorial", new object[] {
                        a});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void FactorialAsync(int a) {
            this.FactorialAsync(a, null);
        }
        
        /// <remarks/>
        public void FactorialAsync(int a, object userState) {
            if ((this.FactorialOperationCompleted == null)) {
                this.FactorialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFactorialOperationCompleted);
            }
            this.InvokeAsync("Factorial", new object[] {
                        a}, this.FactorialOperationCompleted, userState);
        }
        
        private void OnFactorialOperationCompleted(object arg) {
            if ((this.FactorialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FactorialCompleted(this, new FactorialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ficha_4_calculadora.pt/Potencia", RequestNamespace="http://ficha_4_calculadora.pt/", ResponseNamespace="http://ficha_4_calculadora.pt/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double Potencia(double num, double exp) {
            object[] results = this.Invoke("Potencia", new object[] {
                        num,
                        exp});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void PotenciaAsync(double num, double exp) {
            this.PotenciaAsync(num, exp, null);
        }
        
        /// <remarks/>
        public void PotenciaAsync(double num, double exp, object userState) {
            if ((this.PotenciaOperationCompleted == null)) {
                this.PotenciaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPotenciaOperationCompleted);
            }
            this.InvokeAsync("Potencia", new object[] {
                        num,
                        exp}, this.PotenciaOperationCompleted, userState);
        }
        
        private void OnPotenciaOperationCompleted(object arg) {
            if ((this.PotenciaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PotenciaCompleted(this, new PotenciaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ficha_4_calculadora.pt/ValorAbsoluto", RequestNamespace="http://ficha_4_calculadora.pt/", ResponseNamespace="http://ficha_4_calculadora.pt/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double ValorAbsoluto(int a) {
            object[] results = this.Invoke("ValorAbsoluto", new object[] {
                        a});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void ValorAbsolutoAsync(int a) {
            this.ValorAbsolutoAsync(a, null);
        }
        
        /// <remarks/>
        public void ValorAbsolutoAsync(int a, object userState) {
            if ((this.ValorAbsolutoOperationCompleted == null)) {
                this.ValorAbsolutoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValorAbsolutoOperationCompleted);
            }
            this.InvokeAsync("ValorAbsoluto", new object[] {
                        a}, this.ValorAbsolutoOperationCompleted, userState);
        }
        
        private void OnValorAbsolutoOperationCompleted(object arg) {
            if ((this.ValorAbsolutoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValorAbsolutoCompleted(this, new ValorAbsolutoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void AdicaoCompletedEventHandler(object sender, AdicaoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AdicaoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AdicaoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void SubtracaoCompletedEventHandler(object sender, SubtracaoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubtracaoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SubtracaoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void MultiplicacaoCompletedEventHandler(object sender, MultiplicacaoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MultiplicacaoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MultiplicacaoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void DivisaoCompletedEventHandler(object sender, DivisaoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DivisaoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DivisaoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public float Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void FactorialCompletedEventHandler(object sender, FactorialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FactorialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FactorialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void PotenciaCompletedEventHandler(object sender, PotenciaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PotenciaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PotenciaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void ValorAbsolutoCompletedEventHandler(object sender, ValorAbsolutoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValorAbsolutoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValorAbsolutoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591