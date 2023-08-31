using GerenciamentoLojaRoupas.InterfaceUsuario;

namespace GerenciamentoLojaRoupas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem vindo!");

            int opcao;

            do
            {
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - Realizar uma venda");
                Console.WriteLine("2 - Cadastro de clientes");
                Console.WriteLine("3 - Cadastro de produtos");
                Console.WriteLine("4 - Cadastro de categorias");
                Console.WriteLine("5 - Listar categorias");
                Console.WriteLine("0 - Encerrar o programa");

                opcao = int.Parse(Console.ReadLine());
                
                UICliente clienteUI = new UICliente();
                UICategoria categoriaUI = new UICategoria();

                
                switch (opcao)
                {
                    case 1:
                        UIVenda venda = new UIVenda();
                        venda.CadastrarVenda();
                        break;

                    case 2:
                        
                        clienteUI.CadastrarCliente();
                        break;

                    case 3:
                        UIProduto produto = new UIProduto();
                        produto.CadastrarProduto();
                        break;

                    case 4:
                        categoriaUI.CadastrarCategoria();
                        break;

                    case 5:
                        categoriaUI.ListaCategoria();
                        break;

                }

                } while (opcao != 0);
            
            


        }
    }
}