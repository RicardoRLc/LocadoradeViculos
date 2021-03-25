using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public class Locacao 
    {
        public static Model.Locacao FazerLocacao(
            string ClienteId,
            string StringDataLocacao,
            List<Model.VeiculoPesado> VeiculosPesado,
            List<Model.VeiculoLeve> VeiculosLeve

        )
      
        {
            Model.Cliente Cliente = Model.Cliente.GetCliente(Convert.ToInt32(ClienteId));

             DateTime DataLocacao;

            try
            {
                DataLocacao = Convert.ToDateTime(StringDataLocacao);

            }
            catch
            {
                DataLocacao = DateTime.Now;
            }

            if (DataLocacao.Year > DateTime.Now.Year)
            {
                throw new Exception("Ano superior ao atual!");
            }

            if (DataLocacao.Year < DateTime.Now.Year)
            {
                throw new Exception("Ano inferior ao atual!");
            }

            if (DataLocacao.Month < DateTime.Now.Month)
            {
                throw new Exception("Mês inválido");
            }

            if (DataLocacao.Day < DateTime.Now.Day)
            {
                throw new Exception("Dia inválido");
            }


            return new Model.Locacao(
                Cliente,
                DataLocacao,
                VeiculosPesado,
                VeiculosLeve
            );
        }    

    public static IEnumerable<Model.Locacao> GetLocacao()
        {
            return Model.Locacao.GetLocacao();
        }

    }
}