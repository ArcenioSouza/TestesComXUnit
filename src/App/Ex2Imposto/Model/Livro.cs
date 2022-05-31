using Ex2Imposto.Interfaces;

namespace Ex2Imposto.Model
{
    public class Livro : Produto, IImposto
    {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        }

        public double CalculaImposto()
        {
            double resultado;

            if(Tema == "educativo")
            {
                resultado = 0;
            }
            else
            {
                resultado = Preco * 0.10;
            }
            return resultado;
        }
    }

}