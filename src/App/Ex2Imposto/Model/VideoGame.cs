using Ex2Imposto.Interfaces;

namespace Ex2Imposto.Model
{
    public class VideoGame : Produto, IImposto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }

        public double CalculaImposto()
        {
            double resultado;

            if(IsUsado == true)
            {
                resultado = Preco * 0.25;
            }
            else
            {
                resultado = Preco * 0.45;
            }

            return resultado;
        }
    }

}