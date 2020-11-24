using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)

        
        {   Console.WriteLine("------------------");

            Console.WriteLine("Tabuada 1 a 10");
            for(int i = 0; i < 11; ++i){

                Console.WriteLine($"Tabuada do {i}");

                for(var contad = 0; contad < 11; contad++){
                    int resul = 1 * contad;
                    Console.WriteLine($"{i} x {contad} = {resul}");
                }

                Console.WriteLine("------------------");
            }


        }
    }
}
