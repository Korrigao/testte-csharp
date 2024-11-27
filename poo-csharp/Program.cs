//Programação Orientada a objetos - um dos paradigmas da programação
// ﻿using poo_01_classes_atributos_metodos_objetos.Modelo;

// Console.WriteLine("POO: Classes, atributos, métodos e Objetos\n");

// // Criando um objeto a partir da classe Veiculo
// Console.WriteLine("Criando instância da Classe Veiculo");
// Veiculo veiculo = new Veiculo("veiculo", "modelo veiculo", 2024, 10);
// veiculo.Acelerar(60);
// veiculo.Frear(20);







//Encapsulamento - visa esconder os detalhes internos de uma classe
//Todos os atributos e metodos são publicos se não expecíficados

// public - torna o membro acessivel a qualquer outra classe ou codigo
// private - limita o membro para que possa ser usado dentro da própria classe
// protected - somente a classe e os filhos da classe terão acessos
// internal - 
// protected internal

﻿using poo_02_encapsulamento.Modelo;

Console.WriteLine("POO: Encapsulamento\n");

// Criando um objeto a partir da classe Veiculo
Console.WriteLine("Criando instância da Classe Veiculo");
Veiculo veiculo = new Veiculo("veiculo", "modelo veiculo", 2024, 10);
veiculo.Acelerar(60);
veiculo.Frear(20);









poo- csharp 2
//Getters e Setters
//Getter - Um metodo utilizado para obter o valor de um atributo. Permite a leitura de um atrbuto privado fora da classe.
//setter - um metodo utilizado para definir ou modificar o valor de um atributo
﻿using poo_03_heranca.Modelo;

Console.WriteLine("\nPOO: Herança\n");

Console.WriteLine("Criando instância da Classe Veiculo");
Veiculo veiculo = new Veiculo("veiculo", "modelo veiculo", 2024, 10);
veiculo.Acelerar(60);
veiculo.Frear(20);

Console.WriteLine("\nCriando instância da Classe Moto");
Moto harleyDavidson = new Moto("Harley Davidson", "Turbo S10", 2025, 30, true, true);
harleyDavidson.Acelerar(55.8);
harleyDavidson.Frear(10.5);
harleyDavidson.Empinar();

Console.WriteLine("\nCriando instância da Classe Carro");
Carro ferrari = new Carro("Ferrari", "Ferrari Enzo", 2024, 10, true, 2);
ferrari.Acelerar(260);
ferrari.Frear(200);
ferrari.AbrirPortas();




veiculo:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_03_heranca.Modelo
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


carro:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_03_heranca.Modelo
{
    public class Carro : Veiculo
    {
        // Atributos encapsulados
        private bool automatico { get; set; } 
        private int numeroDePortas { get; set; }     

        // Construtor
        public Carro(string marca, string modelo, int ano, double velocidadeAtual, bool automatico, int numeroDePortas) : base (marca, modelo, ano, velocidadeAtual)
        { 
            this.automatico = automatico; 
            this.numeroDePortas = numeroDePortas; 
        }

        // Método concreto Abrir Portas é especifico da classe Carro.
        public void AbrirPortas ()
        {
            Console.WriteLine("As portas do carro estão abertas.");
        }
    }
}



moto:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_03_heranca.Modelo
{
    public class Moto : Veiculo
    {
        // Atributos encapsulados
        private bool partidaEletrica { get; set; } 
        private bool  protetorDeCarenagem { get; set; }     
        
        // Construtor
        public Moto(string marca, string modelo, int ano, double velocidadeAtual, bool  partidaEletrica, bool  protetorDeCarenagem ) : base (marca, modelo, ano, velocidadeAtual)
        { 
            this.partidaEletrica = partidaEletrica ; 
            this.protetorDeCarenagem = protetorDeCarenagem ; 
        }

        // Método concreto Empinar é especifico da classe Moto.
        public void Empinar()
        {
            Console.WriteLine("Empinando a moto!");
        }
    }
}
