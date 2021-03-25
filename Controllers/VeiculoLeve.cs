using System;
using System.Collections.Generic;

namespace Controller
{
    public class VeiculoLeve
    {
        public static Model.VeiculoLeve CriarVeiculoLeve(
           string Marca,
           string Modelo,
           string Ano,           
           string Restricao,
           string Valor,
           string Tipo 
        )
          {
            return new Model.VeiculoLeve(
                Marca,
                Modelo,
                Convert.ToInt32(Ano),
                Convert.ToDouble(Valor),
                Restricao,
                Tipo            
            );

    }

    public static IEnumerable<Model.VeiculoLeve> GetVeiculoLeve()
        {
            return Model.VeiculoLeve.GetVeiculoLeve();
        }

    public static IEnumerable<Model.VeiculoLeve> ListarVeiculoLeve ()
        {
            return Model.VeiculoLeve.GetVeiculoLeve ();
        }

        public static Model.VeiculoLeve GetVeiculoLeve (int Id) {
            int TamanhoLista = Model.VeiculoLeve.GetCount();

            if (Id < 0 || TamanhoLista <= Id) {
                throw new Exception("Id Inválido");
            }
            return Model.VeiculoLeve.GetVeiculoLeve (Id);
        }
    }
}
