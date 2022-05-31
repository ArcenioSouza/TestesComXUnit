namespace Ex2Imposto.Model
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtd { get; set; }

        public Produto(string nome, double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }
    }

}