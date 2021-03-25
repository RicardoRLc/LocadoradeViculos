using System;
using System.Collections.Generic;

namespace View
{
    public class VeiculoPesado
    {
        public static void CriarVeiculo()
        {
            Console.WriteLine("Qual a Marca do Veículo: ");
            string Brand = Console.ReadLine();
            Console.WriteLine("Qual o Modelo do Veículo: ");
            string Model = Console.ReadLine();
            Console.WriteLine("Qual o Ano do Veículo: ");
            string Year = Console.ReadLine();
            Console.WriteLine("Qual o Preço de Locação do Veículo: ");
            string Price = Console.ReadLine();
            Console.WriteLine("Qual o Restrições do Veículo: ");
            string Restrictions = Console.ReadLine();

            Controller.VeiculoPesado.CriarVeiculoPesado(Brand, Model, Year, Price, Restrictions);

        }

        public static void ListarVeiculos()
        {
            foreach(Model.VeiculoPesado veiculo in Controller.VeiculoPesado.GetVeiculoPesado ()) {
                Console.WriteLine(veiculo);
                Console.WriteLine("------");
            }
        }
    }
}