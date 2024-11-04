//Concatenação - faz a junção de duas ou mais strings, ou cadeias de caractéres, em uma única string. Muita utilizada para criar URLs
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