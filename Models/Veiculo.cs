using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public abstract class Veiculo
    {
        public string Marca { set; get; } // marca
        public string Modelo { set; get; } // Modelo
        public int Ano { set; get; } // ano
        public double Price { set; get; } // preço

        public Veiculo(
            string Marca,
            string Modelo,
            int Ano,
            double Preco
        )
        {
            this.Marca = Marca;
            this.Modelo= Modelo
            this.Ano = Ano;
            this.Preco = Preco;
        }

        public override string ToString()
        {
            return
                "Marca: " + this.Marca +
                "\n Modelo: " + this.Model +
                "\n Ano: " + this.Ano +
                "\n Preço de locação: " +   this.Preco;   // formatar para REAL  String.Format ({"0:C"},

        }
    }
}