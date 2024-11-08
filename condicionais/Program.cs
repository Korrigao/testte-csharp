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


//Operador Ternário é uma forma mais simples de escreer uma estrutura condicional if else um uma única linha
int idade = 15;
string mensagem = idade>=18 ? "Maior de idade" : "Menor de idade;"
Console.WriteLine(mensagem);
