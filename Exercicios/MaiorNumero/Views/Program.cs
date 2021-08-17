using System;

namespace MaiorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("informe um numero ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe outro numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 < numero2) {

                Console.WriteLine("O numero 1 e menor que numero 2");
            }

            else {
                Console.WriteLine("O numero 2 e menor que numero 1");
            }
        }
    }
}
