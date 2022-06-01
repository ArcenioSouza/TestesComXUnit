namespace Ex7Funcionarios.Model
{
    public class Vendedor : Funcionario
    {
         public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
            
        }

        public override double Bonificacao()
        {
            return Salario += 3000;
        }
    }
}