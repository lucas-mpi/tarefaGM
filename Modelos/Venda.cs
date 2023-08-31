using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoLojaRoupas.Modelos
{
    internal class Venda
    {
        public Cliente Cliente { get; set; }
        
        public List<Produto> Produtos { get; set; } 

        public DateTime DataVenda { get; set; }

        public decimal ValorTotal { get; set; } 

        public Venda()
        {
  
        }

        public Venda(Cliente cliente, List<Produto> produtos)
        {
            this.Cliente = cliente;
            this.Produtos = produtos;

        }


    }
}
