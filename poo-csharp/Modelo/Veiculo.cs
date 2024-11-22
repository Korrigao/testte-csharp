using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes.Modelo
{
    public class Veiculo
    {
        private string marca;
        private string modelo;
        private int ano;
        protected double velocidadeAtual;

        public Veiculo(string marca, string modelo, int ano, double velocidadeAtual)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.velocidadeAtual = 0;
        }
        public void acelerar()
        {
            Console.WriteLine($"O carro do/a {marca}, modelo {modelo} do ano {ano} está acelerando");
        }
        public void freiar()
        {
            Console.WriteLine($"O carro do/a {marca}, modelo {modelo} do ano {ano} está freiando");
        }
    }
}




//Herança - permite que novas classes sejam criadas a partir de classes já existentes.
