//Estrutras de Repetição
//são ferramentas que permitem a automatização repetida de um bloco de código.
//executar uma tarefa repetidamente, percorrer coleção de dados, executar um bloco até que uma condição expecífica seja atendida.
// toda vez que colocarmos um loop precisamos colocar uma condição de parada senão forma-se um loop infinito.

//PARA PARAR UM LOOP INFINITO BASTA CLICAR NO TERMINAL E PRESSIONAR CRTL + C



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
// //a condição do while precisa ser verdade para executar o bloco verdade.
// while (contador != numero)
// {
//     Console.WriteLine($"Contador: {contador}.");
//     contador++;
// }
// Console.WriteLine($"Contador atingiu o número alvo: {contador}");







//do while - semelhante ao while, mas garante que o bloco de codigo seja executado ao menos uma vez pois a condição
//é verificada somente após a primeira execução.
// int numero = 12;
// do
// {
//     Console.WriteLine($"Número: {numero}");
//     numero++;
// }while (numero < 10);





//for - utiizado quando o numero de repetições é conhecido previamente. Útil para exeutar um bloco de codigo num numero fixo de vezes.
// for(inicialização; condição; incremento)
// {
//     //códigoa ser executando em cada iteração
// }

// for (int i = 0;i <= 10; i++)
// {
//     Console.WriteLine($"Valor de i: {i}");
// }





//ForEach - usado para iterar sobre todos elementos de uma coleção como arrays. 
//ideal para sitações em que voce quer acessar cada elemento da coleção sem se preocupar com indices.
//neste exemplo o codigo percorre o array de strings chamado nomes e imprime cada nome contido nele no console.
// string[] nomes = {"João", "Thomas", "Andrea"};
// foreach (string nome in nomes)
// {
//     Console.WriteLine(nome);
// }



