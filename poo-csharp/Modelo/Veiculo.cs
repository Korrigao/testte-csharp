// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace poo_01_classes_atributos_metodos_objetos.Modelo
// {
//     public class Veiculo
//     {
//         // Atributos
//         string marca; 
//         string modelo; 
//         int ano;     
//         double velocidadeAtual; 

//         // Construtor
//         public Veiculo(string marca, string modelo, int ano, double velocidadeAtual) 
//         { 
//             this.marca = marca; 
//             this.modelo = modelo; 
//             this.ano = ano; 
//             this.velocidadeAtual = velocidadeAtual; 
//         }

//         // Método concreto Acelerar
//         public void Acelerar(double incremento)
//         {
//             velocidadeAtual += incremento;
//             Console.WriteLine($"Acelerando... Velocidade atual {velocidadeAtual} Km/h.");
//         }

//         // Método concreto Frear
//         public void Frear(double decremento)
//         {
//             velocidadeAtual -= decremento;
//             Console.WriteLine($"Freando... Velocidade atual {velocidadeAtual} Km/h");
//         }
//     }
// }






//Encapsulamento - visa esconder os detalhes internos de uma classe
//Todos os atributos e metodos são publicos se não expecíficados

// public - torna o membro acessivel a qualquer outra classe ou codigo
// private - limita o membro para que possa ser usado dentro da própria classe
// protected - somente a classe e os filhos da classe terão acessos
// internal - 
// protected internal


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_02_encapsulamento.Modelo
{
    public class Veiculo
    {
        // Atributos encapsulados com modificadores de acesso private, protected, getters e setters 
        private string marca { get; set; } 
        private string modelo { get; set; } 
        private int ano { get; set; }     
        protected double velocidadeAtual { get; set; } 

        // Construtor
        public Veiculo(string marca, string modelo, int ano, double velocidadeAtual) 
        { 
            this.marca = marca; 
            this.modelo = modelo; 
            this.ano = ano; 
            this.velocidadeAtual = velocidadeAtual; 
        }

        // Método concreto Acelerar
        public void Acelerar(double incremento)
        {
            velocidadeAtual += incremento;
            Console.WriteLine($"Acelerando... Velocidade atual {velocidadeAtual} Km/h.");
        }

        // Método concreto Frear
        public void Frear(double decremento)
        {
            velocidadeAtual -= decremento;
            Console.WriteLine($"Freando... Velocidade atual {velocidadeAtual} Km/h");
        }
    }
}
