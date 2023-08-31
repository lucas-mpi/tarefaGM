using GerenciamentoLojaRoupas.Modelos;

namespace GerenciamentoLojaRoupas.InterfaceUsuario
{
    internal class UICategoria
    {

        public List<Categoria> categorias = new List<Categoria>();

        public void CadastrarCategoria()
        {
            Console.Write("Nome categoria: ");
            string? nome = Console.ReadLine();

            Console.Write("Descrição da categoria: ");
            string? descricao = Console.ReadLine(); 


            Categoria categoria = new Categoria(nome, descricao);
            categorias.Add(categoria);

        }

        public void ListaCategoria()
        {
            Console.WriteLine("Lista de categorias: ");

            foreach (var categoria in categorias)
            {
                Console.WriteLine($"Nome: {categoria.Nome}");
                Console.WriteLine($"Descrição: {categoria.Descricao}");

            }
        }
    }
}
