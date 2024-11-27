
// int res;
// Console.WriteLine("Digite seu número:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite seu outro número:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite seu Símbolo + /- / * ou /");
// string operador = Console.ReadLine();


// switch (operador)
//                 {
//                     case "+":
//                         res = num1 + num2;
//                         Console.WriteLine("Addition:" + res);
//                         break;
//                     case "-":
//                         res = num1 - num2;
//                         Console.WriteLine("Subtraction:" + res);
//                         break;
//                     case "*":
//                         res = num1 * num2;
//                         Console.WriteLine("Multiplication:" + res);
//                         break;
//                     case "/":
//                         res = num1 / num2;
//                         Console.WriteLine("Division:" + res);
//                         break;
//                     default:
//                         Console.WriteLine("Wrong input");
//                         break;
//                 }
// using System;
// using Calculadora_Modelo;


// Console.WriteLine("Digite seu número:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite seu outro número:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite seu Símbolo + /- / * ou /");
// string operador = Console.ReadLine();

// if (operador == +)
// {
//     Console.WriteLine(num1 + num2);
// }
// else if (operador == -)
// {
//     Console.WriteLine(num1 - num2);
// }


public class Calculadora
{
    public double Multiplicar(double a, double b)
    {
        return a * b;
    }
    public double dividir(double a, double b)
    {
        if(b == 0)
        {
            Console.WriteLine("Erro, divisão por zaro não permitido");
            return double.NaN;
        }
        return a / b;
    }
    public Subtrair(double a, double b)
    {
        return a - b;
    }
    public adicao(double a, double b)
    {
        return a + b;
    }
}