// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// tipos de dados primitivos

// numeros inteiros
short ano = 2025;    // numeros inteiros de ate 16 bits
int contador = 10;   // numeros inteiros positivos e negativos de ate 32 bits
long populacaoMundial = 700000000;

// numeros de pontos flutuantes
float tempeature = 43.6f;
double precoProduto = 139.90; 

//caracteres
char inicial = "Y";

//tipos logicos
bool estaLogado = true;
bool estaAtivo = false;





//tipos de dados nao primitivos
string mensagem = "ola mundo";

// arrays: colecao de elementos do mesmo tipo.
int[] numeros = {1,4,7,10};
string[] nomes = {"Joao","Thomas","Luiza"}

//classes
public class Pessoa
{
    public string nome;
    public string idade;
}

//Structs
public class Ponto
{
    public int X;
    public int Y;
}

//Enums: sao usados para definir conjuntos de constantes nomeadas
public enum DiadaSemana
{
    Segunda, Terca, Quarta, Quinta, Sexta, Sabado, Domingo
}


//interfaces
public interface IVeiculo
{
    void Mover();
}

//Delegates
public delegate void Processar(int numero);

//Nullable types
int? idade = null