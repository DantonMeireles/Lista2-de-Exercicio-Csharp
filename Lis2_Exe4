using System;

class Program {
  public static void Main (string[] args) {
  /*Construa um algoritmo que determine quanto será gasto para encher o tanque de um carro
(VG), sabendo-se que o preço da gasolina é de R$ 1,80 e o preço do álcool é de R$ 1,00. O
usuário fornecerá os seguintes dados: Tipo de carro (TC) (G – gasolina ou A – álcool) e
Capacidade do tanque (CT), em litros.*/
double tc, g, a, ct;
Console.WriteLine("Qual a capacidade do tanque? (em litros)");
ct = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o tipo do seu carro?");
Console.WriteLine("Você deseja colocar gasolina ou álcool?");
Console.WriteLine("Digite 1 para gasolina");
Console.WriteLine("Digite 2 para álcool");
tc = double.Parse(Console.ReadLine());


if (tc==1)
{
	g = (ct * 1.80);
	Console.WriteLine("O preço total será de: R${0:F2}", g);
}

else if (tc==2)
{
	a = (ct * 1.00);
	Console.WriteLine("O preço total será de: R${0:F2}", a);
}

else
{
	Console.WriteLine("Impossivel calcular");
}


  }
}
