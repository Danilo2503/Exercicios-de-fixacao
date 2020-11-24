using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tipo de combustível que deseja \n A-Álcool G-Gasolina");
            string combustível = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de combustível:");
            float quantidadeCombustível = float.Parse(Console.ReadLine());


            float precoDesconto, desconto, valorTotal;
            float precoAlcool = 4.9f;
            float precoGasolina = 5.3f;


            switch(combustível.ToLower())
            {
                case "A":
                    if(quantidadeCombustível > 20){
                        precoDesconto = 0.05f;
                    }else{
                        precoDesconto = 0.03f;
                    }
                    valorTotal = (quantidadeCombustível * precoAlcool);
                    desconto = (quantidadeCombustível * precoAlcool) * precoDesconto;
                    Console.WriteLine($"O valor a ser pago {valorTotal - desconto}");
                    break;
                case "G":
                    if(quantidadeCombustível > 20){
                        precoDesconto = 0.06f;
                    }else{
                        precoDesconto = 0.04f;
                    }
                    valorTotal = (quantidadeCombustível * precoGasolina);
                    desconto = (quantidadeCombustível * precoGasolina) * precoDesconto;
                    Console.WriteLine($"O valor a ser pago {valorTotal - desconto}");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;            
            }
        }
    }
}
