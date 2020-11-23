using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do produto em questão:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe qual foi a quantidade adquirida desse produto:");
            int quant = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário desse produto");
            float valor = float.Parse(Console.ReadLine());

            float total = quant * valor;
            Console.WriteLine("O total foi de $: "+total);

            float totalpag = total * desconto;

            if(quant <= 5){
                desconto = 0,98;        
            }

        }
    }
}
