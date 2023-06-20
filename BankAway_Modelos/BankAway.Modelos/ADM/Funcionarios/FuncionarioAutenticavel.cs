using BankAway.Modelos.ADM.SistemaInterno;
using BankAway_Modelos.BankAway.Modelos.ADM.Utilitario;

namespace BankAway.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public AutenticacaoUtil autenticador { get; set; }


        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return this.autenticador.ValidarSenha(this.Senha, senha);
        }
    }
}
