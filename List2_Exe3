using System;

class Program {
  public static void Main (string[] args) {
    /*Construa um algoritmo que, tendo como dados de entrada a altura (H) e o sexo (S) de
uma pessoa calcule e apresente seu peso ideal utilizando as seguintes fórmulas:
Para homens: Peso ideal (P) = (72,7 * H) – 58
Para mulheres: Peso ideal (P) = (62,1 * H) – 44,7*/
double h, p;
double s;
Console.WriteLine("Qual a sua altura?");
h = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu sexo? (feminino ou masculino?)");
Console.WriteLine("Digite 1 para masculino");
Console.WriteLine("Digite 2 para feminino");
s = double.Parse(Console.ReadLine());

if (s==1)
{
	p = (72.7 * h) - 58;
	Console.WriteLine("O seu peso ideal é: {0:F2}kg", p);
}

else if (s==2)
{
	p = (62.1 * h) - 58;
	Console.WriteLine("O seu peso ideal é: {0:F2}kg", p);
}
else
Console.WriteLine ("Impóssivel calcular");

  }
}
