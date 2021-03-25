using System;
using System.Collections.Generic;

namespace View
{
    public class VeiculosLeves
    {
        public static void CriarVeiculo()
        {
            Console.WriteLine("Qual a Marca do Veículo: ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Qual o Modelo do Veículo: ");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Qual o Ano do Veículo: ");
            string Ano = Console.ReadLine();
            Console.WriteLine("Qual o Preço de Locação do Veículo: ");
            string Preco = Console.ReadLine();
            Console.WriteLine("Qual o Restrições do Veículo: ");
            string Restrictions = Console.ReadLine();
            Console.WriteLine("Qual o peso do veículo");
            string Tipo = Console.ReadLine();
            Controller.VeiculoLeve.CriarVeiculoLeve(Marca, Modelo, Ano, Preco, Restrictions,Tipo);

        }

        public static void ListarVeiculos()
        {
            foreach (Model.VeiculoLeve veiculo in Controller.VeiculoLeve.ListarVeiculoLeve ()) {
                Console.WriteLine ("\n----------INíCIO----------");
                Console.WriteLine (veiculo);
                Console.WriteLine ("\n-------------FIM-------------");

            }
        }
    }
}