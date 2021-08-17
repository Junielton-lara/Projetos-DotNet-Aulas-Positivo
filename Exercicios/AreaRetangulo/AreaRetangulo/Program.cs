using System;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de retangulo");

            Console.WriteLine("informe a altura");
            int altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a largura largura");
            int largura = Convert.ToInt32(Console.ReadLine());
            
            int total = largura + altura;

           

            Console.WriteLine("A area do retangulo é  " + total);
          
        }
    }
}
