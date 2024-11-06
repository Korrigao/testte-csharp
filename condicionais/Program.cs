//A condicional if sempre lê o primeiro bloco{}, se o primeiro bloco for FALSO ele lê o segundo bloco{}.
double nota1 = 5.5;
double nota2 = 6.0;
double nota3 = 7.0;
double media = (nota1 + nota2 + nota3) / 3;
if (media>=7)
{
    Console.WriteLine($"Média: {media:F2}, Aprovado!");
}
else
{
    Console.WriteLine($"Média: {media:F2}, Recuperação.");
}