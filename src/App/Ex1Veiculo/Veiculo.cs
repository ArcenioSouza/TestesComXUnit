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
        public int acelerar()
        {
            if (isLigado == true)
            {
                Velocidade = Velocidade + 20;
                Console.WriteLine("O veículo aumentou sua velocidade!");
                Console.WriteLine("Velocidade atual: " + Velocidade);
                return 1;
            }
            else
            {
                Console.WriteLine("Seu veículo está desligado, ligue ele antes de acelerar");
                return 0;
            }

        }

        public int abastecer(int combustivel)
        {
            if (litrosCombustivel + combustivel > 60)
            {
                int qtdPossivel = 60 - litrosCombustivel;
                Console.WriteLine("A Quantidade de combustível excede o total do tanque.");
                Console.WriteLine("Quantidade de combustível para encher o tanque: " + qtdPossivel + " litros");
                return 0;
            }
            else
            {
                litrosCombustivel = litrosCombustivel + combustivel;
                Console.WriteLine("Veículo abastecido com sucesso");
                Console.WriteLine("Quantidade de combustível: " + litrosCombustivel + " litros");
                return 1;
            }
        }

        public int frear()
        {
            if (Velocidade == 0)
            {
                Console.WriteLine("O veículo está parado");
                return 0;
            }
            else
            {
                Velocidade = Velocidade - 20;
                Console.WriteLine("Velocidade diminuida para " + Velocidade);
                return 1;
            }
        }

        public void pintar(string cor)
        {
            Cor = cor;
            Console.WriteLine("O veículo agora está pintado na cor " + cor);
        }

        public void ligar()
        {
            if (isLigado == false)
            {
                isLigado = true;
                Console.WriteLine("O veículo foi ligado");
            }
            else
            {
                Console.WriteLine("O veículo já está ligado");
            }
        }

        public void desligar()
        {
            if (isLigado == true)
            {
                if (Velocidade > 0)
                {
                    Console.WriteLine("Veículo em movimento, pare ele antes de desligar");
                }
                else
                {
                    isLigado = false;
                    Console.WriteLine("O veículo foi desligado");
                }
            }
            else
            {
                Console.WriteLine("O veículo já está desligado");
            }
        }

    }
}