using BankAway.Modelos.ADM.SistemaInterno;
using BankAway_Modelos.BankAway.Modelos.ADM.Utilitario;

namespace BankAway.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public AutenticacaoUtil autenticador{ get; set; }

        public bool Autenticar(string senha)
        {
            return this.autenticador.ValidarSenha(this.Senha, senha);
        }



    }
}
