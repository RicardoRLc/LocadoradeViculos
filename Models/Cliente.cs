using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public String Cpf { get; set; }
        public int DiasDevolver { get; set; }
        
        public List<Locacao> Locacoes { set; get; }


        public static readonly List<Cliente> Clientes = new ();

        public Cliente(string Nome, DateTime DataNascimento, string Cpf, int DiasDevolver)
        {
            this.Id = Context.Clientes.Count;
            this.Nome = Nome;
            this.DtNascimento = DataNascimento;
            this.Cpf = Cpf;
            this.DiasDevolver = DiasDevolver;
            this.Locacoes = new ();

            Context.Clientes.Add (this);
        }

         public override string ToString()
        {
            return String.Format(
                 "\n|    Id: {0}" + 
                 "\n|" +
                 "\n|    Nome: {1}" + 
                 "\n|    Data de Nascimento: {2:d}" + 
                 "\n|    Devolução em: {3} dias" +
                 "\n|    Locações: {4}",
                this.Id, 
                this.Nome,
                this.DtNascimento,
                this.DiasDevolver,
                Locacao.GetCount(this.Id)

            );
        }

        public static Cliente GetCliente(int Id)
        {
            IEnumerable<Cliente> query = from cliente in Context.Clientes where cliente.Id == Id select cliente;

            return query.First();

        }

        public static IEnumerable<Cliente> GetClientes ()
        {
            return from cliente in Context.Clientes select cliente;
        }

        public static int GetCount () {
            return GetClientes().Count();
        }

          public static void AddCliente(Cliente cliente)
        {
            Context.Clientes.Add (cliente);
        }


    }
}