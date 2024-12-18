﻿//Concatenação - faz a junção de duas ou mais strings, ou cadeias de caractéres, em uma única string. Muita utilizada para criar URLs
//e sentenças dinâmicas.
string nome = "João";
string saudacao = "Olá " + nome + ", Bem-vindo!";
Console.WriteLine(saudacao);


//Interpolação de strings ($) - permite incorporar variáveis diretamente em uma string.
string nome2 = "João";
string saudação = $"Olá, {nome2}, Bem-Vindo!";
Console.WriteLine(saudação);


//GetType() é usado para obter o tipo da instância de um objeto em tempo de execução
int numero = 7;
Console.WriteLine(numero.GetType());


//typeof() é usada para obter o tipo de uma CLASSSE ou ESTRUTUTRA em tempo de criação
Console.WriteLine(typeof(int));


//O metodo parse é um metodo de tipos de dados específicos como int, double, decimal, entre outros
//Ele converte uma string em um valor do tipo especificado. 
string ValorTexto = "100";
Console.WriteLine("A variável ValorTexto é do tipo" + ValorTexto.GetType());

int numero1 = int.Parse(ValorTexto);
Console.WriteLine(numero1);
Console.WriteLine("A variável numeroParse é do tipo:" + numero1.GetType());


//Metodo Convert permite convertert uma variedade maior de tipos de dados

string valorEmTexto = "100";

int numeroConvertido = Convert.ToInt32(valorEmTexto);
Console.WriteLine(numeroConvertido.GetType());


//Metodo To.String consegue converter QUALQUER tipo de dados em tipo string
int numerao = 9878;
Console.WriteLine(numerao.GetType());

string numeraoemstring = numerao.ToString();
Console.WriteLine(numeraoemstring.GetType());



//Conversão de Datas com o To.String.
DateTime  dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
Console.WriteLine(dataFormatada);

string dataHora = dataAtual.ToString("HH:mm:ss");
Console.WriteLine(dataHora);


//Uso em interpolação de moedas
double preço = 29.99;
Console.WriteLine($"O preço é: {preço.ToString("C2")}");


//Cultura e Formato
decimal valor = 1234.98m;
string valorUS = valor.ToString("C", new System.Globalization.CultureInfo("en-US"));
Console.WriteLine(valorUS);

string valorBR = valor.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
Console.WriteLine(valorBR);