using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class LocacaoPesado
    {
        public string Id { set; get; }
        public int IdLocacao { set; get; }
        public Locacao Locacao { set; get; }
        public int PesadosId { set; get; }
        public VeiculoPesado VeiculoPesado { set; get; }

        public static readonly List<LocacaoPesado> bancoDeDados = new();

        public LocacaoPesado(
            Locacao Locacao,
            VeiculoPesado VeiculoPesado
        )
        {

            this.Locacao = Locacao;
            this.IdLocacao = Locacao.Id;
            this.VeiculoPesado = VeiculoPesado;
            this.PesadosId = PesadosId;
            Context.LocacoesPesado.Add(this);

        }

         public static IEnumerable<LocacaoPesado> GetVeiculos(int LocacaoId) {
            return from veiculo in Context.LocacoesPesado where veiculo.IdLocacao == LocacaoId select veiculo;
        }

        public static int GetCount(int LocacaoId) {
            return GetVeiculos(LocacaoId).Count();
        }

    }

}