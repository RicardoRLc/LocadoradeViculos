using System;
using System.Collections.Generic;

namespace View
{
    public static class Cliente
    {
        public static void CriarCliente()
        {
            Console.WriteLine("Qual o nome do Cliente: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Qual a  Data de Nascimento do Cliente: ");
            string DtNascimento = Console.ReadLine();
            Console.WriteLine(" Qual é  o CPF do Cliente: ");
            string CpfCliente = Console.ReadLine();
            Console.WriteLine("Quantos dias para a devolução tem o do Cliente: ");
            string Devolucao = Console.ReadLine();
            try
            {
                Controller.Cliente.CriarCliente(Nome, DtNascimento, CpfCliente, Devolucao);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Informações digitadas são incorretas: {e.Message}");
            }
        }
        public static void ListCriarCostumizars()
        {

            foreach (Model.Cliente cliente in Controller.Cliente.ListaCliente())
            {
                Console.WriteLine("=========================");
                Console.WriteLine(cliente);
            }
        }
    }
}