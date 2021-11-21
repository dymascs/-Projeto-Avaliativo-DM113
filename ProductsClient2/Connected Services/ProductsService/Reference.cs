﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductsClient2.ProductsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductData", Namespace="http://schemas.datacontract.org/2004/07/Products")]
    [System.SerializableAttribute()]
    public partial class ProductData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstoqueProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroProdutoField;
        
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
        public string DescricaoProduto {
            get {
                return this.DescricaoProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoProdutoField, value) != true)) {
                    this.DescricaoProdutoField = value;
                    this.RaisePropertyChanged("DescricaoProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstoqueProduto {
            get {
                return this.EstoqueProdutoField;
            }
            set {
                if ((this.EstoqueProdutoField.Equals(value) != true)) {
                    this.EstoqueProdutoField = value;
                    this.RaisePropertyChanged("EstoqueProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroProduto {
            get {
                return this.NumeroProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroProdutoField, value) != true)) {
                    this.NumeroProdutoField = value;
                    this.RaisePropertyChanged("NumeroProduto");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/02", ConfigurationName="ProductsService.IProductsService2")]
    public interface IProductsService2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IProductsService2/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IProductsService2/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IProductsService2/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IProductsService2/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IProductsService2/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IProductsService2/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IProductsService2/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IProductsService2/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IProductsService2/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IProductsService2/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IProductsService2/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IProductsService2/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsService2Channel : ProductsClient2.ProductsService.IProductsService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsService2Client : System.ServiceModel.ClientBase<ProductsClient2.ProductsService.IProductsService2>, ProductsClient2.ProductsService.IProductsService2 {
        
        public ProductsService2Client() {
        }
        
        public ProductsService2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsService2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsService2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsService2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AdicionarEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.AdicionarEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.AdicionarEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public bool RemoverEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public int ConsultarEstoque(string NumeroProduto) {
            return base.Channel.ConsultarEstoque(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(NumeroProduto);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/01", ConfigurationName="ProductsService.IProductsService")]
    public interface IProductsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/ListarProdutosResponse")]
        string[] ListarProdutos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/ListarProdutosResponse")]
        System.Threading.Tasks.Task<string[]> ListarProdutosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/IncluirProdutoResponse")]
        bool IncluirProduto(ProductsClient2.ProductsService.ProductData produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/IncluirProdutoResponse")]
        System.Threading.Tasks.Task<bool> IncluirProdutoAsync(ProductsClient2.ProductsService.ProductData produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/RemoverProdutoResponse")]
        bool RemoverProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/RemoverProdutoResponse")]
        System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/VerProdutoResponse")]
        ProductsClient2.ProductsService.ProductData VerProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IProductsService/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IProductsService/VerProdutoResponse")]
        System.Threading.Tasks.Task<ProductsClient2.ProductsService.ProductData> VerProdutoAsync(string NumeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsServiceChannel : ProductsClient2.ProductsService.IProductsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsServiceClient : System.ServiceModel.ClientBase<ProductsClient2.ProductsService.IProductsService>, ProductsClient2.ProductsService.IProductsService {
        
        public ProductsServiceClient() {
        }
        
        public ProductsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListarProdutos() {
            return base.Channel.ListarProdutos();
        }
        
        public System.Threading.Tasks.Task<string[]> ListarProdutosAsync() {
            return base.Channel.ListarProdutosAsync();
        }
        
        public bool IncluirProduto(ProductsClient2.ProductsService.ProductData produto) {
            return base.Channel.IncluirProduto(produto);
        }
        
        public System.Threading.Tasks.Task<bool> IncluirProdutoAsync(ProductsClient2.ProductsService.ProductData produto) {
            return base.Channel.IncluirProdutoAsync(produto);
        }
        
        public bool RemoverProduto(string NumeroProduto) {
            return base.Channel.RemoverProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto) {
            return base.Channel.RemoverProdutoAsync(NumeroProduto);
        }
        
        public int ConsultarEstoque(string NumeroProduto) {
            return base.Channel.ConsultarEstoque(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(NumeroProduto);
        }
        
        public bool AdicionarEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.AdicionarEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.AdicionarEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public bool RemoverEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public ProductsClient2.ProductsService.ProductData VerProduto(string NumeroProduto) {
            return base.Channel.VerProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<ProductsClient2.ProductsService.ProductData> VerProdutoAsync(string NumeroProduto) {
            return base.Channel.VerProdutoAsync(NumeroProduto);
        }
    }
}
