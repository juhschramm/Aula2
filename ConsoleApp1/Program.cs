using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular seu IMC? Digite sua altura:");
            string alturaEmString = Console.ReadLine();
            float altura = float.Parse(alturaEmString);
            

            Console.WriteLine("Informe seu peso:");
            string pesoEmString = Console.ReadLine();
            float peso = float.Parse(pesoEmString);

            float imc = CalcularIMC(altura, peso);
        }
        private static float CalcularIMC(float altura, float peso) =>

        peso / (altura * altura);
        
    

    private static void ExibirIMC(float imc)
      {
         if (imc < 16)
            Console.WriteLine("Magreza Moderada");
        else if (imc <= 18)
            Console.WriteLine("Magreza Moderada");
        else if (imc <= 18.4)
            Console.WriteLine("Magreza leve");
        else if (imc <= 24)
            Console.WriteLine("Saudável");
        else if (imc <= 29)
            Console.WriteLine("Sobrepeso");
        else if (imc <= 34)
            Console.WriteLine("Grau 1");
        else if (imc <= 34)
            Console.WriteLine("Grau 2");
        else
            Console.WriteLine("Grau 3");
        Console.ReadLine();
        
      }
    }

}
