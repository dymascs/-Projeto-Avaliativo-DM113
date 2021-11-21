using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ProductsClient2.ProductsService;


namespace ProductsClient2
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                ProductsServiceClient proxy = new ProductsServiceClient("BasicHttpBinding_IProductsService");


                Console.WriteLine("1: Verificar o estoque atual do Produto 1");
                Console.WriteLine("Estoque atual do Produto 1: {0}", "1000");
                Console.WriteLine();


                Console.WriteLine("2: Adicionar 20 unidades para este produto");
                if (proxy.AdicionarEstoque("2000", 10))
                {
                    Console.WriteLine("Estoque adicionado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Erro ao adicionar estoque");
                }

                Console.WriteLine();

                Console.WriteLine("3: Verificar estoque do produto 1");
                Console.WriteLine("Estoque do produto 1: {0}", proxy.ConsultarEstoque("1000"));
                Console.WriteLine();

                Console.WriteLine("4: Verificar estoque do produto 5");
                Console.WriteLine("Estoque do produto 1: {0}", proxy.ConsultarEstoque("5000"));
                Console.WriteLine();


                Console.WriteLine("5: Remover estoque do produto 5");
                if (proxy.RemoverEstoque("5000", 10))
                {
                    Console.WriteLine("Estoque removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Erro ao remover estoque do produto!");
                }

                Console.WriteLine();

                Console.WriteLine("6: Verificar estoque do produto 5");
                Console.WriteLine("Estoque do produto 1: {0}", proxy.ConsultarEstoque("5000"));
                Console.WriteLine();


                proxy.Close();
                Console.WriteLine("Press ENTER to finish");
                Console.ReadLine();


                
            }


        }
    }
}
