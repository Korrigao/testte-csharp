//Estrutura de dados armazenam de maneira eficiente dados para que possam ser acessados.

//Array armazenado na memoria e cada elemento armazenado possui um indice. O indice de um array SEMPRE começa com ZERO.
//neste exemplo foi um array do tipo inteiro, o seu tamanho de 5 elementos
// int[] meuArray = new int[5];
// meuArray[0] = 10;
// meuArray[1] = 20;
// meuArray[2] = 30;
// meuArray[3] = 40;
// meuArray[4] = 50;

// Console.WriteLine("Números no array:");

// for (int i = 0; i < meuArray.Length; i++)
// {
//     Console.WriteLine(meuArray[i]);
// }




//Lista - Representa uma lista de objetos que pode crescer ou diminuir dinamicamente. A o contrário do array que é fixo.
List<string> listadenomes = new List<string> {"João", "Thomas", "Andrea"};
listadenomes.Add("Valdiney");

Console.WriteLine("Nomes na lista:");
for (int i = 0; i < listadenomes.Count; i++) //a palavra .Count faz a mesma coisa que o .Lenght do Array. 
{                                            //Ele mosta a quantidade de objetos na lista.
    Console.WriteLine(listadenomes[i]);
}


// //Contains
Console.WriteLine("\nVerificação da existência do nome Ryan na lista"); // "\n" pula uma linha no console.
if (listadenomes.Contains("Ryan"))
{
        Console.WriteLine("Contem");
}
else
{
        Console.WriteLine("Não contém");
}


//Remoção de elementos na lista
Console.WriteLine("\nApós remover Thomas");
string  nomeParaRemover = "Thomas";
bool foiRemovido = listadenomes.Remove(nomeParaRemover); // O método remove retorna true ou false.

if (foiRemovido)
{
    Console.WriteLine($"{nomeParaRemover} foi removido da lista");
}
else
{
    Console.WriteLine($"{nomeParaRemover} não foi encontrado na lista");
}




//
