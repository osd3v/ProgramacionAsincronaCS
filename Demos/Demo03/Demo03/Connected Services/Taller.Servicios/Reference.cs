﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo03.Taller.Servicios {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="beProducto", Namespace="http://schemas.datacontract.org/2004/07/Northwind.Librerias.EntidadesNegocio")]
    [System.SerializableAttribute()]
    public partial class beProducto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short StockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idCategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProveedorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idCategoria {
            get {
                return this.idCategoriaField;
            }
            set {
                if ((this.idCategoriaField.Equals(value) != true)) {
                    this.idCategoriaField = value;
                    this.RaisePropertyChanged("idCategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idProducto {
            get {
                return this.idProductoField;
            }
            set {
                if ((this.idProductoField.Equals(value) != true)) {
                    this.idProductoField = value;
                    this.RaisePropertyChanged("idProducto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idProveedor {
            get {
                return this.idProveedorField;
            }
            set {
                if ((this.idProveedorField.Equals(value) != true)) {
                    this.idProveedorField = value;
                    this.RaisePropertyChanged("idProveedor");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Taller.Servicios.IProducto")]
    public interface IProducto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/Listar", ReplyAction="http://tempuri.org/IProducto/ListarResponse")]
        System.Collections.Generic.List<Demo03.Taller.Servicios.beProducto> Listar();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProducto/Listar", ReplyAction="http://tempuri.org/IProducto/ListarResponse")]
        System.IAsyncResult BeginListar(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<Demo03.Taller.Servicios.beProducto> EndListar(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductoChannel : Demo03.Taller.Servicios.IProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ListarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ListarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<Demo03.Taller.Servicios.beProducto> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<Demo03.Taller.Servicios.beProducto>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductoClient : System.ServiceModel.ClientBase<Demo03.Taller.Servicios.IProducto>, Demo03.Taller.Servicios.IProducto {
        
        private BeginOperationDelegate onBeginListarDelegate;
        
        private EndOperationDelegate onEndListarDelegate;
        
        private System.Threading.SendOrPostCallback onListarCompletedDelegate;
        
        public ProductoClient() {
        }
        
        public ProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<ListarCompletedEventArgs> ListarCompleted;
        
        public System.Collections.Generic.List<Demo03.Taller.Servicios.beProducto> Listar() {
            return base.Channel.Listar();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginListar(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginListar(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.List<Demo03.Taller.Servicios.beProducto> EndListar(System.IAsyncResult result) {
            return base.Channel.EndListar(result);
        }
        
        private System.IAsyncResult OnBeginListar(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginListar(callback, asyncState);
        }
        
        private object[] OnEndListar(System.IAsyncResult result) {
            System.Collections.Generic.List<Demo03.Taller.Servicios.beProducto> retVal = this.EndListar(result);
            return new object[] {
                    retVal};
        }
        
        private void OnListarCompleted(object state) {
            if ((this.ListarCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ListarCompleted(this, new ListarCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ListarAsync() {
            this.ListarAsync(null);
        }
        
        public void ListarAsync(object userState) {
            if ((this.onBeginListarDelegate == null)) {
                this.onBeginListarDelegate = new BeginOperationDelegate(this.OnBeginListar);
            }
            if ((this.onEndListarDelegate == null)) {
                this.onEndListarDelegate = new EndOperationDelegate(this.OnEndListar);
            }
            if ((this.onListarCompletedDelegate == null)) {
                this.onListarCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnListarCompleted);
            }
            base.InvokeAsync(this.onBeginListarDelegate, null, this.onEndListarDelegate, this.onListarCompletedDelegate, userState);
        }
    }
}