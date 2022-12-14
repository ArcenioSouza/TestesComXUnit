namespace Ex7Funcionarios.Model
{
    public abstract class Funcionario
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public double Salario {get; set;}

        public Funcionario(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public virtual double Bonificacao()
        {
            return Salario;
        }
    }
}