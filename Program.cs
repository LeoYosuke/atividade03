using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoTrabalho
{
	class Program
	{
		static void Main(string[] args)
		{
			string usuario1= "Yosuke";
			string usuario2 = "angelico";
			int idade1 = 18;
			int idade2 = 24;
			int ca1 = 187;
			int ca2 = 5;
			int cafeFalta1 = 200 - ca1;
			int cafeFalta2 = 200 - ca2;
			bool c1 = true;
			bool c2 = false;



			Console.WriteLine("Aula 03 - Atividade com variaveis");
			Console.WriteLine("\n \n");
			Console.WriteLine("Olá!");
			Console.WriteLine("bem-vindo ao sistema de usuarios do conradito");
			Console.WriteLine("Abaixo estão as informações dos usuarios cadastrados no nosso sistema:");
			Console.WriteLine("\n \n");
			Console.WriteLine("-----lista de usuarios");
			Console.WriteLine($"1 - nome: {usuario1}, idade: {idade1}. É cliente: {c1}");
			Console.WriteLine($"2 - nome: {usuario2}, idade: {idade2}. É cliente: {c2}");
			Console.WriteLine("\n");
			Console.WriteLine("------ Quantidade de cafés");
			Console.WriteLine($"O cliente {usuario1} já tomou {ca1} cafés!");
			Console.WriteLine($"O cliente {usuario2} já tomou {ca2} cafés!");
			Console.WriteLine("\n \n");
			Console.WriteLine("----- soma de cafés tomados");
			Console.WriteLine($"juntos, os  cliente {usuario1} e {usuario2} tomaram {ca1 + ca2} cafés!");
			Console.WriteLine("\n \n");
			Console.WriteLine("------ Quantos cafés falta para chegar em 200");
			Console.WriteLine($"faltam {cafeFalta1} para {usuario1} ");
			Console.WriteLine($"faltam {cafeFalta2} para {usuario2} ");
			Console.WriteLine("\n \n \n");
			Console.WriteLine("------ fim do sistema de  consultas");
			Console.WriteLine("- Obrigado e volta sempre!");







			Console.ReadKey();
		}
	}
}
