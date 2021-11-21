using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ProductsClient1.ProductsService;

namespace ProductsClient1
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                ProductsServiceClient proxy = new ProductsServiceClient("BasicHttpBinding_IProductsService");

                Console.WriteLine("Teste Cliente 1");
                Console.WriteLine();

                Console.WriteLine("1: Adicionar o produto 11");
                ProductData productData = new ProductData()
                {
                    NumeroProduto = "11000",
                    NomeProduto = "Produto 11",
                    DescricaoProduto = "Este é o produto 11",
                    EstoqueProduto = 375
                };

                if (proxy.IncluirProduto(productData))
                {
                    Console.WriteLine("Produto incluído com sucesso.");
                }
                else
                {
                    Console.WriteLine("Erro ao incluir novo produto.");
                }

                Console.WriteLine();


                Console.WriteLine("2: Remover produto 10");
                if (proxy.RemoverProduto("10000"))
                {
                    Console.WriteLine("Produto 10 removido com sucesso.");
                }
                else
                {
                    Console.WriteLine("Erro ao remover produto 10.");
                }

                Console.WriteLine();


                Console.WriteLine("3: Listar todos os produtos");
                List<String> productos = proxy.ListarProdutos().ToList();
                foreach (String Nome in productos)
                {
                    Console.WriteLine("Nome do produto: {0}", Nome);

                }
                Console.WriteLine();


                Console.WriteLine("4: Mostrar informações do produto 2");
                ProductData product = proxy.VerProduto("2000");
                Console.WriteLine("Número do produto: {0}", product.NumeroProduto);
                Console.WriteLine("Nome do produto: {0}", product.NomeProduto);
                Console.WriteLine("Descrição do produto: {0}", product.DescricaoProduto);
                Console.WriteLine("Estoque de produto: {0}", product.EstoqueProduto);

                Console.WriteLine();


                Console.WriteLine("5: Adicionar estoque para produto 2");
                if (proxy.AdicionarEstoque("2000", 10))
                {
                    Console.WriteLine("Estoque adicionado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Erro ao adicionar estoque");
                }

                Console.WriteLine();


                Console.WriteLine(" 6: Verificar estoque do produto 2");
                Console.WriteLine("Estoque produto 2: {0}", proxy.ConsultarEstoque("2000"));
                Console.WriteLine();


                Console.WriteLine("7: Verificar estoque do produto 1");
                Console.WriteLine("Estoque do produto 1: {0}", proxy.ConsultarEstoque("1000"));
                Console.WriteLine();



                Console.WriteLine("8: Remover estoque do produto 1");
                if (proxy.RemoverEstoque("1000", 20))
                {
                    Console.WriteLine("Estoque removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Erro ao remover estoque do produto 1!");
                }

                Console.WriteLine();


                Console.WriteLine("9: Verificar estoque do produto 1 novamente");
                Console.WriteLine("Estoque do produto 1 novamente: {0}", proxy.ConsultarEstoque("1000"));
                Console.WriteLine();


                Console.WriteLine("10: Ver informações do produto 1");
                ProductData product1 = proxy.VerProduto("1000");
                Console.WriteLine("Número do produto: {0}", product1.NumeroProduto);
                Console.WriteLine("Nome do produto: {0}", product1.NomeProduto);
                Console.WriteLine("Descrição do produto: {0}", product1.DescricaoProduto);
                Console.WriteLine("Estoque de produto: {0}", product1.EstoqueProduto);

                Console.WriteLine();

                proxy.Close();
                Console.WriteLine("Press ENTER to finish");
                Console.ReadLine();


                
            }
        }
    }
}
