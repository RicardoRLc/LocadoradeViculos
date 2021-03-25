using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{

public class VeiculoLeve : Veiculo
    {
    
    public int Id { set; get; }
    public string Tipo { set; get; }
    public List<LocacaoLeve> Locacoes { set; get; }
    public static readonly List<VeiculoLeve> VeiculoLeves  = new ();

    public VeiculoLeve(
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Restricao,
            string Tipo
            
        ) : base(Marca, Modelo, Ano, Preco)
        {
            this.Id = Context.VeiculosLeve.Count;
            this.Tipo = Tipo;
            this.Locacoes = new ();

            Context.VeiculosLeve.Add(this);
        }
        public override string ToString()
        {
            return base.ToString() + "\n Tipo:" + this.Tipo;
        }

    public static IEnumerable<VeiculoLeve> GetVeiculoLeve () {
            return from veiculoLeve in Context.VeiculosLeve select veiculoLeve;
        }
        public static VeiculoLeve GetVeiculoLeve (int Id) {
            return (
                from veiculoLeve in Context.VeiculosLeve 
                where veiculoLeve.Id == Id 
                select veiculoLeve
            ).First();
        }

         public static int GetCount() {
            return GetVeiculoLeve().Count();
        }
    }
      
}