using System;

namespace Veiculo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opt = 0;
            Console.WriteLine("-----Locação do Veiculo LTDA -------");
            // Always repeat until the user leaves
            do
            {
                Console.WriteLine("\n*** Informe a opção desejada ***");
                Console.WriteLine("\n1 - Cadastro de  Cliente");
                Console.WriteLine("\n2 - Listar os Clientes");
                Console.WriteLine("\n3 - Cadastro Veículo Pesado");
                Console.WriteLine("\n4 - Listar os Veículos Pesados");
                Console.WriteLine("\n5 - cadastrar locacoes");
                Console.WriteLine("\n6 - Listar locacoes");
                Console.WriteLine("\n7 IMPORTAR");
                Console.WriteLine("\n0 - Sair");
                // Get the user option
                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 0:
                        // Close system
                        break;
                    case 1:
                        View.Cliente.CriarCliente();
                        break;
                    case 2:
                        View.Cliente.ListCriarCostumizars();
                        break;
                    case 3:
                        View.VeiculoPesado.CriarVeiculo();
                        break;
                    case 4:
                        View.VeiculoPesado.ListarVeiculos();
                        break;
                    case 5:
                        View.Locacao.CriarLocacao();
                        break;
                    case 6:
                        View.Locacao.ListarLocacao();
                        break;
                    case 7:
                        View.Import.DBImport();
                        break;
                    default:
                        Console.WriteLine("Operação Inválida.");
                        break;
                }
            } while (opt != 0);
        }

    }
}
