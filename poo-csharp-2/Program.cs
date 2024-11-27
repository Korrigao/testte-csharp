//Getters e Setters
//Getter - Um metodo utilizado para obter o valor de um atributo. Permite a leitura de um atrbuto privado fora da classe.
//setter - um metodo utilizado para definir ou modificar o valor de um atributo
using poo_csharp_2.Modelo;

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