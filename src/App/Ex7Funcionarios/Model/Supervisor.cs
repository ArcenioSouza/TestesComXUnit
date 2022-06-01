namespace Ex7Funcionarios.Model
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
            
        }

        public override double Bonificacao()
        {
            return Salario += 5000;
        }
    }
}