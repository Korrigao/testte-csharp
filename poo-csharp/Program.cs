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

using poo_02_encapsulamento.Modelo;

Console.WriteLine("POO: Encapsulamento\n");

// Criando um objeto a partir da classe Veiculo
Console.WriteLine("Criando instância da Classe Veiculo");
Veiculo veiculo = new Veiculo("veiculo", "modelo veiculo", 2024, 10);
veiculo.Acelerar(60);
veiculo.Frear(20);