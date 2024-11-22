using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes.Modelo
{
    public class Veiculo
    {
        string marca;
        string modelo;
        int ano;

        public Veiculo(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
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