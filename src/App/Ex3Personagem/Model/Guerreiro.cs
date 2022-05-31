using System;
using System.Collections.Generic;

namespace Ex3Personagem.Model
{
    public class Guerreiro : Personagem
    {
        public List<String> Habilidade = new List<string>();

        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            
        }

        public void ListarHabilidades(){
            foreach (var item in Habilidade)
            {
                Console.WriteLine(item);                
            }
        }

        public void ListarEvolucao(){
            Console.WriteLine("Level: " + this.Level + "\r\nForça: " + this.Forca + "\r\nVida: " + this.Vida + "\r\nMana: " + this.Mana + "\r\nInteligência: " + this.Inteligencia + "\r\nXP: " + this.Xp);            
        }

        public override void LvlUp()
        {
            Level += 1;
            Vida += 600;
            Mana += 70;
            Inteligencia += 10;
            Forca += 150;
            Xp += 500f;
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

        public void AprenderHabilidade(string nomeHabilidade)
        {
            Habilidade.Add(nomeHabilidade);
        }
    }
}