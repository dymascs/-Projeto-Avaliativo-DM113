using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ProductsEntityModel;
using System.ServiceModel.Activation;

namespace Products
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ProductsService : IProductsService, IProductsService2
    {

        public List<string> ListarProdutos()
        {
            List<string> produtos = new List<string>();
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    List<ProductEstoque> produtoEstoques = (from produto in database.Products
                                                            select produto).ToList();

                    foreach (ProductEstoque produtoEstoque in produtoEstoques)
                    {
                        produtos.Add(produtoEstoque.NomeProduto);
                    }
                }
            }
            catch
            {

            }

            return produtos;
        }

        public bool IncluirProduto(ProductData produto)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProductEstoque produtoEstoque = new ProductEstoque();
                    produtoEstoque.NumeroProduto = produto.NumeroProduto;
                    produtoEstoque.NomeProduto = produto.NomeProduto;
                    produtoEstoque.DescricaoProduto = produto.DescricaoProduto;
                    produtoEstoque.EstoqueProduto = produto.EstoqueProduto;
                    database.Products.Add(produtoEstoque);
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }


        public bool RemoverProduto(string NumeroProduto)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    int produtoID = (
                        from pe in database.Products
                        where String.Compare(pe.NumeroProduto, NumeroProduto) == 0
                        select pe.Id).First();

                    ProductEstoque produtoEstoque = database.Products.First(pe => pe.Id == produtoID);
                    database.Products.Remove(produtoEstoque);

                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public int ConsultarEstoque(string NumeroProduto)
        {
            int Quantidade = 0;
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    int produtoID = (
                        from pe in database.Products
                        where String.Compare(pe.NumeroProduto, NumeroProduto) == 0
                        select pe.Id).First();

                    ProductEstoque produtoEstoque = database.Products.First(pe => pe.Id == produtoID);
                    Quantidade = produtoEstoque.EstoqueProduto;
                }
            }
            catch
            {

            }
            return Quantidade;
        }

        public bool AdicionarEstoque(string NumeroProduto, int Quantidade)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    int produtoID = (
                        from pe in database.Products
                        where String.Compare(pe.NumeroProduto, NumeroProduto) == 0
                        select pe.Id).First();

                    ProductEstoque produtoEstoque = database.Products.First(pe => pe.Id == produtoID);
                    produtoEstoque.EstoqueProduto += Quantidade;
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }


        public bool RemoverEstoque(string NumeroProduto, int Quantidade)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    int produtoID = (
                        from pe in database.Products
                        where String.Compare(pe.NumeroProduto, NumeroProduto) == 0
                        select pe.Id).First();

                    ProductEstoque produtoEstoque = database.Products.First(pe => pe.Id == produtoID);
                    produtoEstoque.EstoqueProduto = produtoEstoque.EstoqueProduto - Quantidade;

                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public ProductData VerProduto(string NumeroProduto)
        {
            ProductData produto = null;
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    int produtoID = (
                        from pe in database.Products
                        where String.Compare(pe.NumeroProduto, NumeroProduto) == 0
                        select pe.Id).First();

                    ProductEstoque produtoEstoque = database.Products.First(pe => pe.Id == produtoID);

                    produto = new ProductData();
                    produto.NumeroProduto=produtoEstoque.NumeroProduto;
                    produto.NomeProduto=produtoEstoque.NomeProduto;
                    produto.DescricaoProduto=produtoEstoque.DescricaoProduto;
                    produto.EstoqueProduto=produtoEstoque.EstoqueProduto;
                }
            }
            catch
            {

            }
            return produto;
        }





    }




}
