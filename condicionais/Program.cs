//A condicional if sempre lê o primeiro bloco{}, se o primeiro bloco for FALSO ele lê o segundo bloco{}.
// double nota1 = 5.5;
// double nota2 = 6.0;
// double nota3 = 7.0;
// double media = (nota1 + nota2 + nota3) / 3;
// if (media>=7)
// {
//     Console.WriteLine($"Média: {media:F2}, Aprovado!");
// }
// else
// {
//     Console.WriteLine($"Média: {media:F2}, Recuperação.");
// }


//If aninhado
//if, else e else if não terminam com ponto e virgula.
// double nota4 = 9;
// double nota5 = 1;
// double nota6 = 5;
// double mediaNota = (nota4 + nota5 + nota6) / 3;
// if (mediaNota >= 7)
// {
//     Console.WriteLine($"Média: {mediaNota:F2}. Aluno aprovado!");
// }
// else if (mediaNota >= 5 && mediaNota < 7)
// {
//     Console.WriteLine($"Média: {mediaNota:F2}. Aluno de recuperação");
// }
// else
// {
//     Console.WriteLine($"Média: {mediaNota:F2}. Aluno Reprovado.");
// }



// Console.WriteLine("Digite uma vogal:");
// string? letra = Console.ReadLine();
// if (letra == "a" || letra == "A")
// {
//     Console.WriteLine($"Você digitou a vogal: {letra}");
// }
// else if (letra == "e" || letra == "E")
// {
//     Console.WriteLine($"Você digitou a vogal: {letra}");
// }
// else if (letra == "i" || letra == "I")
// {
//     Console.WriteLine($"Você digitou a vogal: {letra}");
// }
// else if (letra == "o" || letra == "O")
// {
//     Console.WriteLine($"Você digitou a vogal: {letra}");
// }
// else if (letra == "u" || letra == "U")
// {
//     Console.WriteLine($"Você digitou a vogal: {letra}");
// }
// else
// {
//     Console.WriteLine("Você não digitou uma vogal.");
// }


//Switch Case é usado quando há várias possibilidades de uma variável.
//Espaçamento do console.WriteLine e break feito com a tecla TAB.
// string dia = "Sábado";

// switch (dia)
// {
//     case "Sábado":
//         Console.WriteLine("Sábadooooooo galera!");
//         break;
//     case "Domingo":
//         Console.WriteLine("Domingão, hoje é dia de assistir o malvadão");
//         break;
//     default:
//         Console.WriteLine("Hoje é dia de semana, para de preguiça, levanta e vai trabalhar!");
//         break;
// }


//Estutura Condicional: como vimos anteriormente podemos fazer uma série de else if s para saber a vogal, 
//mas com o switch case é muito mais fácil:
// Console.WriteLine("Digite uma vogal:");
// string? letra = Console.ReadLine();
// string letraminuscula = letra.ToLower();

// switch (letraminuscula)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine($"A letra '{letraminuscula}' é uma vogal.");
//         break;
//     default:
//         Console.WriteLine($"A letra ou número '{letraminuscula}' não é uma vogal");
//         break;

// }


//Operador Ternário é uma forma mais simples de escrever uma estrutura condicional if else um uma única linha
// int idade = 25;
// string mensagem = idade>=18 ? "Maior de idade" : "Menor de idade";
// //Se o resultado da variável string é verdadeiro então irá retornar a primeira mensagem, senão retornará a segunda mensagem.
// Console.WriteLine(mensagem);
//melhor usar esse método do que o if else pois ocupa menos memoria



//Exercício 01 - Fluxograma
// Console.WriteLine("Digite sua idade:");
// string? idade = Console.ReadLine();
// int idadeconvertida = Convert.ToInt32(idade);
// Console.WriteLine(" Você possui autorização?");
// string? autorizacao = Console.ReadLine();
// bool autorização = Convert.ToBoolean(autorizacao);

// if (idadeconvertida>=18 || autorização == true)
// {
//     Console.WriteLine("Autorizado");
// }
// else 
// {
//     Console.WriteLine("Não autorizado");
// }

//outra solução
// bool eMaiordeIdade = true;
// bool PossuiAutorização = false;
// string mensagem = eMaiordeIdade || PossuiAutorização ? "Entrada Liberada" : "Entrada não liberada";
// Console.WriteLine(mensagem);




//Exercicio 2 - Fluxograma
// double nota1 = 5.0;
// double nota2 = 6.0;
// double nota3 = 8.0;
// double media = (nota1 + nota2 + nota3) / 3;
// bool presença = true;
// string? mensagem = presença && media>=7 ? "Aprovado" : "Reprovado";
// Console.WriteLine(mensagem);


Console.WriteLine("Possui presença mínima?");
string? pre = Console.ReadLine();
bool presença = Convert.ToBoolean(pre);

if (presença == false)
{
    Console.WriteLine("Reprovado");
}
else
{
    Console.WriteLine("Possui média maior ou igual a 7?");
    string? me = Console.ReadLine();
    bool media = Convert.ToBoolean(me);
    string? mensagem = media  ? "Aprovado" : "Reprovado";
    Console.WriteLine(mensagem);
}





//Exercício 3 - Fluxograma
// bool chuva = false;
// bool tarde = false;
// string? mensagem = !chuva && !tarde ? "Vou pedalar!" : "Vou pedalar outro dia";
// Console.WriteLine(mensagem);

// Console.WriteLine("Choveu?");
// string? ch = Console.ReadLine();
// bool choveu = Convert.ToBoolean(ch);

// if (choveu)
// {
//     Console.WriteLine("Vou pedalar outro dia.");
// }
// else
// {
//     Console.WriteLine("Está tarde?");
//     string? ta = Console.ReadLine();
//     bool tarde = Convert.ToBoolean(ta);
//     string? mensagem = !tarde ? "Vou pedalar" : "Vou pedalar outro dia";
//     Console.WriteLine(mensagem);
// }