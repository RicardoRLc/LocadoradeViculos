using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{

    public class Locacao
    {
        public int Id { set; get; }
        
        public int ClienteId { set; get; }

        public Cliente Cliente { set; get; }

        public DateTime DataLocacao { set; get; }

        public List<LocacaoPesado> VeiculosPesado { set; get; }
        public List<LocacaoLeve> VeiculosLeve { set; get; }


        public static readonly List<Locacao> Locacoes = new();

        public Locacao(
            Cliente Cliente,
            DateTime DataLocacao,
            List<VeiculoPesado> VeiculosPesado,
            List<VeiculoLeve> VeiculosLeve
            
        )

        {
            this.Id = Context.Locacoes.Count;
            this.Cliente = Cliente;
            this.ClienteId = Cliente.Id;
            this.DataLocacao = DataLocacao;

            foreach (VeiculoPesado veiculo in VeiculosPesado)
            {
                LocacaoPesado locacaoVeiculoPesado = new(this, veiculo);
            }

            foreach (VeiculoLeve veiculo in VeiculosLeve)
            {
                LocacaoLeve locacaoLeve = new(this, veiculo);
            }

            Context.Locacoes.Add(this);

        }

        public override string ToString()
        {
            string Print = String.Format(
                "\nData da Locação: {0:d}" +
                "\nData da Devolução: {1:d}" +
                "\nCliente: {2}",
                this.DataLocacao,
                this.GetDataDevolucao(),
                this.Cliente
            );

             Print += "\n==> Veículos Leves Locados: ";
            if (LocacaoLeve.GetCount(this.Id) > 0)
            {
                foreach (LocacaoLeve veiculo in LocacaoLeve.GetVeiculos(this.Id))
                {
                    Print += "\n" + veiculo.VeiculoLeve;
                }
            }
            else
            {
                Print += "\n    ==> Nada Consta";
            }
            Print += "\n==> Veículos Leves Locados: ";
            if (LocacaoPesado.GetCount(this.Id) > 0)
            {
                foreach (LocacaoPesado veiculo in LocacaoPesado.GetVeiculos(this.Id))
                {
                    Print += "\n" + veiculo.VeiculoPesado;
                }
            }
            else
            {
                Print += "\n    ==> Nada Consta";
            }
            return Print;


        }

        public static IEnumerable<Locacao> GetLocacao()
        {
            return from locacao in Context.Locacoes select locacao;
        }

        public static int GetCount(int ClienteId)
        {
            return (from locacao in Context.Locacoes where locacao.ClienteId == ClienteId select locacao).Count();
        }

        public DateTime GetDataDevolucao()
        {
            int DiasParaDevolucao = this.Cliente.DiasDevolver;

            return this.DataLocacao.AddDays(DiasParaDevolucao);
        }
    }
}
