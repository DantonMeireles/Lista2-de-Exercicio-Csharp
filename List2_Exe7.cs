using System;

class Program {
  public static void Main (string[] args) {
/*Construa um algoritmo que, recebendo os valores de vendas do mês de determinado
vendedor (VM) e o nome do mesmo (NOME), apresente o nome, quando o valor da venda
estiver entre R$ 10000,00 e R$ 50000,00 (inclusive).*/
double venda_mes, nome_mes;
string nome;

Console.WriteLine("Valor das vendas do mês:");
venda_mes = double.Parse(Console.ReadLine());

Console.WriteLine("Nome:");
nome = Console.ReadLine();

if(venda_mes>=10000)
	if(venda_mes<=50000)
	Console.WriteLine("O nome é: {0}, e o valor de vendas mês é: {1:F2}", nome, venda_mes);
else
	Console.WriteLine("");
else
Console.WriteLine("");
/*
if ((venda_mes>=10000) || (venda_mes<=50000))
	Console.WriteLine("O nome do mês é: {0}", nome);
	Console.WriteLine("O valor de vendas é: {0}", venda_mes);


else
	Console.WriteLine("");
  */
	}
}
