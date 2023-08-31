using GerenciamentoLojaRoupas.Modelos;

namespace GerenciamentoLojaRoupas.InterfaceUsuario
{
    internal class UIVenda
    {

        public void CadastrarVenda()
        {
            List<Venda> vendas = new List<Venda>();

            Console.Write("Cliente: ");
            string? nome = Console.ReadLine();

            Console.Write("Produto: ");
            string? produto = Console.ReadLine();


        }
        

    }
}
