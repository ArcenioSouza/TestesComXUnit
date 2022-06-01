using System;
using System.Collections.Generic;

namespace CaixaEletronico.Model
{
    class Caixa
    {
        public void Saque(int Valor)
        {
            int notas100 = Valor / 100;
            int resto = Valor - (notas100 * 100);
            int notas50 = resto / 50;
            resto -= notas50 * 50;
            int notas20 = resto / 20;
            resto -= notas20 * 20;
            int notas10 = resto / 10;
            resto -= notas10 * 10;
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Valor do Saque R${Valor},00");
            Console.WriteLine($"\nQuantidade de notas:\nNotas de R$100: {notas100}");
            Console.WriteLine($"Notas de R$50: {notas50}");
            Console.WriteLine($"Notas de R$20: {notas20}");
            Console.WriteLine($"Notas de R$10: {notas10}");
        }
    }
}