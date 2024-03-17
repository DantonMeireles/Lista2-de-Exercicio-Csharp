using System;

class Program {
  public static void Main (string[] args) {
  /*Construa um algoritmo que leia o valor de uma conta de luz (CL) e, caso o valor seja maior
que R$ 50,00 apresente a mensagem: “Você está gastando muito”. Caso contrário não
exiba mensagem nenhuma.*/
double conta;
Console.WriteLine("Qual o valor da conta de luz?");
conta = double.Parse(Console.ReadLine());

if (conta > 50)
{
	Console.WriteLine("Você está gastando muito");

}

  }
}
