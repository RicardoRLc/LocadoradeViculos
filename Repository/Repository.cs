using System.Collections.Generic;
using Model;

namespace Repository
{
    public class Context 
    {
        public  static readonly List<Cliente> Clientes = new ();
        public  static readonly List<VeiculoPesado> VeiculosPesado = new ();
        public  static readonly List<VeiculoLeve> VeiculosLeve = new ();
        public  static readonly List<Locacao> Locacoes = new ();
        public  static readonly List<LocacaoLeve> LocacoesLeve = new ();
        public  static readonly List<LocacaoPesado> LocacoesPesado = new ();

    }
}