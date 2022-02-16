using System;

namespace Calculator.Common
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("Qual Operação deseja Realizar ?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair da Calculadora");

      Console.WriteLine("----------------");
      Console.WriteLine("Selecione uma opção:  ");

      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;

      }
    }

    static void Soma()
    {
      Console.Clear(); //Efeito de Limpar a Tela no Terminal!

      Console.WriteLine("Primeiro Valor:  "); //Pede para o Usuário colocar o Primeiro valor na Calculadora!
      float v1 = float.Parse(Console.ReadLine()); //Linha para o Usuário digitar o Primero valor!!.

      Console.WriteLine("Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 + v2;
      //Console.WriteLine("O Resultado da soma é :" + resultado);
      Console.WriteLine($"O Resultado da soma é : {resultado}");
      //Console.WriteLine($"O Resultado da soma é : {v1 + v2}");
      //Console.WriteLine($"O Resultado da soma é :" + (v1 + v2));
      Console.ReadKey();
      Menu();
    }

    static void Subtracao()
    {

      Console.Clear();

      Console.WriteLine("Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 - v2;
      Console.WriteLine($"O Resultado da Subtracao é : {resultado}");

      Console.ReadKey();

      Menu();
    }


    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro Valoriro");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine(" ");

      float resultado = v1 / v2;
      Console.WriteLine($"O resultado da divisão é : {resultado}");

      Console.ReadKey();

      Menu();


    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro Valor:  ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:  ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 * v2;
      Console.WriteLine($"Resultado da Multiplicação {resultado} ");

      Console.ReadKey();

      Menu();
    }

  }

}
