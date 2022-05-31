using System;

namespace Ex1Veiculo
{
    public class ProgramVeiculo
    {
        public static void Main()
        {
            Console.WriteLine("Bem vindo ao teste drive do seu veículo!");
            Console.WriteLine("Antes de começar vamos fazer o cadastro do seu veículo:");

            Console.WriteLine("Digite a marca do seu veículo:");
            string marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo do seu veículo:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Digite a placa do seu veículo:");
            string placa = Console.ReadLine();

            Console.WriteLine("Digite a cor do seu veículo:");
            string cor = Console.ReadLine();

            Console.WriteLine("Digite a quilometragem do seu veículo:");
            string km = Console.ReadLine();
            float convertKm = float.Parse(km);

            Console.WriteLine("Digite o preço do seu veículo:");
            string preco = Console.ReadLine();
            double convertPreco = double.Parse(preco);

            Veiculo testDrive = new Veiculo(marca, modelo, placa, cor, convertKm, convertPreco);

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
