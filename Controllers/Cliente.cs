using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public static class Cliente
    {

        public static void CriarCliente(
            string Nome,
            string StringDtnascimento,
            string Cpf,
            string Devolucao
        )
        {
            //Parametrizar neste modelo 999.999.999-99
            Regex rgx = new Regex("^\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}$");
            if (!rgx.IsMatch(Cpf))
            {
                throw new Exception("C.P.F. Inválido");
            }

            DateTime Dtnascimento;

            try {
                Dtnascimento = Convert.ToDateTime (StringDtnascimento);

            } catch {

                throw new Exception ("Data de nascimento incorreta");

            }

            Model.Cliente Listar = new Model.Cliente(
                Nome,
                Dtnascimento,
                Cpf,
                Convert.ToInt32(Devolucao)
            );
        }
        public static IEnumerable<Model.Cliente> ListaCliente()
        {
            return Model.Cliente.GetClientes();
        }

      
    }
}