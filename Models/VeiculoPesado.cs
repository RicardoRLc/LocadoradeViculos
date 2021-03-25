using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{

    public class VeiculoPesado : Veiculo
    {

        public int Id { set; get; }
        public string Restricao { set; get; }

        public List<LocacaoPesado> Locacoes { set; get; }
        public static List<VeiculoPesado> VeiculosPesado = new ();
        public VeiculoPesado(
            string marca,
            string Modelo,
            int Ano,
            double Preco,
            string Restricao
        ) : base(marca, Modelo, Ano, Preco)
        {
            this.Id = Context.VeiculosPesado.Count;
            this.Restricao = Restricao;
            this.Locacoes = new ();

            Context.VeiculosPesado.Add (this);
        }

      public override string ToString () {
            return 
                "\n|    Id: " + this.Id + 
                "\n|    " + base.ToString () + 
                "\n|    Cor: " + this.Restricao;
        }

    
        public static IEnumerable<VeiculoPesado> GetVeiculoPesado () {
            return from veiculoPesado in Context.VeiculosPesado select veiculoPesado;
        }

         public static VeiculoPesado GetVeiculoPesado (int Id) {
            return (
                from veiculoPesado in Context.VeiculosPesado 
                where veiculoPesado.Id == Id 
                select veiculoPesado
            ).First();
        }
        public static int GetCount() {
            return GetVeiculoPesado().Count();
        }
    }


}