

namespace GerenciamentoLojaRoupas.Modelos
{
    internal class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }

        public string NumeroTelefone { get; set; }


        public Cliente (string nome, string sobrenome, string endereco, string numeroTelefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Endereco = endereco;
            NumeroTelefone = numeroTelefone;

        }

    
    }
}
