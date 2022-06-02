using System;
using System.Threading;

namespace Ex1Veiculo
{
    public class ProgramVeiculo
    {
        public static void Main()
        {
            bool Loop = true;
            string Marca = "";
            string Modelo = "";
            string Placa = "";
            string Cor = ""; 
            float ConvertKm = 0;
            double ConvertPreco = 0;

            while (Loop == true)
            {
                Console.WriteLine("Bem vindo ao teste drive do seu veículo!");
                Console.WriteLine($"----------------------------------------------------");
                Console.WriteLine("Antes de começar vamos fazer o cadastro do veículo:");
                Console.WriteLine($"----------------------------------------------------");
                Console.WriteLine("Digite a marca do seu veículo:");
                Marca = Console.ReadLine();
                Console.WriteLine($"----------------------------------------------------");
                Console.WriteLine("Digite o modelo do seu veículo:");
                Modelo = Console.ReadLine();
                Console.WriteLine($"----------------------------------------------------");
                Console.WriteLine("Digite a placa do seu veículo:");
                Placa = Console.ReadLine();
                Console.WriteLine($"----------------------------------------------------");
                Console.WriteLine("Digite a cor do seu veículo:");
                Cor = Console.ReadLine();
                Console.WriteLine($"----------------------------------------------------");
                Console.WriteLine("Digite a quilometragem do seu veículo:");
                string Km = Console.ReadLine();
                ConvertKm = Km == "" ? 0 : float.Parse(Km);
                Console.WriteLine($"----------------------------------------------------");
                Console.WriteLine("Digite o preço do seu veículo:");
                string Preco = Console.ReadLine();
                ConvertPreco = Preco == "" ? 0 : double.Parse(Preco);
                Console.WriteLine($"----------------------------------------------------");

                if(Marca != "" && Modelo != "" && Placa != "" && ConvertKm != 0 && ConvertPreco != 0)
                {
                    Loop = false;
                }
                else
                {
                    Console.WriteLine($"Existem dados faltando, preencha todos os dados para continuar");
                    Console.WriteLine($"---------------------------------------------------------------");
                    Thread.Sleep(2000);                    
                }
            }

            Veiculo testDrive = new Veiculo(Marca, Modelo, Placa, Cor, ConvertKm, ConvertPreco);

            Console.WriteLine("Agora vamos iniciar o teste do seu veículo");
            string app = "2";

            while (app == "2")
            {
                Console.WriteLine("Escolha o que deseja fazer informando um dos números abaixo");
                Console.WriteLine("1 - Acelerar;\r\n2 - Abastecer;\r\n3 - Frear;\r\n4 - Pintar;\r\n5 - Ligar;\r\n6 - Desligar");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        testDrive.Acelerar();
                        break;
                    case "2":
                        Console.WriteLine("Digite a quantidade de combustível em litros:");
                        string qtdCombustivel = Console.ReadLine();
                        int convertQtdCombustivel = int.Parse(qtdCombustivel);
                        testDrive.Abastecer(convertQtdCombustivel);
                        break;
                    case "3":
                        testDrive.Frear();
                        break;
                    case "4":
                        Console.WriteLine("Digite nova cor do veículo");
                        string corVeiculo = Console.ReadLine();
                        testDrive.Pintar(corVeiculo);
                        break;
                    case "5":
                        testDrive.Ligar();
                        break;
                    case "6":
                        testDrive.Desligar();
                        if (testDrive.isLigado == false)
                        {
                            Console.WriteLine("Você deseja sair do teste drive?\r\n1 - Sim\r\n2 - Não");
                            app = Console.ReadLine();
                        }
                        break;
                }
            }
        }
    }
}
