using BankAway.Modelos.ADM.SistemaInterno;
using BankAway_Modelos.BankAway.Modelos.ADM.Utilitario;

namespace BankAway.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        AutenticacaoUtil Autenticador { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }
        public bool Autenticar(string senha)
        {
            return this.Autenticador.ValidarSenha(this.Senha,
                senha);
        }
    }
}
