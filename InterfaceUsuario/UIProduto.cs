using GerenciamentoLojaRoupas.Modelos;

namespace GerenciamentoLojaRoupas.InterfaceUsuario
{
    internal class UIProduto
    {
        public List<Produto> produtos = new List<Produto>();

        public void CadastrarProduto()
        {
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Valor: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Categoria: ");
            var categoria = Console.ReadLine();

           
            Produto novoProduto = new Produto(nome, descricao, valor, categoria);
            produtos.Add(novoProduto);    



        }

        public void ListarProdutos()
        {
            Console.WriteLine("Lista de clientes cadastrados:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Produto: {produto.Nome}");
                Console.WriteLine($"Descrição: {produto.Descricao}");
                Console.WriteLine($"Valor: {produto.Valor}");
                Console.WriteLine($"Categoria: {produto.Categoria}");

            }
        }
    }
}
