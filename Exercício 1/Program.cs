using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleições");
            Console.WriteLine("---------");

            Console.WriteLine("Informe o ano atual");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora informe seu ano de nascimento");
            int nasc = int.Parse(Console.ReadLine());

            int idade = ano - nasc;


            if(idade >= 18){
                Console.WriteLine("Você está apto a votar esse ano.");

                if(idade == 16){
                    Console.WriteLine("Você poderá votar esse ano,porém seu voto não é obrigatório.");
                }

            }else{
                Console.WriteLine("Você não poderá votar esse ano.");
            }

        }
    }
}
