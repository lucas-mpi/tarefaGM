
namespace GerenciamentoLojaRoupas.Modelos
{
    internal class Categoria
    {
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public Categoria()
        {

        }
        public Categoria(string nome, string descricao) 
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
