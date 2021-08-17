using System;

namespace IdadePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());


            if ( idade < 13 ){

                Console.WriteLine("Criança");
            }
                else if ( idade > 13 && idade <=18){
                    Console.WriteLine("Adolecente");
                    }
                    else if ( idade > 18 && idade <=60){
                        Console.WriteLine("adulto");
                    }
                        else if ( idade > 60){
                        Console.WriteLine("Idoso");
                    }
        }
    }
}
