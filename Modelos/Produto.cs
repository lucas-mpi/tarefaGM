namespace GerenciamentoLojaRoupas.Modelos
{
    internal class Produto
    {
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public Categoria Categoria { get; set; }

        public Produto() 
        {
        }


        public Produto(string nome, string descricao, double valor, Categoria categoria)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            this.Categoria = categoria;

            
        }

       
    }
}
