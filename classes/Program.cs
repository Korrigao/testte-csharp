//Classes - molde abstrato em que todos os objetos que são da mesma classes serão iguais.
//o nome da clase deve ser o mesmo do arquivo .cs e a primeira letra deve ser maiuscula.

//atributos são as variaveis da clase que armazenam dados dentro dela.

//Metodos são funções e servem manipular os atributos da classe.

//objeto - instâncias de uma classe que alocam a memoria para a classe.

﻿using System;

using classes.Modelo;

// Criando um objeto a partir da classe Pessoa
Pessoa obj = new Pessoa("Wanderson", 25, 1.90, 60.9);
obj.Andar();
obj.Falar();
