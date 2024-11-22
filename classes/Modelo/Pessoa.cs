using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes.Modelo
{
    public class Pessoa
    {
        //Atributos
        string nome;
        int idade;
        double altura;
        double peso;

        //construtor
        public Pessoa(string nome, int idade, double altura, double peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
        }

        //Métodos andar e falar
        public void Andar()
        {
            Console.WriteLine($"{nome} está andando");
        }
        public void Falar()
        {
            Console.WriteLine($"{nome}: vou ficar rico programando em C#");
        }
    }
}