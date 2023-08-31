using GerenciamentoLojaRoupas.Modelos;

namespace GerenciamentoLojaRoupas.InterfaceUsuario
{
    internal class UICliente
    {
        
        
        public List<Cliente> clientes = new List<Cliente>();

        public void CadastrarCliente()
        {
            Console.Write("Nome: ");
            string? nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            string? sobrenome = Console.ReadLine();

            Console.Write("Número de Telefone: ");
            string? numeroTelefone  = Console.ReadLine();

            Console.Write("Endereço: ");
            string? endereco = Console.ReadLine();

            Cliente novoCliente = new Cliente(nome, sobrenome, endereco, numeroTelefone);

            clientes.Add(novoCliente);

        }


        public void ListarClientes()
        {
            Console.WriteLine("Lista de clientes cadastrados:");
            foreach(var cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome} {cliente.Sobrenome}");
                Console.WriteLine($"Contato: {cliente.NumeroTelefone}");
                Console.WriteLine($"Endereço {cliente.Endereco}");

            }
        }


    }
}
