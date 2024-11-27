//Programação Orientada a objetos - um dos paradigmas da programação
﻿using poo_01_classes_atributos_metodos_objetos.Modelo;

Console.WriteLine("POO: Classes, atributos, métodos e Objetos\n");

// Criando um objeto a partir da classe Veiculo
Console.WriteLine("Criando instância da Classe Veiculo");
Veiculo veiculo = new Veiculo("veiculo", "modelo veiculo", 2024, 10);
veiculo.Acelerar(60);
veiculo.Frear(20);

//Encapsulamento - visa esconder os detalhes internos de uma classe
//Todos os atributos e metodos são publicos se não expecíficados

// public - torna o membro acessivel a qualquer outra classe ou codigo
// private - limita o membro para que possa ser usado dentro da própria classe
// protected - somente a classe e os filhos da classe terão acessos
// internal - 
// protected internal

//Getters e Setters
//Getter - Um metodo utilizado para obter o valor de um atributo. Permite a leitura de um atrbuto privado fora da classe.
//setter - um metodo utilizado para definir ou modificar o valor de um atributo

