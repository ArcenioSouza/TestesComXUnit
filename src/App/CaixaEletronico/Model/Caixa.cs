using System;

namespace CaixaEletronico.Model
{
    public class Caixa
    {
        public int Notas100 {get; set; }
        public int Notas50 {get; set; }
        public int Notas20 {get; set; }
        public int Notas10 {get; set; }
        public void Saque(int Valor)
        {
            Notas100 = Valor / 100;
            int resto = Valor - (Notas100 * 100);
            Notas50 = resto / 50;
            resto -= Notas50 * 50;
            Notas20 = resto / 20;
            resto -= Notas20 * 20;
            Notas10 = resto / 10;
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Valor do Saque R${Valor},00");
            Console.WriteLine($"\nQuantidade de notas:\nNotas de R$100: {Notas100}");
            Console.WriteLine($"Notas de R$50: {Notas50}");
            Console.WriteLine($"Notas de R$20: {Notas20}");
            Console.WriteLine($"Notas de R$10: {Notas10}");
        }
    }
}