using System;
using System.Collections.Generic;

namespace Controller
{
    public class VeiculoPesado
    {
        public static Model.VeiculoPesado CriarVeiculoPesado(
            string Marca,
            string Modelo,
            string Ano,
            string Valor,
            string Restricao
        )
        {
            int ConverterYear = Convert.ToInt32(Ano);
            double COnvertValor = Convert.ToDouble(Valor);

            if (ConverterYear < 1990)
            {
                throw new Exception("Este carro é muito antigo!");
            }

            if (COnvertValor < 0)
            {
                throw new Exception("O preço não pode ser negativo!");
            }

            return new Model.VeiculoPesado(
                Marca,
                Modelo,
                ConverterYear,
                COnvertValor,
                Restricao
            );

        }

      
        public static IEnumerable<Model.VeiculoPesado> GetVeiculoPesado()
        {
            return Model.VeiculoPesado.GetVeiculoPesado();
        }

        public static Model.VeiculoPesado GetVeiculoPesado (int Id) {
            int TamanhoLista = Model.VeiculoPesado.GetCount();

            if (Id < 0 || TamanhoLista <= Id) {
                throw new Exception("Id Inválido");
            }
            return Model.VeiculoPesado.GetVeiculoPesado (Id);
        }

    }
}