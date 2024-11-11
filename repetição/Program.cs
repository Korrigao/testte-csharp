//Estrutras de Repetição
//são ferramentas que permitem a automatização repetida de um bloco de código.
//executar uma tarefa repetidamente, percorrer coleção de dados, executar um bloco até que uma condição expecífica seja atendida.
// toda vez que colocarmos um loop precisamos colocar uma condição de parada senão forma-se um loop infinito.



//While - Quando o número de repetições não é conhecido antecipadamaente e depende de uma condição que pode mudar cada iteração.
//while(condição)
// {
//     //estrutura que é repetida até que a condição é atendida.
// } 
//(condição) avalidada antes de cada iteração

//Exemplo:
// int i = 3;
// while(i<5)
// {
//     Console.WriteLine(i);
//     i++;
// }

// Random numeroAleatorio = new Random();
// int numero = numeroAleatorio.Next(1,101); //a função next retorna um número aleatório entre 1 e 100, o primeiro número é sempre incluso
// int contador = 0;                         //na contagem do número aleatório já o segundo não.
// Console.WriteLine($"Número alvo: {numero}");
// //loop que incrementa o contador até ele atingir o número alvo.
// while (contador != numero)
// {
//     Console.WriteLine($"Contador: {contador}.");
//     contador++;
// }
// Console.WriteLine($"Contador atingiu o número alvo: {contador}");