using System;
using System.Collections.Generic;

namespace Ex3Personagem.Model
{
    public class Mago : Personagem
    {
        List<String> Magia = new List<string>();

        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            
        }

        public void ListarEvolucao(){
            Console.WriteLine("Level: " + this.Level + "\r\nForça: " + this.Forca + "\r\nVida: " + this.Vida + "\r\nMana: " + this.Mana + "\r\nInteligência: " + this.Inteligencia + "\r\nXP: " + this.Xp);            
        }

        public void ListarMagias(){
            foreach (var item in Magia)
            {
                Console.WriteLine(item);
                
            }
        }

        public override void LvlUp()
        {
            Level++;
            Vida += 200;
            Mana += 500;
            Inteligencia += 100;
            Forca += 15;
            Xp += 700;
            Console.WriteLine($"Você subiu de level!!!");
        }

        public double Attack()
        {
            double Resultado;
            Random num = new Random();
            Resultado = (Forca * Level) + num.Next(0, 301);
            Console.WriteLine("Poder de ataque " + Resultado);
            return Resultado;
        }

        public void AprenderMagia(string nomeMagia)
        {
            Magia.Add(nomeMagia);
        }
    }
}