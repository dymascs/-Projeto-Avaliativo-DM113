using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Products
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/01", Name = "IProductsService")]
    public interface IProductsService
    {
        [OperationContract]
        List<String> ListarProdutos();

        [OperationContract]
        bool IncluirProduto(ProductData produto);

        [OperationContract]
        bool RemoverProduto(string NumeroProduto);

        [OperationContract]
        int ConsultarEstoque(string NumeroProduto);

        [OperationContract]
        bool AdicionarEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        ProductData VerProduto(string NumeroProduto);


    }

    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/02", Name = "IProductsService2")]
    public interface IProductsService2
    {
        [OperationContract]
        bool AdicionarEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        int ConsultarEstoque(string NumeroProduto);
    }


    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class ProductData
    {
       
        [DataMember]
        public string NumeroProduto { get; set; }

        [DataMember]
        public string NomeProduto { get; set; }

        [DataMember]
        public string DescricaoProduto { get; set; }
        [DataMember]
        public int EstoqueProduto { get; set; }
    }
}
