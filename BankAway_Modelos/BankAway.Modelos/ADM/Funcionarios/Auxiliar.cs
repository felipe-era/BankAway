namespace BankAway.Modelos.ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        /// <summary>
        /// Teste subindo doc no vs na real
        /// </summary>
        /// <param name="cpf">CPF do usuário</param>
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        protected internal override double getBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
