using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class LocacaoLeve
    {
        public string Id { set; get; }

        public int IdLocacao { set; get; }

        public Locacao Locacao { set; get; }

        public int LeveId { set; get; }
        
        public VeiculoLeve VeiculoLeve { set; get; }

        public static readonly List<LocacaoLeve> bancoDeDados = new();

        public LocacaoLeve(
            Locacao Locacao,
            VeiculoLeve VeiculosLeve
        )
        {
            this.Locacao = Locacao;
            this.IdLocacao = Locacao.Id;
            this.VeiculoLeve = VeiculoLeve;
            this.LeveId = VeiculoLeve.Id;

            Context.LocacoesLeve.Add(this);

        }

        public static IEnumerable<LocacaoLeve> GetVeiculos(int IdLocacao)
        {
            Context Context = new Context();
            return from veiculo in Context.LocacoesLeve where veiculo.IdLocacao == IdLocacao select veiculo;
        }
        public static int GetCount(int IdLocacao)
        {
            return GetVeiculos(IdLocacao).Count();
        }
        // public static double GetTotal(int IdLocacao)
        // {
        //     Context Context = new Context();
        //     return (
        //         from veiculo in Context.LocacoesLeve
        //         where veiculo.IdLocacao == IdLocacao
        //         select veiculo.VeiculoLeve.Preco
        //     ).Sum();
        // }

    }
}    