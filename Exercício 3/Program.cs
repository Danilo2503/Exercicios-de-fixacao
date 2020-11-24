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

            float desconto = float.Parse(Console.ReadLine());
            float totalPagar = total * desconto;
 
            if(quant <= 5){
                desconto = 0.98f; 

                if(quant > 5 || quant <=10){
                    desconto = 0.97f;

                    if(quant > 10){
                        desconto = 0.95f;
                    }
                }    
            }
           
            Console.WriteLine("O total com o desconto foi de $: "+totalPagar);
 
        }
    }
}
