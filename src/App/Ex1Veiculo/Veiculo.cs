using System;

namespace Ex1Veiculo
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool isLigado = false;
        public int litrosCombustivel = 0;
        public int Velocidade = 0;
        public double Preco;
        public Veiculo(string marca, string modelo, string placa, string cor, float km, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Km = km;
            Preco = preco;
        }
        public void Acelerar()
        {
            if (isLigado == true)
            {
                Velocidade += 20;
                Console.WriteLine("O veículo aumentou sua velocidade!");
                Console.WriteLine("Velocidade atual: " + Velocidade);
                Console.WriteLine($"-----------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Seu veículo está desligado, ligue ele antes de acelerar");
                Console.WriteLine($"-----------------------------------------------------------");
            }
        }
        public void Abastecer(int combustivel)
        {
            if (litrosCombustivel + combustivel > 60)
            {
                int qtdPossivel = 60 - litrosCombustivel;
                Console.WriteLine("A Quantidade de combustível excede o total do tanque.");
                Console.WriteLine("Quantidade de combustível para encher o tanque: " + qtdPossivel + " litros");
                Console.WriteLine($"-----------------------------------------------------------");
            }
            else
            {
                litrosCombustivel += combustivel;
                Console.WriteLine("Veículo abastecido com sucesso");
                Console.WriteLine("Quantidade de combustível: " + litrosCombustivel + " litros");
                Console.WriteLine($"-----------------------------------------------------------");
            }
        }
        public void Frear()
        {
            if (Velocidade == 0)
            {
                Console.WriteLine("O veículo já está parado");
                Console.WriteLine($"-----------------------------------------------------------");
            }
            else
            {
                Velocidade -= 20;
                Console.WriteLine("Velocidade diminuida para " + Velocidade);
                Console.WriteLine($"-----------------------------------------------------------");
            }
        }
        public void Pintar(string cor)
        {
            Cor = cor;
            Console.WriteLine("O veículo agora está pintado na cor " + cor);
            Console.WriteLine($"-----------------------------------------------------------");
        }
        public void Ligar()
        {
            if (isLigado == false)
            {
                isLigado = true;
                Console.WriteLine("O veículo foi ligado");
                Console.WriteLine($"-----------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("O veículo já está ligado");
                Console.WriteLine($"-----------------------------------------------------------");
            }
        }
        public void Desligar()
        {
            if (isLigado == true)
            {
                if (Velocidade > 0)
                {
                    Console.WriteLine("Veículo em movimento, pare ele antes de desligar");
                    Console.WriteLine($"-----------------------------------------------------------");
                }
                else
                {
                    isLigado = false;
                    Console.WriteLine("O veículo foi desligado");
                    Console.WriteLine($"-----------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("O veículo já está desligado");
                Console.WriteLine($"-----------------------------------------------------------");
            }
        }
    }
}